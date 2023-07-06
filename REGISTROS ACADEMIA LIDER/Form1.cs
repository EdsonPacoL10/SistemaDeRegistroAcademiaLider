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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        int intentos = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void bot_ingresar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (intentos < 3)
            {

                string consulta = "select * from usuarios where usuario='" + txt_usuario.Text + "' and contraseña='"
                    + txt_contraseña.Text  + "';";
                //consulta sql
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;

                lector = comando.ExecuteReader();
                //validacion de los datos si existen e ingreso al sistema o salida en caso de muchos errores
                if (lector.HasRows == true)
                {
                    //si ingresa los datos correctos entra al sistema
                    MessageBox.Show("BIENVENIDO AL SISTEMA ");
                   

                    Menu_Principal dato = new Menu_Principal();
                        this.Hide();
                   dato.Show();








                }
                else
                {
                    //si ingresa datos errados no entra
                    intentos++;
                    MessageBox.Show("LOS DATOS INGRESADOS SON INCORRECTOS");
                    MessageBox.Show("AL TERCER INTENTO FALLIDO EL SISTEMA SE CERRARA !CUIDADO¡", "NUMERO DE INTENTOS : "
                        + intentos, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexion.Close();
                }

            }
            else
            {
                //momento que alcanzo el limite de intentos
                intentos = 0;
                MessageBox.Show("MAXIMO DE INTENTOS", "Cierre de sistema");
                Close();
            }

          

        }

        private void bot_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR VISITARNOS HASTA LUEGO :-)", "Salida del sistema", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation);
            Close();
        }
    }
}
