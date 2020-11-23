using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitySource
{
    public partial class FrmProcessing : Form
    {
        private ParameterizedThreadStart workAction = null;
        private object workActionArg = null;
        private Thread workThread = null;

        public Exception WorkException{ get; private set; }

        public FrmProcessing(ParameterizedThreadStart workAction, object arg)
        {
            InitializeComponent();
            this.workAction = workAction;
            workActionArg = arg;
        }

        private void FrmProcessing_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                StartPosition = FormStartPosition.Manual;
                Location = new Point(Owner.Left, Owner.Top);
                Width = Owner.Width;
                Height = Owner.Height;
            }
            else
            {
                Rectangle screenRect = Screen.PrimaryScreen.WorkingArea;
                Location = new Point((screenRect.Width - Width) / 2, (screenRect.Height - Height) / 2);
            }
        }

        private void FrmProcessing_Shown(object sender, EventArgs e)
        {
            if (workAction != null)
            {
                workThread = new Thread(ExecWorkAction);
                workThread.IsBackground = true;
                workThread.Start();
            }
        }

        private void ExecWorkAction()
        {
            try
            {
                var workTask = new Task((arg) =>
                {
                    Thread.Sleep(3000);
                    workAction(arg);
                }, workActionArg);
                workTask.Start();
                Task.WaitAll(workTask);
            }
            catch (Exception ex)
            {
                WorkException = ex;
            }
            finally
            {
                Invoke(new Action(()=> { Close(); }));
            }

        }
    }

    public static class ProcessCommon
    {
        public static void ShowProcessing(Form owner, ParameterizedThreadStart work, object workArg = null)
        {
            FrmProcessing processingForm = new FrmProcessing(work, workArg);
            //dynamic expObj = new ExpandoObject();
            //expObj.Form = processingForm;
            //expObj.WorkArg = workArg;
            //processingForm.SetWorkAction(work, expObj);
            processingForm.ShowDialog(owner);
            if (processingForm.WorkException != null)
            {
                throw processingForm.WorkException;
            }
        }
    }
}

