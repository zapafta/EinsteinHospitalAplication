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
    public partial class FormPesquisaUtilizador : Form
    {
        Service1Client webService;
        List<UtilizadorWeb> users;
        public FormPesquisaUtilizador()
        {
            InitializeComponent();
            webService = new Service1Client();
            atualizarTabela();
        }

        private void atualizarTabela()
        {
            users = webService.procurarUtilizadores("").ToList();
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Tipo de Utilizador";
            dataGridView1.Columns[2].Name = "Cargo";
            dataGridView1.Columns[3].Name = "Suspensão";

            foreach (UtilizadorWeb u in users)
            {
                if (u.Suspensao == true)
                {
                    string[] row = new string[] { u.Nome, u.TipoUtilizador, u.Cargo, "Ativo" };
                    dataGridView1.Rows.Add(row);
                }
                else
                {
                    string[] row = new string[] { u.Nome, u.TipoUtilizador, u.Cargo, "Inativo" };
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
           
           users =  webService.procurarUtilizadores(textBoxProcurar.Text).ToList();
           dataGridView1.Rows.Clear();
           dataGridView1.ColumnCount = 4;
           dataGridView1.Columns[0].Name = "Nome";
           dataGridView1.Columns[1].Name = "Tipo de Utilizador";
           dataGridView1.Columns[2].Name = "Cargo";
           dataGridView1.Columns[3].Name = "Suspensão";

           foreach (UtilizadorWeb u in users)
           {
               if (u.Suspensao == true) { 
                    string[] row = new string[] { u.Nome, u.TipoUtilizador, u.Cargo, "Ativo" };
                    dataGridView1.Rows.Add(row);
               }
               else
               {
                   string[] row = new string[] { u.Nome, u.TipoUtilizador, u.Cargo, "Inativo" };
                   dataGridView1.Rows.Add(row);
               }
           }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            UtilizadorWeb user = users.ElementAt(index);
            FormDadosUtilizador df = new FormDadosUtilizador(user);
            df.ShowDialog();
        }

        private void buttonSuspensao_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            UtilizadorWeb user = users.ElementAt(index);
           bool result = webService.alterarSuspensao(user.ID);
           if (result)
           {
               MessageBox.Show("Suspensão do utilizador " + user.Nome + " foi alterada!");
               atualizarTabela();
           }
           else
           {
               MessageBox.Show("Ocorreu um erro!");
           }
        }
    }
}
