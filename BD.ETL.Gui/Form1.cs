using DB.ETL.Data.Dao;
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
            this.CenterToScreen();
        }

        ProductoDao pd = new ProductoDao();
        EmpleadoDao ed = new EmpleadoDao();
        EnviosDao kd = new EnviosDao();
        OrdenDao od = new OrdenDao();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Modificar Precio
            Task.Run(() =>
            {
                pd.ModificarPrecio();
                MessageBox.Show("Precio Modificado");
            });
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                pd.CambiarNombreProducto();
                MessageBox.Show("Producto Modificado");
            });            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pd.CambiarCategoria();
            MessageBox.Show("Producto Modificado");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ed.CambiarDatos(),"Empleado Modificado");            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kd.ModificarEnvio(),"Envio Modificado");            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            od.ModificarOrdenes();
            MessageBox.Show("Se modificaron 5 ordenes");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            ed.BoostearEmpleado();
            MessageBox.Show("Se boosteo al empleado");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            od.ModificarCantidadPaises();
            MessageBox.Show("Se boosteo un pais");
        }
    }
}
