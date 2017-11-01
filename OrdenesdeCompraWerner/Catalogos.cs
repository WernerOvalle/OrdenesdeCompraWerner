using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace OrdenesdeCompraWerner
{
    public partial class Catalogos : Form
    {
        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";

        public Catalogos()
        {
            InitializeComponent();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
                string sql = @"SELECT precio FROM productos WHERE idProducto =  '" + comboBox3.Text+ "'";
            string sql2 = @"SELECT descripcion FROM productos WHERE idProducto =  '" + comboBox3.Text + "'";

            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();




            OdbcCommand cmd = new OdbcCommand(sql, conector);
            int suma = Convert.ToInt32(cmd.ExecuteScalar());


            textBox3.Text = suma.ToString();

            OdbcCommand cmd2 = new OdbcCommand(sql2, conector);

            string hola= Convert.ToString(cmd2.ExecuteScalar());

            textBox4.Text = hola;




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Catalogos_Load(object sender, EventArgs e)
        {
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();

            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from hotelsancarlosv2.departamento";

                OdbcDataAdapter da1 = new OdbcDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "nombreDepartamento";
                comboBox1.DisplayMember = "nombreDepartamento";

                comboBox1.DataSource = dt;
               
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from hotelsancarlosv2.productos";

                OdbcDataAdapter da2 = new OdbcDataAdapter(sentencia);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);


                comboBox3.ValueMember = "idProducto";
                comboBox3.DisplayMember = "idProducto";

                comboBox3.DataSource = dt2;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from hotelsancarlosv2.proveedores";

                OdbcDataAdapter da3 = new OdbcDataAdapter(sentencia);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);


                comboBox2.ValueMember = "nombreProveedor";
                comboBox2.DisplayMember = "nombreProveedor";

                comboBox2.DataSource = dt3;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }



        }

        private void Catalogostab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
