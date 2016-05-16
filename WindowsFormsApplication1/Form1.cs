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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           if (String.IsNullOrEmpty(txtSNS.Text) && String.IsNullOrEmpty(txtPrimeiroNome.Text) && String.IsNullOrEmpty(txtApelido.Text) && String.IsNullOrEmpty(txtCodigoPostal.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Dados em falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();



             
            }else{

                Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
                if (!phoneNumpattern.IsMatch(txtTelefone.Text))
                {
                    MessageBox.Show("Numero de Telefone Invalido");
                }
                            if(String.IsNullOrEmpty(txtPeso.Text)||String.IsNullOrEmpty(txtAltura.Text)||String.IsNullOrEmpty(txtGlicemia.Text)||String.IsNullOrEmpty(txtColestrol.Text)||String.IsNullOrEmpty(txtSaturacao.Text)||String.IsNullOrEmpty(txtBatimento.Text))
                            {
                                DialogResult result = MessageBox.Show("Deseja criar um paciente sem dados clínicos inseridos?", "Confirmation", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    MessageBox.Show("Paciente registado");
                                }
                                else if (result == DialogResult.No)
                                {

                                                if (String.IsNullOrEmpty(txtSNS.Text) || String.IsNullOrEmpty(txtPrimeiroNome.Text) || String.IsNullOrEmpty(txtApelido.Text) || String.IsNullOrEmpty(txtCodigoPostal.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefone.Text))
                                                {
                                                    MessageBox.Show("Dados em falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                }


                                }
                              

                            }

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
