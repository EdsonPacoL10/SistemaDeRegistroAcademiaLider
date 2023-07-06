using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTROS_ACADEMIA_LIDER
{
    public partial class participante_busqueda : Form
    {
        public participante_busqueda()
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
            txt_ciudad.Clear();
            txt_email.Clear();
            txt_celular.Clear();
            txt_fecha.Clear();
            txt_profe.Clear();
            txt_evento.Clear();

            //para poder limpiar campos


        }


        public void actualizar_tabla()


        {
            //actualizacion de la tabla segun la consulta select
            string consulta = "select * from praticipante";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //ver foto
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandText = "spmostrar_imagen";
            if (txt_codigo.Text != "")
            {
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo);
            }
            else
            {
                MessageBox.Show("INGRESE EL CODIGO DEL PARTICAPANTE", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SqlDataAdapter llenar = new SqlDataAdapter(cmd);
            llenar.Fill(tabla);

            Byte[] archivo = (byte[])tabla.Rows[0]["imagen"];
            Stream imagen = new MemoryStream(archivo);
            //ptbImagen.Image = Image.FromStream(imagen);
            conexion.Close();
        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            if ((rt_codigo_participante.Checked == true
                    || rt_nombre.Checked == true
                    || rt_evento.Checked == true
                    || rt_ci.Checked == true)
                   )
            {
                if (rt_codigo_participante.Checked == true)
                {
                    conexion.Open();
                    string consulta1 = "select  * from praticipante where Codigo ='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text =    lector1["Codigo"].ToString();
                        txt_nombre.Text =    lector1["Nombres"].ToString();
                        txt_apellido.Text =  lector1["Apellidos"].ToString();
                        txt_ci.Text =        lector1["Cedula_identidad"].ToString();
                        txt_grado.Text =     lector1["Grado_academico"].ToString();
                        txt_ciudad.Text =    lector1["Ciudad_Procedencia"].ToString();
                        txt_email.Text =     lector1["Email"].ToString();
                        txt_celular.Text =   lector1["Telefono"].ToString();
                        txt_fecha.Text =     lector1["Fecha_Nacimiento"].ToString();
                        txt_profe.Text =     lector1["Profesion_Carrera"].ToString();
                        txt_evento.Text =    lector1["Evento_Curso"].ToString();

                    }
                    else
                    {
                        MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    conexion.Close();

                }
                if (rt_nombre.Checked == true)
                {
                    conexion.Open();
                    string consulta1 = "select  * from praticipante where Nombres='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text = lector1["Codigo"].ToString();
                        txt_nombre.Text = lector1["Nombres"].ToString();
                        txt_apellido.Text = lector1["Apellidos"].ToString();
                        txt_ci.Text = lector1["Cedula_identidad"].ToString();
                        txt_grado.Text = lector1["Grado_academico"].ToString();
                        txt_ciudad.Text = lector1["Ciudad_Procedencia"].ToString();
                        txt_email.Text = lector1["Email"].ToString();
                        txt_celular.Text = lector1["Telefono"].ToString();
                        txt_fecha.Text = lector1["Fecha_Nacimiento"].ToString();
                        txt_profe.Text = lector1["Profesion_Carrera"].ToString();
                        txt_evento.Text = lector1["Evento_Curso"].ToString();

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
                    string consulta1 = "select  * from praticipante where Evento_Curso='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text = lector1["Codigo"].ToString();
                        txt_nombre.Text = lector1["Nombres"].ToString();
                        txt_apellido.Text = lector1["Apellidos"].ToString();
                        txt_ci.Text = lector1["Cedula_identidad"].ToString();
                        txt_grado.Text = lector1["Grado_academico"].ToString();
                        txt_ciudad.Text = lector1["Ciudad_Procedencia"].ToString();
                        txt_email.Text = lector1["Email"].ToString();
                        txt_celular.Text = lector1["Telefono"].ToString();
                        txt_fecha.Text = lector1["Fecha_Nacimiento"].ToString();
                        txt_profe.Text = lector1["Profesion_Carrera"].ToString();
                        txt_evento.Text = lector1["Evento_Curso"].ToString();

                    }
                    else
                    {
                        MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    conexion.Close();

                }
                if (rt_ci.Checked == true)
                {
                    conexion.Open();
                    string consulta1 = "select  * from praticipante where Cedula_identidad='" + txt_busqueda.Text + "';";

                    SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                    SqlDataReader lector1;
                    lector1 = comando1.ExecuteReader();
                    if (lector1.Read())
                    {
                        txt_codigo.Text = lector1["Codigo"].ToString();
                        txt_nombre.Text = lector1["Nombres"].ToString();
                        txt_apellido.Text = lector1["Apellidos"].ToString();
                        txt_ci.Text = lector1["Cedula_identidad"].ToString();
                        txt_grado.Text = lector1["Grado_academico"].ToString();
                        txt_ciudad.Text = lector1["Ciudad_Procedencia"].ToString();
                        txt_email.Text = lector1["Email"].ToString();
                        txt_celular.Text = lector1["Telefono"].ToString();
                        txt_fecha.Text = lector1["Fecha_Nacimiento"].ToString();
                        txt_profe.Text = lector1["Profesion_Carrera"].ToString();
                        txt_evento.Text = lector1["Evento_Curso"].ToString();

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

        private void participante_busqueda_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            participante frmMenu = new participante();
            this.Hide();
            frmMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }
    }
}
