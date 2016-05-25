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
        UtilizadorWeb utilizador;
        Service1Client webService;
        public FormDadosUtilizador(UtilizadorWeb user)
        {
            webService = new Service1Client();
            InitializeComponent();
            if (user != null)
            {
                label6.Hide();
                checkedListBox1.Hide();
                utilizador = user;
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
                    checkedListBox1.SetSelected(3, true);
                }
                if (user.TipoUtilizador == "Rececionista")
                {
                    checkedListBox1.SetItemChecked(0, true);
                    checkedListBox1.SetSelected(0, true);
                }
                if (user.TipoUtilizador == "Medico")
                {
                    checkedListBox1.SetItemChecked(1, true);
                    checkedListBox1.SetSelected(1, true);
                }
                if (user.TipoUtilizador == "Enfermeiro")
                {
                    checkedListBox1.SetItemChecked(2, true);
                    checkedListBox1.SetSelected(2, true);
                }
            }

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (utilizador == null)
            {
                if (textBoxPassword.Text.Equals(textBoxPassword2.Text))
                {
                    if (verificarCampos())
                    {
                        string nome = textBoxName.Text;
                        int nInterno = int.Parse(textBoxNInterno.Text);
                        string morada = textBoxMorada.Text;
                        DateTime date = monthCalendar1.SelectionRange.Start;
                        string cargo = textBoxCargo.Text;
                        string pass = textBoxPassword.Text;
                        string tipoUtilizador = checkedListBox1.SelectedItem.ToString();
                        if (webService.adicionarUtilizador(nome, nInterno, morada, date, cargo, pass, tipoUtilizador))
                        {
                            MessageBox.Show("Utilizador criado com sucesso!");
                        }
                        else { MessageBox.Show("Ocorreu um erro!"); }
                    }
                    else
                    {
                        MessageBox.Show("Preenche todos os campos!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifica as passwords!");
                }
            }
            else
            {
                if (textBoxPassword.Text.Equals(textBoxPassword2.Text))
                {
                    if (verificarCampos())
                    {
                        string nome = textBoxName.Text;
                        int nInterno = int.Parse(textBoxNInterno.Text);
                        string morada = textBoxMorada.Text;
                        DateTime date = monthCalendar1.SelectionRange.Start;
                        string cargo = textBoxCargo.Text;
                        string pass = textBoxPassword.Text;

                        string tipoUtilizador = utilizador.TipoUtilizador;
                        if(verificaralteracoes()){
                            
                        if (webService.alterarUtilizador(nome, nInterno, morada, date, cargo, pass, tipoUtilizador, utilizador.ID))
                        {
                            MessageBox.Show("Utilizador alterado com sucesso!");
                        }
                        else { MessageBox.Show("Ocorreu um erro!"); }
                   
                        }else{MessageBox.Show("Não foram alterado dados nos campos");}
                    }
                    else
                    {
                        MessageBox.Show("Preenche todos os campos!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifica as passwords!");
                }
             }
        }
        public bool verificarCampos()
        {
            if (
            textBoxCargo.Text != "" && textBoxMorada.Text != "" && textBoxName.Text != "" && textBoxNInterno.Text != "" &&
                textBoxPassword.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verificaralteracoes()
        {
            string nome = textBoxName.Text;
            int nInterno = int.Parse(textBoxNInterno.Text);
            string morada = textBoxMorada.Text;
            DateTime date = monthCalendar1.SelectionRange.Start;
            string cargo = textBoxCargo.Text;
            string pass = textBoxPassword.Text;
            string tipoUtilizador = checkedListBox1.SelectedItem.ToString();
            if (
            nome.Equals(utilizador.Nome) && morada.Equals(utilizador.Morada) && nInterno==utilizador.NInterno
            && date==utilizador.DataNascimento && cargo.Equals(utilizador.Cargo) && pass.Equals(utilizador.Password) &&
                tipoUtilizador.Equals(utilizador.TipoUtilizador))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
