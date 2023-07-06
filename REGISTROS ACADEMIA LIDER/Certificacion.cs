using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
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
    public partial class Certificacion : Form
    {
        public Certificacion()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        string contqr="";
     //datos
       string nombre="";
    string apellido="";
          string  ci = "";
         string   evento_taller="";
        string    codigo_participante = "";

       
     
        public void limpiar_campos()
        {

            txt_codigo.Clear();
            txt_nota.Clear();
            fecha.Clear();

            //para poder limpiar campos
        }

        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from certificado";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        private void bot_generar_Click(object sender, EventArgs e)
        {
            contqr = "Codigo Certificado:.." + txt_codigo_cer.Text + "Nombre :." + cob_nombre.Text + " Apellido:." + cob_apellid.Text + " Cedula Identidad:." +
                              comb_ci.Text + " Evento:." + com_evento.Text + " Nota:." + txt_nota.Text + " fecha:." + fecha.Text;

          
            QrEncoder qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEnconder.TryEncode(contqr.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(350, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(180, 180)));
            pictureBox1.BackgroundImage = imagen;
            imagen.Save("imagen.png", ImageFormat.Png);
            bot_guardar.Enabled = true;
        }

        private void bot_guardar_Click(object sender, EventArgs e)
        {
            Image image = (Image)pictureBox1.BackgroundImage.Clone();
            SaveFileDialog cajadialogoguardar = new SaveFileDialog();
            cajadialogoguardar.AddExtension = true;
            cajadialogoguardar.Filter = "Image PNG (*.png)|*.png";
            cajadialogoguardar.ShowDialog();
            if (!string.IsNullOrEmpty(cajadialogoguardar.FileName))
            {
                image.Save(cajadialogoguardar.FileName, ImageFormat.Png);
            }
            image.Dispose();
        }

        private void bot_subir_foto_Click(object sender, EventArgs e)
        {
            //ver foto
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandText = "spmostrar_imagen";
            if (txt_codigo_cer.Text != "")
            {
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo_cer.Text);
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

        private void bot_nuevo_Click(object sender, EventArgs e)
        {
            

            if ((txt_codigo.Text != "") &&
                (txt_nota.Text != "") &&
                (fecha.Text != ""))
            {
                if (Int16.Parse(txt_nota.Text)>=51) {
                    
                    conexion.Open();
                    string consulta = "insert into certificado (Codigo_Certificado,nombre_Certificado,apellido_Certificado,Cedula_certificado,Evento,Nota ,Fecha)  values('" + txt_codigo.Text +
                     "','" + cob_nombre.Text +
                     "','" + cob_apellid.Text +
                     "','" + comb_ci.Text +
                     "','" + com_evento.Text +
                     "','" + txt_nota.Text +
                     "','" + fecha.Text + "');";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro de evento agregado a la Base de Datos");
                    actualizar_tabla();
                    limpiar_campos();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("LA NOTA NO ES MAYORA 51 PTS EL CERTIFICADO NO PUEDE REALIZARSE", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Certificacion_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
            conexion.Open();
            SqlCommand comando = new SqlCommand("select p.Nombres ,p.Apellidos,p.Cedula_identidad,e.Evento ,p.Codigo from praticipante p, eventos e where p.Evento_Curso=e.Evento  ;", conexion);
            
            //         
            SqlDataReader participante = comando.ExecuteReader();
            while (participante.Read())
            {
                cob_nombre.Items.Add(participante["Nombres"].ToString());
                cob_apellid.Items.Add(participante["Apellidos"].ToString());
                comb_ci.Items.Add(participante["Cedula_identidad"].ToString());
                com_evento.Items.Add(participante["Evento"].ToString());
                txt_codigo_cer.Items.Add(participante["Codigo"].ToString());
            }
          

            conexion.Close();

        }

        private void cob_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cob_nombre.SelectedIndex;
            nombre = cob_nombre.Items[indice].ToString();
        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            certificados_busqueda frmMenu = new certificados_busqueda();
            this.Hide();
            frmMenu.Show();
        }

        private void bot_elimianr_Click(object sender, EventArgs e)
        {

            conexion.Open();
            if (txt_codigo_cer.Text != "")
            {
                string consulta = "delete from certificado where Codigo_Certificado='" + txt_codigo.Text + "';";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El CERTIFICADO  fue eliminado con exito");
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
                MessageBox.Show("DAR EL CODIGO DE DOCENTE QUE DESEA ELIMINAR  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.Close();
            }
        }

        private void bot_editar_Click(object sender, EventArgs e)
        {
            //Para modificar registro en el boton modificar
            conexion.Open();
            if ((txt_codigo.Text != "") &&
                (txt_nota.Text != "") &&
                (fecha.Text != ""))
            {

                string consulta = "UPDATE certificado SET " +
                    "Codigo_Certificado ='" + txt_codigo_cer.Text +
                    "',nombre_Certificado ='" +cob_nombre.Text +
                    "',apellido_Certificado='" + cob_apellid.Text +
                    "',Cedula_certificado='" + comb_ci.Text +
                    "',Evento='" + com_evento.Text +
                    "',Nota='" + txt_nota.Text +
                    "',Fecha='" + fecha.Text +
                       "' where Codigo_Certificado='" + txt_codigo.Text + "';";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El certificado fue modificado en la Base de  Datos");
                }
                else
                {
                    MessageBox.Show("NO PODEMOS MODIFICAR PORQUE EL DATO NO EXISTE");
                }
                actualizar_tabla();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("FALTAN CAMPOS PARA MODIFICAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        }

        private void bot_actualizar_Click(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void bot_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txt_codigo.Text != "") &&
                (txt_nota.Text != "") &&
                (fecha.Text != ""))
            {

                IMPRESION dato = new IMPRESION();
                dato.txt_codigo_certificado.Text = txt_codigo_cer.Text;
                MessageBox.Show(txt_codigo_cer.Text, "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dato.txt_nombre_ceertirficado.Text = nombre;
                dato.txt_apellido_certificado.Text = apellido;
                dato.txt_ci_certificado.Text = ci;
                MessageBox.Show(ci, "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dato.txt_evento.Text = evento_taller;
                MessageBox.Show(evento_taller, "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dato.txt_nota.Text = txt_nota.Text;
                dato.txt_fecha.Text = fecha.Text;
                dato.txt_codigo_participante.Text = codigo_participante;
                dato.Show();


            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("LLENA TODOS LOS DATOS  PARA IMPRIMIR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void cob_apellid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cob_apellid.SelectedIndex;
            apellido = cob_apellid.Items[indice].ToString();
        }

        private void comb_ci_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comb_ci.SelectedIndex;
            ci = comb_ci.Items[indice].ToString();
        }

        private void com_evento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = com_evento.SelectedIndex;
            evento_taller = com_evento.Items[indice].ToString();
        }

        private void txt_codigo_cer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = txt_codigo_cer.SelectedIndex;
            codigo_participante = txt_codigo_cer.Items[indice].ToString();
        }

        private void txt_nota_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("DAR DATOS NUMERICOS PARA LA NOTA PORFAVOR", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }
    }
}
