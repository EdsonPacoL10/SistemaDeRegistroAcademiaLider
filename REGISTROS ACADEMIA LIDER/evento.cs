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
    public partial class evento : Form
    {
        public evento()
        {
            InitializeComponent();
        }
        string contqr = "";
        string conbestado = "";
        string conbmodalidad = "";
        SqlConnection
            conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        
        public void limpiar_campos()
        {

            txt_codigo_env.Clear();
            txt_evento.Clear();
            txt_carfa_horaria.Clear();
            txt_fecha_inicio.Clear();
            txt_fecha_final.Clear();
            txt_ciudad.Clear();
            txt_docente.Clear();


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

        private void evento_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        
        private void bot_nuevo_Click(object sender, EventArgs e)
          
        {


            if ((txt_codigo_env.Text != "") &&
                (txt_evento.Text != "") && 
                (txt_carfa_horaria.Text != "") &&
                (txt_fecha_final.Text != "") &&
                (txt_fecha_inicio.Text != "") &&
                (txt_ciudad.Text != "") &&
                (txt_docente.Text != ""))
            {

                if (conbmodalidad == "Virtual" || conbmodalidad == "Presencial")
                {
                    if (conbestado== "ACTIVO" || conbestado == "INACTIVO")
                    {
                      
                        conexion.Open();
                        string consulta = "insert into eventos (Codigo_Evento,Evento,Modalidad,Carga_Horaria,Fecha_inicio ,Fecha_Final,Ciudad,Estado,Docente)  values('" + txt_codigo_env.Text +
                         "','" + txt_evento.Text +
                         "','" + conbmodalidad +
                         "','" + txt_carfa_horaria.Text +
                         "','" + txt_fecha_inicio.Text +
                         "','" + txt_fecha_final.Text +
                         "','" + txt_ciudad.Text +
                         "','" + conbestado +
                         "','" + txt_docente.Text + "');";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro de evento agregado a la Base de Datos");
                        actualizar_tabla();
                        limpiar_campos();
                        conexion.Close();
                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE UN ESTADO ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA MODALIDAD ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                   //Para Agregar registro en el boton nuevo
               
            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void bot_eliminar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            if (txt_codigo_env.Text != "")
            {
                string consulta = "delete from eventos where Codigo_Evento='" + txt_codigo_env.Text + "';";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El evento  fue eliminado con exito");
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
                MessageBox.Show("DAR EL CODIGO DEL EVENTO QUE DESEA ELIMINAR  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.Close();
            }
        }

        private void bot_editar_Click(object sender, EventArgs e)
        {
            //Para modificar registro en el boton modificar
            conexion.Open();
            if ((txt_codigo_env.Text != "") &&
                (txt_evento.Text != "") &&
                (txt_carfa_horaria.Text != "") &&
                (txt_fecha_final.Text != "") &&
                (txt_fecha_inicio.Text != "") &&
                (txt_ciudad.Text != "") &&
                (txt_docente.Text != ""))
            {
                if (conbmodalidad == "Virtual" || conbmodalidad == "Presencial")
                {
                    if (conbestado == "ACTIVO" || conbestado == "INACTIVO")
                    {
                        string consulta = "UPDATE eventos SET " +
                    "Codigo_Evento ='" + txt_codigo_env.Text +
                    "',Evento ='" + txt_evento.Text +
                    "',Modalidad='" + conbmodalidad +
                    "',Carga_Horaria='" + txt_carfa_horaria.Text +
                    "',Fecha_inicio='" + txt_fecha_inicio.Text +
                    "',Fecha_Final='" + txt_fecha_final.Text +
                    "',Ciudad='" + txt_ciudad.Text +
                    "',Estado='" + conbestado +
                    "',Docente='" + txt_docente.Text +
                      "' where Codigo_Evento='" + txt_codigo_env.Text + "';";

                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        int contador;
                        contador = comando.ExecuteNonQuery();
                        if (contador > 0)
                        {
                            MessageBox.Show("El evento fue modificado en la Base de  Datos");
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
                        MessageBox.Show("SELECCIONE UN ESTADO ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA MODALIDAD ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


               
            }
            else
            {
                MessageBox.Show("FALTAN CAMPOS PARA MODIFICAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        
    }

        private void bot_generar_qr_Click(object sender, EventArgs e)
        {
            contqr = "EVENTO:.." + txt_evento.Text + " MODALIDAD:." + conbmodalidad + " CARGA HORARIA:." + txt_carfa_horaria.Text + " FECHA INICIO:." +
                          txt_fecha_inicio.Text + " FECHA FINAL:." + txt_fecha_final.Text + " CIUDAD:." + txt_ciudad.Text + " ESTADO:." + conbestado + " DOCENTE:." + txt_docente.Text;

            QrEncoder qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEnconder.TryEncode(contqr.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(120, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(120, 120)));
            pictureBox1.BackgroundImage = imagen;
            imagen.Save(txt_evento.Text+".png", ImageFormat.Png);
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            evento_busqueda frmMenu = new evento_busqueda();
            this.Hide();
            frmMenu.Show();
        }

        private void txt_combo_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = txt_combo_modalidad.SelectedIndex;
           conbmodalidad = txt_combo_modalidad.Items[indice].ToString();

                 }

        private void combo_estado_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = txt_combo_modalidad.SelectedIndex;
            conbestado = combo_estado.Items[indice].ToString();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DGV1.CurrentRow.Index;

                 txt_codigo_env.Text = DGV1[0, pos].Value.ToString();
            txt_evento.Text =      DGV1[1, pos].Value.ToString();
            txt_carfa_horaria.Text = DGV1[3, pos].Value.ToString();
            txt_fecha_inicio.Text = DGV1[4, pos].Value.ToString();
            txt_fecha_final.Text = DGV1[5, pos].Value.ToString();
            txt_ciudad.Text = DGV1[6, pos].Value.ToString();
            txt_docente.Text = DGV1[8, pos].Value.ToString();
            
        }

        private void txt_carfa_horaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("DAR DATOS NUMERICOS PARA LA CARGA HORARIA PORFAVOR", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }
    }
}
