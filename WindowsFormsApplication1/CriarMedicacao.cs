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


    public partial class CriarMedicacao : Form
    {
        Service1Client webService;
        string comparticipacao = null;


        public CriarMedicacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(txtMedicamento.Text) && String.IsNullOrEmpty(txtPreco.Text) || String.IsNullOrEmpty(txtDos.Text))
            {
                MessageBox.Show("Dados em falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else
            {
                if (rb100.Checked == true)
                {
                    comparticipacao = "100%";
                
                }
                if(radB50.Checked == true)
                {

                    comparticipacao = "50 %";
                }else{

                    comparticipacao = "0%";
                }
                int a = webService.RegistarMedicacao(txtMedicamento.Text, comboMedico.SelectedItem.ToString(), txtPreco.Text, dateTimePicker1.Value, txtDos.Text, comparticipacao);

                string combo = comboMedico.SelectedItem.ToString();


                if (a == -1)
                {

                    MessageBox.Show("Erro ao inserir o novo medicamento");
                }
                else { MessageBox.Show("Medicação criada com sucesso"); }

               
            
            }
           
        }

        private void CriarMedicacao_Load(object sender, EventArgs e)
        {
            webService = new Service1Client();




        }
    }
}
