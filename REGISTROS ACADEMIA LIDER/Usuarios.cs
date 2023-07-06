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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        SqlConnection
        conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        string rol = "";
        public void limpiar_campos()
        {
         
            txt_codigo_usuario.Clear();
            txt_nombre_usuario.Clear();
            txt_apellido_usuario.Clear();
            txt_cargo_usuario.Clear();
        

            //para poder limpiar campos


        }

        public void actualizar_tabla()


        {
            //actualizacion de la tabla segun la consulta select
            string consulta = "select * from usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }
        private void bot_atras_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }
     
        private void bot_buscar_Click(object sender, EventArgs e)
        {
            //boton busqueda  y validacion de datos inresados correctamente
            if (txt_busqueda.Text != "")
            {
                if (rt_codigo.Checked == true || rt_cargo.Checked == true )
                {

                    if (rt_codigo.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from usuarios where Codigo='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {

                           
                            txt_codigo_usuario.Text = lector1["Codigo"].ToString();
                            txt_nombre_usuario.Text = lector1["Nombre"].ToString();
                            txt_apellido_usuario.Text = lector1["Apellido"].ToString();
                            txt_cargo_usuario.Text = lector1["Cargo"].ToString();
                            
                          
                           



                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        conexion.Close();

                    }
                    if (rt_cargo.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from usuarios where Cargo='" + txt_busqueda.Text + "';";

                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {

                            txt_codigo_usuario.Text = lector1["Codigo"].ToString();
                            txt_nombre_usuario.Text = lector1["Nombre"].ToString();
                            txt_apellido_usuario.Text = lector1["Apellido"].ToString();
                            txt_cargo_usuario.Text = lector1["Cargo"].ToString();




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

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DGV1.CurrentRow.Index;

            txt_codigo_usuario.Text = DGV1[0, pos].Value.ToString();
            txt_nombre_usuario.Text = DGV1[1, pos].Value.ToString();
            txt_apellido_usuario.Text = DGV1[2, pos].Value.ToString();
            txt_cargo_usuario.Text = DGV1[3, pos].Value.ToString();
          
           
        }

        private void bot_generar_qr_usuario_Click(object sender, EventArgs e)
        {
            string contqr = "Codigo:. "+txt_codigo_usuario.Text + " Nombre:. " + txt_nombre_usuario.Text +" Apellido:. "+ txt_apellido_usuario.Text+" Cargo:. " + txt_cargo_usuario.Text + " Acceso:. "+ rol ;
            QrEncoder qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEnconder.TryEncode(contqr.Trim(), out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(150, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(150, 150)));
            pictureBox1.BackgroundImage = imagen;
            imagen.Save("imagen.png", ImageFormat.Png);
            bot_guardar.Enabled = true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
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

        private void txt_combo_acceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = txt_combo_acceso.SelectedIndex;
            rol = txt_combo_acceso.Items[indice].ToString();
        }

        private void bot_nuevo_Click(object sender, EventArgs e)
        {

            if ((txt_codigo_usuario.Text != "") &&
                (txt_nombre_usuario.Text != "") &&
                (txt_apellido_usuario.Text != "") &&
                (txt_cargo_usuario.Text != "") )
            {
                

                if (rol == "Administrador" || rol == "usuario")
                {
                    if (rol == "Administrador" )
                    {

                        conexion.Open();
                        string consulta = "insert into usuarios (Codigo,Nombre,Apellido,Cargo,Rol ,Usuario,Contraseña)  values('" + txt_codigo_usuario.Text +
                         "','" + txt_nombre_usuario.Text +
                         "','" + txt_apellido_usuario.Text +
                         "','" + txt_cargo_usuario.Text +
                         "',1" + 
                         ",'" + txt_nombre_usuario.Text +"_" + txt_cargo_usuario.Text +
                          "','" + "ADM"+ txt_apellido_usuario.Text +"_"+ txt_codigo_usuario.Text + "');";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro de usuario agregado a la Base de Datos");
                        actualizar_tabla();
                        limpiar_campos();
                        conexion.Close();
                    }
                    
                    if (rol == "usuario")
                    {

                        conexion.Open();
                       
                        string consulta = "insert into usuarios (Codigo,Nombre,Apellido,Cargo,Rol ,Usuario,Contraseña)  values('" + txt_codigo_usuario.Text +
                         "','" + txt_nombre_usuario.Text +
                         "','" + txt_apellido_usuario.Text +
                         "','" + txt_cargo_usuario.Text +
                         "',2" +
                         ",'" + txt_cargo_usuario.Text + "_" + txt_nombre_usuario.Text +
                          "','" + "USU" + txt_cargo_usuario.Text + "_" + txt_codigo_usuario.Text + "');";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro de usuario agregado a la Base de Datos");
                        actualizar_tabla();
                        limpiar_campos();
                        conexion.Close();
                    }
                   

                }
                else
                {
                    MessageBox.Show("SELECCIONE UN ROL ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Para Agregar registro en el boton nuevo

            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bot_editar_Click(object sender, EventArgs e)
        {
            if ((txt_codigo_usuario.Text != "") &&
             (txt_nombre_usuario.Text != "") &&
             (txt_apellido_usuario.Text != "") &&
             (txt_cargo_usuario.Text != ""))
            {
            

                if (rol == "Administrador" || rol == "usuario")
                {
                    if (rol == "Administrador")
                    {


                        conexion.Open();

                        string consulta = "UPDATE usuarios SET " +
                 "Codigo ='" + txt_codigo_usuario.Text +
                 "',Nombre ='" + txt_nombre_usuario.Text +
                 "',Apellido='" + txt_apellido_usuario.Text +
                 "',Cargo='" + txt_cargo_usuario.Text +
                 "',Rol=1" + 
                 ",Usuario='"+ txt_nombre_usuario.Text + "_" + txt_cargo_usuario.Text +
                "',Contraseña='" + "ADM" + txt_apellido_usuario.Text + "_" + txt_codigo_usuario.Text +
                   "' where Codigo='" + txt_codigo_usuario.Text + "';";

                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        int contador;
                        contador = comando.ExecuteNonQuery();
                        if (contador > 0)
                        {
                            MessageBox.Show("El usuario fue modificado en la Base de  Datos");
                        }
                        else
                        {
                            MessageBox.Show("NO PODEMOS MODIFICAR PORQUE EL DATO NO EXISTE");
                        }
                        conexion.Close();
                        actualizar_tabla();
                        limpiar_campos();
                    }

                    if (rol == "usuario")
                    {
                        conexion.Open();
                        string consulta = "UPDATE usuarios SET " +
                               "Codigo ='" + txt_codigo_usuario.Text +
                               "',Nombre ='" + txt_nombre_usuario.Text +
                                 "',Apellido='" + txt_apellido_usuario.Text +
                                "',Cargo='" + txt_cargo_usuario.Text +
                                "',Rol=2" +
                                ",Usuario='" + txt_cargo_usuario.Text + "_" + txt_nombre_usuario.Text+
                                "',Contraseña='" + "USU" + txt_cargo_usuario.Text + "_" + txt_codigo_usuario.Text +
                                "' where Codigo='" + txt_codigo_usuario.Text + "';";

                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro de usuario agregado a la Base de Datos");
                        actualizar_tabla();
                        limpiar_campos();
                        conexion.Close();
                    }


                }
                else
                {
                    MessageBox.Show("SELECCIONE UN ROL ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Para Agregar registro en el boton nuevo

            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bot_eliminar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            if (txt_codigo_usuario.Text != "")
            {
                string consulta = "delete from usuarios where Codigo='" + txt_codigo_usuario.Text + "';";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El usuario  fue eliminado con exito");
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
                MessageBox.Show("DAR EL CODIGO DE USUARIO QUE DESEA ELIMINAR  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
