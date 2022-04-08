using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;

namespace MyApp
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        string key = ConfigurationManager.AppSettings["Key"];
        string iv = ConfigurationManager.AppSettings["IV"];
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 加解密
        private void btnEncry_Click(object sender, EventArgs e)
        {
            if (meTxt1.Text.Trim() == "")
                meTxt2.Text = "";
            else
                meTxt2.Text = AesEncrypt(meTxt1.Text.Trim(), key, iv);
        }

        private void btnDecry_Click(object sender, EventArgs e)
        {
            if (meTxt2.Text.Trim() == "")
                meTxt1.Text = "";
            else
                meTxt1.Text = AesDecrypt(meTxt2.Text.Trim(), key, iv);
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string DesEncrypt(string encryptString, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 8));
            byte[] keyIV = keyBytes;
            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, provider.CreateEncryptor(keyBytes, keyIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <returns></returns>
        public static string DesDecrypt(string decryptString, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 8));
            byte[] keyIV = keyBytes;
            byte[] inputByteArray = Convert.FromBase64String(decryptString);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, provider.CreateDecryptor(keyBytes, keyIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Encoding.UTF8.GetString(mStream.ToArray());
        }
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="encryptStr">明文</param>
        /// <returns></returns>
        public static string AesEncrypt(string encryptStr, string Key, string IV)
        {
            //key不足补F,iv不足补E
            string key = Key.PadRight(32, 'F');
            string iv = IV.PadRight(32, 'E');
            byte[] keyArray = new byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key), keyArray, keyArray.Length);
            byte[] ivArray = new byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(iv), ivArray, ivArray.Length);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(encryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.IV = ivArray;
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="decryptStr">密文</param>
        /// <returns></returns>
        public static string AesDecrypt(string decryptStr, string Key, string IV)
        {
            string key = Key.PadRight(32, 'F');
            string iv = IV.PadRight(32, 'E');
            byte[] keyArray = new byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key), keyArray, keyArray.Length);
            byte[] ivArray = new byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(iv), ivArray, ivArray.Length);
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.IV = ivArray;
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }
        #endregion

        private void navPageSecurity_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "修改":
                    gvSecurity.OptionsBehavior.Editable = true;
                    gvSecurity.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                    break;
                case "保存":
                    DataHelper.Update(gcSecurity.DataSource as TList<Security>);
                    gvSecurity.OptionsBehavior.Editable = false;
                    gvSecurity.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    break;
                case "转移":
                    //DataHelper.Update(gcSecurity.DataSource as TList<Security>);
                    //gvSecurity.OptionsBehavior.Editable = false;
                    //gvSecurity.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    SqliteUtils sqliteUtils = new SqliteUtils();
                    sqliteUtils.Update(gcSecurity.DataSource as TList<Security>);
                    break;
                default:
                    break;
            }
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            gvSecurity.OptionsBehavior.Editable = false;
            gvSecurity.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            SelectData();
        }

        void SelectData()
        {
            TList<Security> list= DataHelper.GetAll<Security>();
            gcSecurity.DataSource = list;
        }

    }
}
