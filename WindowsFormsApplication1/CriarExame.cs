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
    public partial class CriarExame : Form
    {
        Service1Client webService;
        UtilizadorWeb utilizador;
         int indexUtente;
         int indexMedico;

        string espe;
        List<UtenteWeb> utentes;
        List<UtilizadorWeb> medicos;

        public CriarExame(UtilizadorWeb user)
        {
            InitializeComponent();
            utilizador = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Dados em falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else
            {



                espe = comboEspecialidade.SelectedItem.ToString();
                indexUtente = comboUtente.SelectedIndex;
                indexMedico = comboMedico.SelectedIndex;


              UtenteWeb ut=  utentes.ElementAt(indexUtente);
              UtilizadorWeb user = medicos.ElementAt(indexMedico);



              webService.RegistarExame(espe, txtPreco.Text, dateTimePicker1.Value, utilizador, ut, user);
                    

            }

        }

        private void comboEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CriarExame_Load(object sender, EventArgs e)
        {
            webService = new Service1Client();
            label7.Text = utilizador.Nome;
            List<UtenteWeb> recemChegada = webService.GetAllUtente().ToList();

            List<UtilizadorWeb> recemChegadamed = webService.GetAllMedicos().ToList();


            utentes = new List<UtenteWeb>();
            medicos = new List<UtilizadorWeb>();


            foreach (UtenteWeb u in recemChegada)
            {
                comboUtente.Items.Add(u.PrimeiroNome+" "+u.Apelido);
                utentes.Add(u);
            }

            foreach (UtilizadorWeb m in recemChegadamed)
            {
                comboMedico.Items.Add(m.Nome);
               medicos.Add(m);
            }

    

        }
    }
}
