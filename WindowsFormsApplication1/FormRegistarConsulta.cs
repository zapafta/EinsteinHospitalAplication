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
    public partial class FormRegistarConsulta : Form
    {
        Service1Client webservice;
        List<SintomaWeb> listaFinalSintomas = new List<SintomaWeb>();
        List<SintomaWeb> listaSintomasEncontradas = new List<SintomaWeb>();
        public FormRegistarConsulta()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listSintomas.FullRowSelect = true;
            listSintomasFinal.FullRowSelect = true;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
            tabPage5.Enabled = false;            
            webservice = new Service1Client();

        }

       
        private void btnSeguinte_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                int i = tabControl1.SelectedIndex;
                                tabControl1.SelectTab(i + 1);
                                tabPage2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Utente em falta!");
            }
             
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listaFinalSintomas.Count > 0)
            {
                int i = tabControl1.SelectedIndex;
                tabControl1.SelectTab(i + 1);
                tabPage3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sintomas em falta!");
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i + 1);
            tabPage4.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i + 1);
            tabPage5.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i - 1);     
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i - 1);     
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i - 1);     
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i - 1);     
        }

        private void cancelar()
        {
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo sair", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            cancelar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo concluir a consulta?", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!txtSearch.Text.Equals(""))
            {
                UtenteWeb utente = webservice.procurarUtente(int.Parse(txtSearch.Text));
                if(utente==null)
                {
                    MessageBox.Show("Sem resultados!");
                }
                else
                {
                    ListViewItem linha = new ListViewItem(new[] { utente.SnsId.ToString(), utente.PrimeiroNome + " " + utente.Apelido, (DateTime.Today.Year - utente.DataNascimento.Year).ToString(), utente.Morada, utente.Sexo, utente.Contacto });
                    listView1.Items.Add(linha);
                }
            }
            else
            {
                MessageBox.Show("Insira o número de utente!");
            }
        }
        
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listSintomas.Items.Clear();
            if (!textBox1.Text.Equals(""))
            {
                listaSintomasEncontradas.Clear();
                listaSintomasEncontradas.AddRange(webservice.procurarSintomas(textBox1.Text));
                if (listaSintomasEncontradas.Count < 1)
                {
                    MessageBox.Show("Sem resultados!");
                }
                else
                {
                    foreach (SintomaWeb s in listaSintomasEncontradas)
                    {
                        ListViewItem linha = new ListViewItem(new[] { s.Id.ToString(), s.Descricao });
                        listSintomas.Items.Add(linha);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Insira o sintoma a pesquisar!");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(listSintomas.SelectedItems.Count>0)
            {
                int selecionado = listSintomas.SelectedIndices[0];
                ListViewItem item = listSintomas.Items[listSintomas.SelectedIndices[0]];
                listSintomas.Items.Remove(item);
                listaFinalSintomas.Add(listaSintomasEncontradas[selecionado]);
                ListViewItem linha = new ListViewItem(new[] { listaSintomasEncontradas[selecionado].Id.ToString(), listaSintomasEncontradas[selecionado].Descricao });
                listaSintomasEncontradas.RemoveAt(selecionado);
                listSintomasFinal.Items.Add(linha);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listSintomasFinal.SelectedItems.Count > 0)
            {
                int selecionado = listSintomasFinal.SelectedIndices[0];
                ListViewItem item = listSintomasFinal.Items[selecionado];
                ListViewItem linha = new ListViewItem(new[] { listaFinalSintomas[selecionado].Id.ToString(), listaFinalSintomas[selecionado].Descricao });
                listaSintomasEncontradas.Add(listaFinalSintomas[selecionado]);
                listSintomasFinal.Items.Remove(item);
                listaFinalSintomas.RemoveAt(selecionado);
                listSintomas.Items.Add(linha);
              
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listSintomasFinal.Items.Clear();
            listaFinalSintomas.Clear();
            listSintomas.Items.Clear();
            listaSintomasEncontradas.Clear();
        }
    }
}
