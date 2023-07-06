using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTROS_ACADEMIA_LIDER
{
    public partial class IMPRESION : Form
    {
        public IMPRESION()
        {
            InitializeComponent();
        }
        

        private void IMPRESION_Load(object sender, EventArgs e)
        {
        
            string contqr = "Codigo Certificado:.." + txt_codigo_certificado.Text + "Nombre :." + txt_nombre_ceertirficado.Text + " Apellido:." + txt_apellido_certificado.Text + " Cedula Identidad:." +
                              txt_ci_certificado.Text + " Evento:." + txt_evento.Text + " Nota:." + txt_nota.Text + " fecha:." + txt_fecha.Text;


            MessageBox.Show(txt_codigo_certificado.Text, "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         


            QrEncoder qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEnconder.TryEncode(contqr.Trim(), out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
                MemoryStream ms = new MemoryStream();
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(150, 150)));
                gr.BackgroundImage = imagen;
                imagen.Save("imagen.png", ImageFormat.Png);
            //cargar foto

            //cargar foto
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(dialogo.FileName);
                ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            imprime();
            cerrar();
        }
        private void imprime()
        {
            MessageBox.Show("se esta imprimiendo el certificado", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }
        private void cerrar()
        {
           
            this.Hide();
            
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
       
            e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
