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
    public partial class evento_busqueda : Form
    {
        public evento_busqueda()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new System.Data.SqlClient.SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");

        public void limpiar_campos()
        {

        
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_ci.Clear();
            txt_grado.Clear();
            txt_email.Clear();
            txt_estado.Clear();
            txt_celular.Clear();

            //para poder limpiar campos


        }

        public void actualizar_tabla()


        {
            //actualizacion de la tabla segun la consulta select
            string consulta = "select * from eventos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }
        private void evento_busqueda_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            if (rt_codigo_evento.Checked == true || rt_evento.Checked == true)
            {
                if (rt_codigo_evento.Checked == true)
                {

                    conexion.Open();
                    string consulta1 = "select  * from eventos where Codigo_Evento='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text = lector1["Codigo_Evento"].ToString();
                        txt_nombre.Text = lector1["Evento"].ToString();
                        txt_apellido.Text = lector1["Modalidad"].ToString();
                        txt_ci.Text = lector1["Carga_Horaria"].ToString();
                        txt_grado.Text = lector1["Fecha_inicio"].ToString();
                        txt_ciudad.Text = lector1["Fecha_Final"].ToString();
                        txt_email.Text = lector1["Ciudad"].ToString();
                        txt_estado.Text = lector1["Estado"].ToString();
                        txt_celular.Text = lector1["Docente"].ToString();
                       


                    }
                    else
                    {
                        MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    conexion.Close();
                }
                if (rt_evento.Checked == true)
                {

                    conexion.Open();
                    string consulta1 = "select  * from eventos where Evento='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text = lector1["Codigo_Evento"].ToString();
                        txt_nombre.Text = lector1["Evento"].ToString();
                        txt_apellido.Text = lector1["Modalidad"].ToString();
                        txt_ci.Text = lector1["Carga_Horaria"].ToString();
                        txt_grado.Text = lector1["Fecha_inicio"].ToString();
                        txt_ciudad.Text = lector1["Fecha_Final"].ToString();
                        txt_email.Text = lector1["Ciudad"].ToString();
                        txt_estado.Text = lector1["Estado"].ToString();
                        txt_celular.Text = lector1["Docente"].ToString();


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

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            evento frmMenu = new evento();
            this.Hide();
            frmMenu.Show();
        }
    }
}
