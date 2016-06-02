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
    public partial class FormHistoricoConsultas : Form
    {
        Service1Client webservice;
        List<ConsultaWeb> lista = new List<ConsultaWeb>();
        public FormHistoricoConsultas(UtenteWeb utente)
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            webservice = new Service1Client();
            textBox1.Text = "Nome: " + utente.PrimeiroNome + " " + utente.Apelido + "  Idade: " + (DateTime.Today.Year - utente.DataNascimento.Year).ToString() + " anos" + "  Morada: " + utente.Morada + "  Sexo: " + utente.Sexo + "  Sns: " + utente.SnsId.ToString();
            lista = webservice.procurarConsultas(utente).ToList();
            foreach (ConsultaWeb cWeb in lista)
            {
                 ListViewItem linha = new ListViewItem(new[] { cWeb.Id.ToString(), cWeb.Data.ToString(), cWeb.Medico });
                 listView1.Items.Add(linha);
            }
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            if (listView1.SelectedIndices.Count == 1)
            {
        
            int selecionado = listView1.SelectedIndices[0];
            if (selecionado >= 0)
            {
                List<SintomaWeb> listaSintomas = webservice.procurarSintomasConsulta(lista[selecionado].Id).ToList();
                foreach (SintomaWeb sWeb in listaSintomas)
                {
                    ListViewItem linha = new ListViewItem(new[] { sWeb.Descricao });
                    listView2.Items.Add(linha);
                }

                List<DiagnosticoWeb> listaDiagnosticos = webservice.procurarDiagnosticosConsulta(lista[selecionado].Id).ToList();
                foreach (DiagnosticoWeb dWeb in listaDiagnosticos)
                {
                    ListViewItem linha = new ListViewItem(new[] { dWeb.Descricao });
                    listView3.Items.Add(linha);
                }
                List<MedicacaoWeb> listaMedicacoes = webservice.procurarMedicacoesConsulta(lista[selecionado].Id).ToList();
                foreach (MedicacaoWeb mWeb in listaMedicacoes)
                {
                    ListViewItem linha = new ListViewItem(new[] { mWeb.NomeMedicamento });
                    listView4.Items.Add(linha);
                }
            }
            }
        }
    }
}
