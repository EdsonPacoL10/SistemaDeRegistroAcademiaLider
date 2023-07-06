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
    public partial class docente : Form
    {
        public docente()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=registro;integrated security=true");
        public void limpiar_campos()
        {
            //para poder limpiar campos
            txt_codigo_docente.Clear();
            txt_ci_docente.Clear();
            txt_nombre_apellido_docente.Clear();
            txt_grado_academico_docen.Clear();
            txt_profesion_docente.Clear();
            txt_cuenta_bancaria.Clear();
            txt_email.Clear();
            txt_celular_docente.Clear();
            txt_ciudad_docente.Clear();
            txt_evento_docente.Clear();
        }
        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from docentes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {

        }

        private void bot_buscar_Click_1(object sender, EventArgs e)
        {
            docente_busqueda frmbusdoce = new docente_busqueda();
            this.Hide();
            frmbusdoce.Show();

        }

        private void docente_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            if (txt_codigo_docente.Text != "")
            {
                string consulta = "delete from docentes where Codigo_Docente='" + txt_codigo_docente.Text+"';";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El docente  fue eliminado con exito");
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
            if ((txt_codigo_docente.Text != "") &&
                 (txt_ci_docente.Text != "") && (txt_nombre_apellido_docente.Text != "") &&
                 (txt_grado_academico_docen.Text != "") && (txt_profesion_docente.Text != "")
                 && (txt_cuenta_bancaria.Text != "") && (txt_email.Text != "")
                 && (txt_celular_docente.Text != "") && (txt_ciudad_docente.Text != "")
                  && (txt_evento_docente.Text != "")   )
                 {

                
                string consulta = "UPDATE docentes SET " +
                    "Codigo_Docente ='" + txt_codigo_docente.Text +
                    "',Cedula_identidad ='" + txt_ci_docente.Text +
                    "',Nombre_Apellido='" + txt_nombre_apellido_docente.Text +
                    "',Grado_Academico='" + txt_grado_academico_docen.Text +
                    "',Profesion='" + txt_profesion_docente.Text +
                    "',Cuenta_Bancaria='" + txt_cuenta_bancaria.Text +
                    "',Email='" + txt_email.Text +
                    "',Celular='" + txt_celular_docente.Text +
                    "',Ciudad='" + txt_ciudad_docente.Text +
                    "',Evento_Capacitador='" + txt_evento_docente.Text +
                    "' where Codigo_Docente='" + txt_codigo_docente.Text + "';";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El docente fue modificado en la Base de  Datos");
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

        private void bot_nuevo_Click(object sender, EventArgs e)
        {
            if ((txt_codigo_docente.Text != "") &&
                 (txt_ci_docente.Text != "") && (txt_nombre_apellido_docente.Text != "") &&
                 (txt_grado_academico_docen.Text != "") && (txt_profesion_docente.Text != "")
                 && (txt_cuenta_bancaria.Text != "") && (txt_email.Text != "")
                 && (txt_celular_docente.Text != "") && (txt_ciudad_docente.Text != "")
                  && (txt_evento_docente.Text != ""))
            {

        

                //Para Agregar registro en el boton nuevo
                conexion.Open();
                string consulta = "insert into docentes (Codigo_Docente,Cedula_identidad,Nombre_Apellido,Grado_Academico,Profesion,Cuenta_Bancaria,Email,Celular,Ciudad,Evento_Capacitador)" +
                 " values('"+ txt_codigo_docente.Text + 
                 "','" + txt_ci_docente.Text + 
                 "','" + txt_nombre_apellido_docente.Text +
                 "','" + txt_grado_academico_docen.Text +
                 "','" + txt_profesion_docente.Text +
                 "','" + txt_cuenta_bancaria.Text +
                 "','" + txt_email.Text +
                 "','" + txt_celular_docente.Text +
                 "','" + txt_ciudad_docente.Text +
                 "','" + txt_evento_docente.Text + "');";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro de docente agregado a la Base de Datos");
                actualizar_tabla();
                limpiar_campos();
                conexion.Close();
            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bot_atras_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DGV1.CurrentRow.Index;

            txt_codigo_docente.Text = DGV1[0, pos].Value.ToString();
            txt_ci_docente.Text = DGV1[1, pos].Value.ToString();
            txt_nombre_apellido_docente.Text = DGV1[2, pos].Value.ToString();
            txt_grado_academico_docen.Text = DGV1[3, pos].Value.ToString();
            txt_profesion_docente.Text = DGV1[4, pos].Value.ToString();
            txt_cuenta_bancaria.Text = DGV1[5, pos].Value.ToString();
            txt_email.Text = DGV1[6, pos].Value.ToString();
            txt_celular_docente.Text = DGV1[7, pos].Value.ToString();
            txt_ciudad_docente.Text = DGV1[8, pos].Value.ToString();
            txt_evento_docente.Text = DGV1[9, pos].Value.ToString(); ;
           
        }
    }
}
