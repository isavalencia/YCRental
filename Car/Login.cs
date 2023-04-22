using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void logear(string usuario, string contrasena)
        {
            try
            {
                Conexion.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT nombre, tipo_empleado FROM empleado WHERE usuario = @usuario AND contrasena = @pas", Conexion.Conectar()); ;
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "Empleado")
                    {
                        new Empleados(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.Conectar().Close();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            logear(this.txtUser.Text, this.txtPass.Text);


            /*Conexion.Conectar();
            MessageBox.Show("Conexion realizada con exito");*/
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            //Mandamos img ocultar al frente
            pbOcultar.BringToFront();

            //Mostramos la contraseña
            txtPass.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            //Mandamos img mostrar al frente
            pbMostrar.BringToFront();
            //Oculamos la contraseña
            txtPass.PasswordChar = '*';
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int posY = 0;
        int posX = 0;
        private void panelTituloLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
