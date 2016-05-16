using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormRegistarConsulta : Form
    {
        public FormRegistarConsulta()
        {
            InitializeComponent();
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
            tabPage5.Enabled = false;

        }


        private void btnSeguinte_Click_1(object sender, EventArgs e)
        {
             int i = tabControl1.SelectedIndex;
                tabControl1.SelectTab(i + 1);
                tabPage2.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectTab(i + 1);
            tabPage3.Enabled = true;
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
    }
}
