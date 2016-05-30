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
    public partial class Form1 : Form
    {
        Service1Client webService;
        string sexo = "teste";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarMedicacao a = new CriarMedicacao();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webService = new Service1Client();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           if (String.IsNullOrEmpty(txtSNS.Text) && String.IsNullOrEmpty(txtPrimeiroNome.Text) && String.IsNullOrEmpty(txtApelido.Text) && String.IsNullOrEmpty(txtCodigoPostal.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Dados em falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);



             
            }else{

                webService.RegistarUtente(int.Parse(txtSNS.Text), txtPrimeiroNome.Text, txtApelido.Text, dateTimePicker1.Value, txtMorada.Text, txtCodigoPostal.Text, txtEmail.Text, sexo, txtTelefone.Text, txtPeso.Text, txtAltura.Text, txtGlicemia.Text, txtTensao.Text, txtColestrol.Text, txtSaturacao.Text, txtBatimento.Text);
                MessageBox.Show("Paciente registado");
                ///This is a test.
               
              
                            //if(String.IsNullOrEmpty(txtPeso.Text)||String.IsNullOrEmpty(txtAltura.Text)||String.IsNullOrEmpty(txtGlicemia.Text)||String.IsNullOrEmpty(txtColestrol.Text)||String.IsNullOrEmpty(txtSaturacao.Text)||String.IsNullOrEmpty(txtBatimento.Text))
                            //{
                            //    DialogResult result = MessageBox.Show("Deseja criar um paciente sem dados clínicos inseridos?", "Confirmation", MessageBoxButtons.YesNo);
                            //    if (result == DialogResult.Yes)
                            //    {
                            //        MessageBox.Show("Paciente registado");
                            //        webService.RegistarUtente(int.Parse(txtSNS.Text), txtPrimeiroNome.Text, txtApelido.Text, dateTimePicker1.Value, txtMorada.Text, txtCodigoPostal.Text, txtEmail.Text, sexo, txtTelefone.Text, txtPeso.Text, txtAltura.Text, txtGlicemia.Text, txtTensao.Text, txtColestrol.Text, txtSaturacao.Text, txtBatimento.Text);
                            //    }
                            //    else if (result == DialogResult.No)
                            //    {

                            //                    if (String.IsNullOrEmpty(txtSNS.Text) || String.IsNullOrEmpty(txtPrimeiroNome.Text) || String.IsNullOrEmpty(txtApelido.Text) || String.IsNullOrEmpty(txtCodigoPostal.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefone.Text))
                            //                    {
                            //                        MessageBox.Show("Dados em falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //                    }


                            //    }


                            //}
                ///</remarks>

            }




        }

        private void txtSNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrimeiroNome_TextChanged(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            CriarExame a = new CriarExame();
            a.Show();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSNS.Clear();
            txtPrimeiroNome.Clear();
            txtApelido.Clear();
            txtMorada.Clear();
            txtCodigoPostal.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            txtGlicemia.Clear();
            txtTensao.Clear();
            txtColestrol.Clear();
            txtSaturacao.Clear();
            txtBatimento.Clear();
        }

        private void txtGlicemia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTensao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtColestrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSaturacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBatimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnImportarMed_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
    }
}
