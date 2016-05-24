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
    public partial class FormDadosUtilizador : Form
    {
        Service1Client webService;
        public FormDadosUtilizador(UtilizadorWeb user)
        {
            webService = new Service1Client();
            InitializeComponent();
            if (user != null)
            {
                textBoxCargo.Text = user.Cargo;
                textBoxMorada.Text = user.Morada;
                textBoxName.Text = user.Nome;
                textBoxNInterno.Text = user.NInterno.ToString();
                textBoxPassword.Text = user.Password;
                textBoxPassword2.Text = user.Password;
                monthCalendar1.SetDate(user.DataNascimento);
                if (user.TipoUtilizador == "Administrador")
                {
                    checkedListBox1.SetItemChecked(3, true);
                }
                if (user.TipoUtilizador == "Rececionista")
                {
                    checkedListBox1.SetItemChecked(0, true);
                }
                if (user.TipoUtilizador == "Medico")
                {
                    checkedListBox1.SetItemChecked(1, true);
                }
                if (user.TipoUtilizador == "Enfermeiro")
                {
                    checkedListBox1.SetItemChecked(2, true);
                }
            }

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
