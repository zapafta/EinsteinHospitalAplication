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
        UtenteWeb utente;
        List<SintomaWeb> listaFinalSintomas = new List<SintomaWeb>();
        List<SintomaWeb> listaSintomasEncontradas = new List<SintomaWeb>();

        List<DiagnosticoWeb> listaFinalDiagnosticos = new List<DiagnosticoWeb>();
        List<DiagnosticoWeb> listaDiagnosticosEncontrados = new List<DiagnosticoWeb>();

        List<MedicacaoWeb> listaFinalMedicacao = new List<MedicacaoWeb>();
        List<MedicacaoWeb> listaMedicacaoEncontrados = new List<MedicacaoWeb>();

        public FormRegistarConsulta()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listSintomas.FullRowSelect = true;
            listSintomasFinal.FullRowSelect = true;
            listView2.FullRowSelect = true;
            listView3.FullRowSelect = true;
            listView4.FullRowSelect = true;
            listView5.FullRowSelect = true;
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
            if (listaFinalDiagnosticos.Count > 0)
            {
                int i = tabControl1.SelectedIndex;
                tabControl1.SelectTab(i + 1);
                tabPage4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Diagnósticos em falta!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (listaFinalMedicacao.Count > 0)
            {
                int i = tabControl1.SelectedIndex;
                tabControl1.SelectTab(i + 1);
                tabPage5.Enabled = true;
                textBox4.Text = utente.PrimeiroNome + " " + utente.Apelido + System.Environment.NewLine + (DateTime.Today.Year - utente.DataNascimento.Year).ToString() + " anos" + System.Environment.NewLine + utente.Morada + System.Environment.NewLine + utente.Sexo;
                textBox5.Text = "Data da consulta: " + DateTime.Now.ToString() + System.Environment.NewLine + "nome do medico" + " ";

                foreach (SintomaWeb s in listaFinalSintomas)
                {
                     ListViewItem linha = new ListViewItem(new[] {s.Descricao});
                     listView6.Items.Add(linha);
                }

                foreach (DiagnosticoWeb d in listaFinalDiagnosticos)
                {
                    ListViewItem linha = new ListViewItem(new[] { d.Descricao });
                    listView7.Items.Add(linha);
                }

                foreach (MedicacaoWeb m in listaFinalMedicacao)
                {
                    ListViewItem linha = new ListViewItem(new[] { m.NomeMedicamento });
                    listView8.Items.Add(linha);
                }
            }
            else

            {
                MessageBox.Show("Medicação em falta!");
            }
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
                MedicoWeb medico = new MedicoWeb();
                medico.IdInterno = 112;
                bool validar = webservice.adicionarConsulta(DateTime.Now, utente, medico, null, null, null);
                if (validar)
                {
                    MessageBox.Show("Com sucesso!");
                }
                else
                {
                    MessageBox.Show("Sem sucesso!");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!txtSearch.Text.Equals(""))
            {
                utente = webservice.procurarUtente(int.Parse(txtSearch.Text));
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

        private void button4_Click(object sender, EventArgs e)
        {
            {
                listView3.Items.Clear();
                if (!textBox2.Text.Equals(""))
                {
                    listaDiagnosticosEncontrados.Clear();
                    listaDiagnosticosEncontrados.AddRange(webservice.procurarDiagnosticos(textBox2.Text));
                    if (listaDiagnosticosEncontrados.Count < 1)
                    {
                        MessageBox.Show("Sem resultados!");
                    }
                    else
                    {
                        foreach (DiagnosticoWeb s in listaDiagnosticosEncontrados)
                        {
                            ListViewItem linha = new ListViewItem(new[] { s.Id.ToString(), s.Descricao });
                            listView3.Items.Add(linha);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Insira o diagnostico a pesquisar!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                int selecionado = listView3.SelectedIndices[0];
                ListViewItem item = listView3.Items[listView3.SelectedIndices[0]];
                listView3.Items.Remove(item);
                listaFinalDiagnosticos.Add(listaDiagnosticosEncontrados[selecionado]);
                ListViewItem linha = new ListViewItem(new[] { listaDiagnosticosEncontrados[selecionado].Id.ToString(), listaDiagnosticosEncontrados[selecionado].Descricao });
                listaDiagnosticosEncontrados.RemoveAt(selecionado);
                listView2.Items.Add(linha);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView2.SelectedItems.Count > 0)
            {
                int selecionado = listView2.SelectedIndices[0];
                ListViewItem item = listView2.Items[selecionado];
                ListViewItem linha = new ListViewItem(new[] { listaFinalDiagnosticos[selecionado].Id.ToString(), listaFinalDiagnosticos[selecionado].Descricao });
                listaDiagnosticosEncontrados.Add(listaFinalDiagnosticos[selecionado]);
                listView2.Items.Remove(item);
                listaFinalDiagnosticos.RemoveAt(selecionado);
                listView3.Items.Add(linha);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listaFinalDiagnosticos.Clear();
            listView3.Items.Clear();
            listaDiagnosticosEncontrados.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                listView5.Items.Clear();
                if (!textBox3.Text.Equals(""))
                {
                    listaMedicacaoEncontrados.Clear();
                    listaMedicacaoEncontrados.AddRange(webservice.procurarMedicacoes(textBox3.Text));
                    if (listaMedicacaoEncontrados.Count < 1)
                    {
                        MessageBox.Show("Sem resultados!");
                    }
                    else
                    {
                        foreach (MedicacaoWeb m in listaMedicacaoEncontrados)
                        {
                            ListViewItem linha = new ListViewItem(new[] { m.Id.ToString(), m.NomeMedicamento, m.Preco, m.Data.ToString(), m.Comparticao, m.Administracao });
                            listView5.Items.Add(linha);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Insira a medicação a pesquisar!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count > 0)
            {
                int selecionado = listView5.SelectedIndices[0];
                ListViewItem item = listView5.Items[listView5.SelectedIndices[0]];
                listView5.Items.Remove(item);
                listaFinalMedicacao.Add(listaMedicacaoEncontrados[selecionado]);
                ListViewItem linha = new ListViewItem(new[] { listaMedicacaoEncontrados[selecionado].Id.ToString(), listaMedicacaoEncontrados[selecionado].NomeMedicamento, listaMedicacaoEncontrados[selecionado].Preco, listaMedicacaoEncontrados[selecionado].Data.ToString(), listaMedicacaoEncontrados[selecionado].Comparticao, listaMedicacaoEncontrados[selecionado].Administracao});
                listaMedicacaoEncontrados.RemoveAt(selecionado);
                listView4.Items.Add(linha);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
            {
                int selecionado = listView4.SelectedIndices[0];
                ListViewItem item = listView4.Items[selecionado];
                ListViewItem linha = new ListViewItem(new[] { listaFinalMedicacao[selecionado].Id.ToString(), listaFinalMedicacao[selecionado].NomeMedicamento, listaFinalMedicacao[selecionado].Preco, listaFinalMedicacao[selecionado].Data.ToString(), listaFinalMedicacao[selecionado].Comparticao, listaFinalMedicacao[selecionado].Administracao });
                listaMedicacaoEncontrados.Add(listaFinalMedicacao[selecionado]);
                listView4.Items.Remove(item);
                listaFinalMedicacao.RemoveAt(selecionado);
                listView5.Items.Add(linha);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            listaFinalMedicacao.Clear();
            listView5.Items.Clear();
            listaMedicacaoEncontrados.Clear();
        }
    }
}
