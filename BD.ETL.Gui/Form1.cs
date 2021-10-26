using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.SqlServer.Dts.Runtime;

namespace BD.ETL.Gui
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSincro_Click(object sender, EventArgs e)
        {
            //string PackageName;
            //Package pkg;
            //Microsoft.SqlServer.Dts.Runtime.Application app;
            //DTSExecResult pkgResults;

            ////MyEventListener eventListener = new MyEventListener();

            //PackageName = @"C:\Users\mmalik\Desktop\New SSIS PKG\TestSSISpkg\TestSSISpkg\Package.dtsx";
            //app = new Microsoft.SqlServer.Dts.Runtime.Application();
            //pkg = app.LoadPackage(PackageName, null);
        }
    }
}
