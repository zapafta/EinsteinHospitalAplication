using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference;

namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        Service1Client webservice;
        public FormLogin()
        {
            InitializeComponent();
            webservice = new Service1Client();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (username != "" || password != "")
            {
                UtilizadorWeb user = webservice.validarLogin(username, password);
                if (user != null) { 
                    
                    if (user.TipoUtilizador == "Administrador")
                    {

                        FormPaginaInicialAdministrador df = new FormPaginaInicialAdministrador( user);

                        df.Show();
                        this.Hide();
                        
                    }

                    else if (user.TipoUtilizador == "Medico")
                    {

                        FormRegistarConsulta df = new FormRegistarConsulta(user);

                        df.Show();
                        this.Hide();
                        
                    }

                    else if (user.TipoUtilizador == "Rececionista")
                    {

                        Form1 df = new Form1(user);

                        df.Show();
                        this.Hide();

                    }
                    else 
                    {
                        PesquisaPaciente df = new PesquisaPaciente();

                        df.Show();
                        this.Hide();

                    }
                }                     
                   
                else
                {
                    MessageBox.Show("Dados incorretos!");
                }
            }
            else
            {
                MessageBox.Show("Campos não estão preenchidos");
            }
        }
        private void Foo(object sender, EventArgs e)
        {
            Program.OpenDetailFormOnClose = true;

            this.Close();
        }
    }
}
