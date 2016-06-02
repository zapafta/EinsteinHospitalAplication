using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference;

namespace WindowsFormsApplication1
{
    public partial class PesquisaPaciente : Form
    {
        Service1Client webservice;
        List<UtenteWeb> utentes = new List<UtenteWeb>();
        public PesquisaPaciente()
        {
            InitializeComponent();
            webservice = new Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            utentes = new List<UtenteWeb>();
            try
            {
                utentes = webservice.PesquisaPaciente(int.Parse(textID.Text), textBoxPrimeiroNome.Text, textBoxApelido.Text).ToList();
            }
            catch
            {
                int teste = 0;
                utentes = webservice.PesquisaPaciente(teste, textBoxPrimeiroNome.Text, textBoxApelido.Text).ToList();
            }
            foreach (UtenteWeb u in utentes)
            {
                string row = u.PrimeiroNome + " " + u.Apelido;
                listBox1.Items.Add(row);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            UtenteWeb utente = utentes.ElementAt(index);
            textBoxApelido.Text = utente.Apelido;
            textBoxCodigoPostal.Text = utente.CodigoPostal;
            textBoxEmail.Text = utente.Email;
            textBoxMorada.Text = utente.Morada;
            textBoxPrimeiroNome.Text = utente.PrimeiroNome;
            textID.Text = utente.SnsId.ToString();
            textBoxContacto.Text = utente.Contacto;
            if (utente.Sexo == "Masculino")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            monthCalendar1.SelectionStart = utente.DataNascimento;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxApelido.Text = "";
            textBoxCodigoPostal.Text = "";
            textBoxEmail.Text = "";
            textBoxMorada.Text = "";
            textBoxPrimeiroNome.Text = "";
            textID.Text = "";
            textBoxContacto.Text = "";
            monthCalendar1.SelectionStart = DateTime.Now;
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string apelido = textBoxApelido.Text;
            string codigo = textBoxCodigoPostal.Text;
            string email = textBoxEmail.Text;
            string morada = textBoxMorada.Text;
            string primeiroNome = textBoxPrimeiroNome.Text;
            string contato = textBoxContacto.Text;
            DateTime data = monthCalendar1.SelectionStart;
            if (apelido != "" && codigo != "" && email != "" && morada != "" && primeiroNome != "" && textID.Text != "" && contato != "")
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    string value = "";
                    bool isChecked = radioButton1.Checked;
                    if (isChecked)
                        value = radioButton1.Text;
                    else
                        value = radioButton2.Text;

                    int snsid = int.Parse(textID.Text);
                    if (webservice.RegistarUtenteDadosNãoClinicos(snsid, primeiroNome, apelido, data, morada, codigo, email, "Masculino", contato) != -1)
                    {
                        MessageBox.Show("Paciente criado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o email!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string apelido = textBoxApelido.Text;
            string codigo = textBoxCodigoPostal.Text;
            string email = textBoxEmail.Text;
            string morada = textBoxMorada.Text;
            string primeiroNome = textBoxPrimeiroNome.Text;
            string contato = textBoxContacto.Text;
            DateTime data = monthCalendar1.SelectionStart;
            UtenteWeb u = utentes.ElementAt(listBox1.SelectedIndex);
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;

            if (apelido != u.Apelido || codigo != u.CodigoPostal || email != u.Email || morada != u.Morada || primeiroNome != u.PrimeiroNome || textID.Text != u.SnsId.ToString() || contato != u.Contacto || u.Sexo != value)
            {
                if (webservice.AlterarPaciente(u.SnsId, primeiroNome, apelido, data, morada, codigo, email, value, contato))
                {
                    MessageBox.Show("Dados foram alterados!");

                }
                else
                {
                    MessageBox.Show("Dados não foram alterados!");
                }
            }
        }
    }
}
