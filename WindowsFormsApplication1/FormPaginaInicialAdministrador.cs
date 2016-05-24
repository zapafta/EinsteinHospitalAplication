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
    public partial class FormPaginaInicialAdministrador : Form
    {
        Service1Client webService;
        public FormPaginaInicialAdministrador(UtilizadorWeb user)
        {
            webService = new Service1Client();
            
            InitializeComponent();
            labelTitle.Text = "Bem Vindo Dr." + user.Nome + " !";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDadosUtilizador df = new FormDadosUtilizador(null);
         
            
            df.ShowDialog();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPesquisaUtilizador df = new FormPesquisaUtilizador();
            df.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

       
       
    }
}
