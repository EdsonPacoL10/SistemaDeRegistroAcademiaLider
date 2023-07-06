using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTROS_ACADEMIA_LIDER
{
    public partial class participante : Form
    {
        public participante()
        {
            InitializeComponent();
        }
       SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");

        string nombre = "";
        public void limpiar_campos()
        {

            txt_codigo_participante.Clear();
            txt_nombre_part.Clear();
            txt_apellido_part.Clear();
            txt_ci_part.Clear();
            txt_grado_academico_part.Clear();
            txt_ciudad.Clear();
            txt_email.Clear();
            txt_celular.Clear();
            txt_nacimiento.Clear();
            txt_profesion_carrera.Clear();
     


            //para poder limpiar campos


        }

        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from praticipante";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }

        private void participante_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Evento  from  eventos ;", conexion);

            //         
            SqlDataReader participante = comando.ExecuteReader();
            while (participante.Read())
            {

                txt_evento.Items.Add(participante["Evento"].ToString());

            }


            conexion.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            participante_busqueda par = new participante_busqueda();
            this.Hide();
            par.Show();

        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        
        private void bot_nuevo_Click(object sender, EventArgs e)
        {
            if ((txt_codigo_participante.Text != "") &&
             (txt_nombre_part.Text != "") &&
             (txt_apellido_part.Text != "") &&
             (txt_ci_part.Text != "") &&
             (txt_grado_academico_part.Text != "") &&
             (txt_ciudad.Text != "") &&
             (txt_email.Text != "") &&
             (txt_celular.Text != "") &&
             (txt_nacimiento.Text != "") &&
             (txt_profesion_carrera.Text != "") &&
             (txt_evento.Text != "")
             )
            {
                SqlCommand cmd = new SqlCommand();
                MemoryStream archivoMemoria = new MemoryStream();
                String rpt;
                conexion.Open();
                cmd.Connection = conexion;

                ptbImagen.Image.Save(archivoMemoria, ImageFormat.Bmp);
                cmd.CommandText = "spinsertar_imagen";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo_participante.Text);
                cmd.Parameters.AddWithValue("@Nombres", txt_nombre_part.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txt_apellido_part.Text);
                cmd.Parameters.AddWithValue("@Cedula_identidad", txt_celular.Text);
                cmd.Parameters.AddWithValue("@Grado_academico", txt_grado_academico_part.Text);
                cmd.Parameters.AddWithValue("@Ciudad_Procedencia", txt_ciudad.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Telefono", txt_celular.Text);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", txt_nacimiento.Text);
                cmd.Parameters.AddWithValue("@Profesion_Carrera", txt_profesion_carrera.Text);
                cmd.Parameters.AddWithValue("@Evento_Curso", txt_evento.Text);
                cmd.Parameters.AddWithValue("@Foto", archivoMemoria.GetBuffer());
                rpt = cmd.ExecuteNonQuery() > 0 ? "se guardo la imagen" : "error";
                MessageBox.Show("Datos guardados de participante correctamente  ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.Close();
                limpiar_campos();

            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
     
        private void bot_guardar_foto_Click(object sender, EventArgs e)
        {
           
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cargar foto
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(dialogo.FileName);
                ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ver foto
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandText = "spmostrar_imagen";
            if (txt_codigo_participante.Text!="") {
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo_participante.Text);
            }
            else
            {
                MessageBox.Show("INGRESE EL CODIGO DEL PARTICAPANTE", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SqlDataAdapter llenar = new SqlDataAdapter(cmd);
            llenar.Fill(tabla);

            Byte[] archivo = (byte[])tabla.Rows[0]["imagen"];
            Stream imagen = new MemoryStream(archivo);
            ptbImagen.Image = Image.FromStream(imagen);
            conexion.Close();
         }

        private void bot_editar_Click(object sender, EventArgs e)
        {
            //Para modificar registro en el boton modificar
            conexion.Open();
            if ((txt_codigo_participante.Text != "") &&
             (txt_nombre_part.Text != "") &&
             (txt_apellido_part.Text != "") &&
             (txt_ci_part.Text != "") &&
             (txt_grado_academico_part.Text != "") &&
             (txt_ciudad.Text != "") &&
             (txt_email.Text != "") &&
             (txt_celular.Text != "") &&
             (txt_nacimiento.Text != "") &&
             (txt_profesion_carrera.Text != "") &&
             (txt_evento.Text != ""))
            {

                SqlCommand cmd = new SqlCommand();
                MemoryStream archivoMemoria = new MemoryStream();
                String rpt;
                cmd.Connection = conexion;

                ptbImagen.Image.Save(archivoMemoria, ImageFormat.Bmp);
                cmd.CommandText = "spmodificar_imagen";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo_participante.Text);
                cmd.Parameters.AddWithValue("@Nombres", txt_nombre_part.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txt_apellido_part.Text);
                cmd.Parameters.AddWithValue("@Cedula_identidad", txt_celular.Text);
                cmd.Parameters.AddWithValue("@Grado_academico", txt_grado_academico_part.Text);
                cmd.Parameters.AddWithValue("@Ciudad_Procedencia", txt_ciudad.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Telefono", txt_celular.Text);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", txt_nacimiento.Text);
                cmd.Parameters.AddWithValue("@Profesion_Carrera", txt_profesion_carrera.Text);
                cmd.Parameters.AddWithValue("@Evento_Curso", txt_evento.Text);
                cmd.Parameters.AddWithValue("@Foto", archivoMemoria.GetBuffer());
                rpt = cmd.ExecuteNonQuery() > 0 ? "se guardo la imagen" : "error";
                MessageBox.Show("Datos se modificaron correctamente  ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               limpiar_campos();
            }
            else
            {
                MessageBox.Show("FALTAN CAMPOS PARA MODIFICAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();

        }

        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txt_codigo_participante.Text != "")
            {
                string consulta = "delete from praticipante where Codigo='" + txt_codigo_participante.Text + "';";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El partipanete fue eliminado con exito");
                }
                else
                {
                    MessageBox.Show("NO PUEDE ELIMINAR, PORQUE EL DATO NO EXISTE");
                }


                actualizar_tabla();
                limpiar_campos();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("DAR EL CODIGO DE PARTICIPANTE QUE DESEA ELIMINAR  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.Close();
            }
        }

        private void bot_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DGV1.CurrentRow.Index;
                txt_codigo_participante.Text =           DGV1[1,pos].Value.ToString();
                txt_nombre_part.Text = DGV1[2, pos].Value.ToString();
            txt_apellido_part.Text = DGV1[3, pos].Value.ToString();
            txt_ci_part.Text = DGV1[4, pos].Value.ToString();
            txt_grado_academico_part.Text = DGV1[5, pos].Value.ToString();
            txt_ciudad.Text = DGV1[6, pos].Value.ToString();
            txt_email.Text = DGV1[7, pos].Value.ToString();
            txt_celular.Text = DGV1[8, pos].Value.ToString();
            txt_nacimiento.Text = DGV1[9, pos].Value.ToString();
            txt_profesion_carrera.Text = DGV1[10, pos].Value.ToString();
            //txt_evento.Text = DGV1.CurrentRow.Cells[10].Value.ToString();


        }

        private void DGV1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DGV1.CurrentRow.Index;
            txt_codigo_participante.Text = DGV1[0, pos].Value.ToString();
            txt_nombre_part.Text = DGV1[1, pos].Value.ToString();
            txt_apellido_part.Text = DGV1[2, pos].Value.ToString();
            txt_ci_part.Text = DGV1[3, pos].Value.ToString();
            txt_grado_academico_part.Text = DGV1[4, pos].Value.ToString();
            txt_ciudad.Text = DGV1[5, pos].Value.ToString();
            txt_email.Text = DGV1[6, pos].Value.ToString();
            txt_celular.Text = DGV1[7, pos].Value.ToString();
            txt_nacimiento.Text = DGV1[8, pos].Value.ToString();
            txt_profesion_carrera.Text = DGV1[9, pos].Value.ToString();
        }

        private void txt_evento_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = txt_evento.SelectedIndex;
            nombre = txt_evento.Items[indice].ToString();
        }

        private void txt_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("EL NUMERO CELULAR SOLO SON NUMEROS, REVISAR !!!", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }
    }
    }
