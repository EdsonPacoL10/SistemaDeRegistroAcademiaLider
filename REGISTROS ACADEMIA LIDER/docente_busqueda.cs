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
    public partial class docente_busqueda : Form
    {
        public docente_busqueda()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new System.Data.SqlClient.SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");

        public void limpiar_campos()
        {
            //para poder limpiar campos
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

        }

        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from docentes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }
        private void bot_buscar_Click(object sender, EventArgs e)
        {
            //boton busqueda  y validacion de datos inresados correctamente
            if (txt_busqueda.Text != "")
            {
                if (rt_codigo_docente.Checked == true || rt_ci_docente.Checked == true || rt_profesion.Checked == true || rt_nombre.Checked == true)
                {

                    if (rt_codigo_docente.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from docentes where Codigo_Docente='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                            txt_codigo.Text = lector1["Codigo_Docente"].ToString();
                            txt_nombre.Text = lector1["Cedula_identidad"].ToString();
                            txt_apellido.Text = lector1["Nombre_Apellido"].ToString();
                            txt_ci.Text = lector1["Grado_Academico"].ToString();
                            txt_grado.Text = lector1["Profesion"].ToString();
                            txt_ciudad.Text = lector1["Cuenta_Bancaria"].ToString();
                            txt_email.Text = lector1["Email"].ToString();
                            txt_celular.Text = lector1["Celular"].ToString();
                            txt_fecha.Text = lector1["Ciudad"].ToString();
                            txt_profe.Text = lector1["Evento_Capacitador"].ToString();



                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        conexion.Close();

                    }
                    if (rt_ci_docente.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from docentes where Cedula_identidad='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                            txt_codigo.Text = lector1["Codigo_Docente"].ToString();
                            txt_nombre.Text = lector1["Cedula_identidad"].ToString();
                            txt_apellido.Text = lector1["Nombre_Apellido"].ToString();
                            txt_ci.Text = lector1["Grado_Academico"].ToString();
                            txt_grado.Text = lector1["Profesion"].ToString();
                            txt_ciudad.Text = lector1["Cuenta_Bancaria"].ToString();
                            txt_email.Text = lector1["Email"].ToString();
                            txt_celular.Text = lector1["Celular"].ToString();
                            txt_fecha.Text = lector1["Ciudad"].ToString();
                            txt_profe.Text = lector1["Evento_Capacitador"].ToString();


                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        conexion.Close();

                    }
                    //----------------------------------
                    if (rt_profesion.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from docentes where Profesion='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                            txt_codigo.Text = lector1["Codigo_Docente"].ToString();
                            txt_nombre.Text = lector1["Cedula_identidad"].ToString();
                            txt_apellido.Text = lector1["Nombre_Apellido"].ToString();
                            txt_ci.Text = lector1["Grado_Academico"].ToString();
                            txt_grado.Text = lector1["Profesion"].ToString();
                            txt_ciudad.Text = lector1["Cuenta_Bancaria"].ToString();
                            txt_email.Text = lector1["Email"].ToString();
                            txt_celular.Text = lector1["Celular"].ToString();
                            txt_fecha.Text = lector1["Ciudad"].ToString();
                            txt_profe.Text = lector1["Evento_Capacitador"].ToString();


                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        conexion.Close();

                    }
                    //----------------------------------
                    if (rt_nombre.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from docentes where Nombre_Apellido='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                           
                            txt_codigo.Text = lector1["Codigo_Docente"].ToString();
                            txt_nombre.Text = lector1["Cedula_identidad"].ToString();
                            txt_apellido.Text = lector1["Nombre_Apellido"].ToString();
                            txt_ci.Text = lector1["Grado_Academico"].ToString();
                            txt_grado.Text = lector1["Profesion"].ToString();
                            txt_ciudad.Text = lector1["Cuenta_Bancaria"].ToString();
                            txt_email.Text = lector1["Email"].ToString();
                            txt_celular.Text = lector1["Celular"].ToString();
                            txt_fecha.Text = lector1["Ciudad"].ToString();
                            txt_profe.Text = lector1["Evento_Capacitador"].ToString();
                            


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
                    MessageBox.Show(" NO ESTA SELECCIONADO UNA OPCION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("NO HAY DATO DE BUSQUEDA ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void docente_busqueda_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void bot_atras_Click(object sender, EventArgs e)
        {

            docente frmMenu = new docente();
            this.Hide();
            frmMenu.Show();
        }
    }
}
