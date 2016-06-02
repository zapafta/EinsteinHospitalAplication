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
    public partial class FormHistoricoMedicacoes : Form
    {
        UtenteWeb utente;
        Service1Client webservice;
        public FormHistoricoMedicacoes()
        {
            InitializeComponent();
              webservice = new Service1Client();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
             if (!txtSearch.Text.Equals(""))
            {
                utente = webservice.procurarUtente(int.Parse(txtSearch.Text));
                if(utente==null)
                {
                    MessageBox.Show("Sem resultados!");
                }
                else
                {
                    textBox4.Text = "Nome: " + utente.PrimeiroNome + " " + utente.Apelido + "  Idade: " + (DateTime.Today.Year - utente.DataNascimento.Year).ToString() + " anos" + "  Morada: " + utente.Morada + "  Sexo: " + utente.Sexo + "  Sns: " + utente.SnsId.ToString();
                    List<MedicacaoWeb> listaMedicacoes = webservice.procurarMedicacaoHistorico(utente.SnsId).ToList();
                    foreach (MedicacaoWeb mWeb in listaMedicacoes)
                    {
                        ListViewItem linha = new ListViewItem(new[] { mWeb.Id.ToString(), mWeb.NomeMedicamento, mWeb.Dosagem, mWeb.Data.ToString(), mWeb.Administracao, mWeb.Comparticao });
                        listView1.Items.Add(linha);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o número de utente!");
            }
        
        }
    }
}
