using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTROS_ACADEMIA_LIDER
{
    public partial class certificados_busqueda : Form
    {
        public certificados_busqueda()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new System.Data.SqlClient.SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        public void actualizar_tabla()


        {
            //actualizacion de la tabla segun la consulta select
            string consulta = "select * from certificado";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void certificados_busqueda_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            if (rt_codigo_certificado.Checked == true||rt_cedula.Checked==true)
            {
                if (rt_codigo_certificado.Checked == true)
                {
                   
                         conexion.Open();
                        string consulta1 = "select  * from certificado where Codigo_Certificado='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                            txt_codigo.Text = lector1["Codigo_Certificado"].ToString();
                            txt_nombre.Text = lector1["nombre_Certificado"].ToString();
                            txt_apellidos.Text = lector1["apellido_Certificado"].ToString();
                        txt_apellido.Text = lector1["Cedula_certificado"].ToString();
                        txt_ci.Text = lector1["Evento"].ToString();
                            txt_grado.Text = lector1["Nota"].ToString();
                            txt_ciudad.Text = lector1["Fecha"].ToString();
                           

                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        conexion.Close();
                    }
                if (rt_cedula.Checked == true)
                {

                    conexion.Open();
                    string consulta1 = "select  * from certificado where Cedula_certificado='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text = lector1["Codigo_Certificado"].ToString();
                        txt_nombre.Text = lector1["nombre_Certificado"].ToString();
                        txt_apellidos.Text = lector1["apellido_Certificado"].ToString();
                        txt_apellido.Text = lector1["Cedula_certificado"].ToString();
                        txt_ci.Text = lector1["Evento"].ToString();
                        txt_grado.Text = lector1["Nota"].ToString();
                        txt_ciudad.Text = lector1["Fecha"].ToString();


                    }
                    else
                    {
                        MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    conexion.Close();
                }

            }
            else
            {
                MessageBox.Show("SELECCIONE UNA OPCION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bot_atras_Click(object sender, EventArgs e)
        {

        }
    }
}
