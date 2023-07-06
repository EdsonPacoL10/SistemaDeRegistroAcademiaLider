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
    public partial class Menu_busqueda : Form
    {
        public Menu_busqueda()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new System.Data.SqlClient.SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton busqueda  y validacion de datos inresados correctamente
            if (txt_busqueda.Text != "")
            {
                if (rt_participantes.Checked == true 
                    || rt_ebentos.Checked == true 
                    || rt_certidicados.Checked == true 
                    || rt_docentes.Checked == true
                    || rt_usuarios_regsitrp.Checked == true)
                {
                    //participantes
                    if (rt_participantes.Checked == true)
                    {
                        if (rt_codigo_participante.Checked == true) { 
                        conexion.Open();
                        string consulta1 = "select  * from praticipante where Codigo='" + txt_busqueda.Text + "';";

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
                        //
                        if (rt_evento_participante.Checked == true)
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
                            //
                   }

                    //docentes
                    if (rt_docentes.Checked == true)
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
                                txt_grado.Text = lector1["Cuenta_Bancaria"].ToString();
                                txt_ciudad.Text = lector1["Email"].ToString();
                                txt_email.Text = lector1["Celular"].ToString();
                                txt_celular.Text = lector1["Ciudad"].ToString();
                                txt_fecha.Text = lector1["Evento_Capacitador"].ToString();
                    
                               

                            }
                            else
                            {
                                MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            conexion.Close();
                            
                        }
                        //
                        if (rt_evento_participante.Checked == true)
                        {
                            conexion.Open();
                            string consulta1 = "select  * from docentes where Evento_Capacitador='" + txt_busqueda.Text + "';";

                            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                            SqlDataReader lector1;
                            lector1 = comando1.ExecuteReader();
                            if (lector1.Read())
                            {
                                txt_codigo.Text   = lector1["Codigo_Docente"].ToString();
                                txt_nombre.Text   = lector1["Cedula_identidad"].ToString();
                                txt_apellido.Text = lector1["Nombre_Apellido"].ToString();
                                txt_ci.Text       = lector1["Grado_Academico"].ToString();
                                txt_grado.Text    = lector1["Cuenta_Bancaria"].ToString();
                                txt_ciudad.Text   = lector1["Email"].ToString();
                                txt_email.Text    = lector1["Celular"].ToString();
                                txt_celular.Text  = lector1["Ciudad"].ToString();
                                txt_fecha.Text    = lector1["Evento_Capacitador"].ToString();


                            }
                            else
                            {
                                MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            conexion.Close();
                           
                        }
                        //
                    }

                    //evento

                    if (rt_ebentos.Checked == true)
                    {
                        if (rt_cofigo_evento.Checked == true)
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
                                txt_celular.Text = lector1["Estado"].ToString();
                                txt_fecha.Text = lector1["Docente"].ToString();



                            }
                            else
                            {
                                MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            conexion.Close();
                            
                        }
                        //
                        if (rt_nombre_evento.Checked == true)
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
                                txt_celular.Text = lector1["Estado"].ToString();
                                txt_fecha.Text = lector1["Docente"].ToString();

                            }
                            else
                            {
                                MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            conexion.Close();
                            
                        }
                        //certficados

                    }
                    //certficados
                    if (rt_certidicados.Checked == true)
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
                        //
                        if (rt_nombre_certidicado.Checked == true)
                        {
                            conexion.Open();
                            string consulta1 = "select  * from certificado where nombre_Certificado='" + txt_busqueda.Text + "';";

                            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                            SqlDataReader lector1;
                            lector1 = comando1.ExecuteReader();
                            if (lector1.Read())
                            {
                                txt_codigo.Text = lector1["Codigo_Certificado"].ToString();
                                txt_nombre.Text = lector1["nombre_Certificado"].ToString();
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
                        //certficados

                    }

                    if (rt_usuarios_regsitrp.Checked == true)
                    {
                        if (rt_codigo_usuario.Checked == true)
                        {
                            conexion.Open();
                            string consulta1 = "select  * from usuarios where Codigo='" + txt_busqueda.Text + "';";

                            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                            SqlDataReader lector1;
                            lector1 = comando1.ExecuteReader();
                            if (lector1.Read())
                            {
                                txt_codigo.Text = lector1["Codigo"].ToString();
                                txt_nombre.Text = lector1["Nombre"].ToString();
                                txt_apellido.Text = lector1["Apellido"].ToString();
                                txt_ci.Text = lector1["Cargo"].ToString();
                                txt_grado.Text = lector1["Rol"].ToString();





                            }
                            else
                            {
                                MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            conexion.Close();
                           
                        }
                        //
                        if (RT_USUARIO_USU.Checked == true)
                        {
                            conexion.Open();
                            string consulta1 = "select  * from usuarios where Usuario='" + txt_busqueda.Text + "';";

                            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                            SqlDataReader lector1;
                            lector1 = comando1.ExecuteReader();
                            if (lector1.Read())
                            {
                                txt_codigo.Text = lector1["Codigo"].ToString();
                                txt_nombre.Text = lector1["Nombre"].ToString();
                                txt_apellido.Text = lector1["Apellido"].ToString();
                                txt_ci.Text = lector1["Cargo"].ToString();
                                txt_grado.Text = lector1["Rol"].ToString();


                            }
                            else
                            {
                                MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            conexion.Close();
                         
                        }
                        //certficados

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

        private void Menu_busqueda_Load(object sender, EventArgs e)
        {

        }

        private void txt_ci_part_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
