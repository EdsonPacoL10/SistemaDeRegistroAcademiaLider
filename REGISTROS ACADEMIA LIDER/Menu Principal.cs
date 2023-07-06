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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");

        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from eventos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            Ingreso frmingreso = new Ingreso();
            this.Hide();
            frmingreso.Show();
        }

        private void bot_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR VISITARNOS HASTA LUEGO :-)", "Salida del sistema", MessageBoxButtons.OK,
          MessageBoxIcon.Exclamation);
            Close();
        }

        private void bot_docente_Click(object sender, EventArgs e)
        {
            docente frmdocente = new docente();
            this.Hide();
            frmdocente.Show();
        }

        private void bot_evento_Click(object sender, EventArgs e)
        {
            evento frmevento = new evento();
            this.Hide();
            frmevento.Show();
        }

        private void bot_participante_Click(object sender, EventArgs e)
        {
            participante frmparticipante = new participante();
            this.Hide();
            frmparticipante.Show();
        }

        private void bot_cetificado_Click(object sender, EventArgs e)
        {
            Certificacion frmCertificacion = new Certificacion();
            this.Hide();
            frmCertificacion.Show();
        }

        private void bot_usuario_Click(object sender, EventArgs e)
        {
            Usuarios frmusuario = new Usuarios();
            this.Hide();
            frmusuario.Show();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            Menu_busqueda frmbus_certi = new Menu_busqueda();
            this.Hide();
            frmbus_certi.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            actualizar_tabla();

        }
    }
}
