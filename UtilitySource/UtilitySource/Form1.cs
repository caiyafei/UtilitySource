using DevExpress.XtraBars.Docking2010.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitySource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        void Init()
        {
            //int[] idx = { 1, 2, 3, 4, 5, 6 };
            //// Handling the QueryControl event that will populate all automatically generated Documents
            //widgetView1.Documents.Clear();
            //for (int i = 0; i < idx.Length; i++)
            //{
            //    DevExpress.XtraBars.Docking2010.Views.Widget.Document d = (DevExpress.XtraBars.Docking2010.Views.Widget.Document)widgetView1.AddDocument(new RoundPanel() { Dock = DockStyle.Fill, BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, BackColor = Color.Blue, Radius = 20 });
            //    d.Properties.AllowDragging = DevExpress.Utils.DefaultBoolean.False;
            //    d.Properties.ShowBorders = DevExpress.Utils.DefaultBoolean.False;
            //    d.RowIndex = i / 5;
            //    d.ColumnIndex = i % 5;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessCommon.ShowProcessing(this, (obj) => { Init(); }, null);
        }
    }
}
