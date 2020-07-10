using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitySource
{
    static class Program
    {
        #region 指定依赖文件路径，启动程序路径
        //internal static AppDomain domain;
        //static Mutex mutex;
        //static bool isNew;
        //const string privateBinPath = "Debug\\LibsDev;Release\\LibsDev";
        //const string configurationFile = "Debug\\Test1.exe.config";
        //static string AassemlbyPath;
        //static Program()
        //{
        //    AppDomain.CurrentDomain.SetData("PRIVATE_BINPATH", privateBinPath);
        //    AppDomain.CurrentDomain.SetData("BINPATH_PROBE_ONLY", privateBinPath);
        //    var setup = typeof(AppDomainSetup).GetMethod("UpdateContextProperty", BindingFlags.NonPublic | BindingFlags.Static);
        //    var fusion = typeof(AppDomain).GetMethod("GetFusionContext", BindingFlags.NonPublic | BindingFlags.Instance);
        //    setup.Invoke(null, new object[] { fusion.Invoke(AppDomain.CurrentDomain, null), "PRIVATE_BINPATH", privateBinPath });

        //    //AppDomain.CurrentDomain.SetData("PRIVATE_BINPATH", privateBinPath);
        //    //AppDomain.CurrentDomain.SetData("BINPATH_PROBE_ONLY", privateBinPath);
        //    //var setup = typeof(AppDomainSetup).GetMethod("UpdateContextProperty", BindingFlags.NonPublic | BindingFlags.Static);
        //    //var funsion = typeof(AppDomain).GetMethod("GetFusionContext", BindingFlags.NonPublic | BindingFlags.Instance);
        //    //setup.Invoke(null, new object[] { funsion.Invoke(AppDomain.CurrentDomain, null), "PRIVATE_BINPATH", privateBinPath });
        //}

        ///// <summary>
        ///// 应用程序的主入口点。
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    using (mutex = new Mutex(true, Application.ProductName, out isNew))
        //    {
        //        if (isNew)
        //        {
        //            Application.EnableVisualStyles();
        //            Application.SetCompatibleTextRenderingDefault(false);

        //            AassemlbyPath = "Debug\\Test1.exe";

        //            var setup = new AppDomainSetup()
        //            {
        //                ApplicationBase = Environment.CurrentDirectory,
        //                ConfigurationFile = configurationFile,
        //                PrivateBinPath = privateBinPath
        //            };
        //            domain = AppDomain.CreateDomain("Test1", null, setup);
        //            domain.SetData("UIStarted", false);
        //            //ListinUIState();
        //            domain.ExecuteAssembly(AassemlbyPath, new string[] { });
        //            AppDomain.Unload(domain);
        //        }
        //        else
        //        {
        //        }
        //    }
        //}
        #endregion
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
