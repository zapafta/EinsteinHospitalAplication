using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Parte Zé
        public UtilizadorWeb validarLogin(string username, string password)
        {
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            UtilizadorWeb utilizadorWeb = new UtilizadorWeb();
            Utilizador user = context.UtilizadorSet.Where(i => i.username == username && i.password == password).FirstOrDefault();
            if(user.suspensao==false){
                user = null;
            }
            if (user != null) { 
            utilizadorWeb.Username = user.username;
            utilizadorWeb.Password = user.password;
            utilizadorWeb.TipoUtilizador = user.tipoUtilizador;
            if (user.tipoUtilizador == "Medico")
            {
                Medico medico = (Medico)user;
                utilizadorWeb.Morada = medico.morada;
                utilizadorWeb.Cargo = medico.cargo;
                utilizadorWeb.NInterno = medico.nInterno;
                utilizadorWeb.Nome = medico.nome;
                utilizadorWeb.DataNascimento = medico.dataNascimento;

                
            }
            if (user.tipoUtilizador == "Enfermeiro")
            {
                Enfermeiro emfermeiro = (Enfermeiro)user;
                utilizadorWeb.Morada = emfermeiro.morada;
                utilizadorWeb.Cargo = emfermeiro.cargo;
                utilizadorWeb.NInterno = emfermeiro.nInterno;
                utilizadorWeb.Nome = emfermeiro.nome;
                utilizadorWeb.DataNascimento = emfermeiro.dataNascimento;
           

            }
            if (user.tipoUtilizador == "Rececionista")
            {
                Rececionista rececionista = (Rececionista)user;
                utilizadorWeb.Morada = rececionista.morada;
                utilizadorWeb.Cargo = rececionista.cargo;
                utilizadorWeb.NInterno = rececionista.nInterno;
                utilizadorWeb.Nome = rececionista.nome;
                utilizadorWeb.DataNascimento = rececionista.dataNascimento;

            }
            if (user.tipoUtilizador == "Administrador")
            {
                Administrador administrador = (Administrador)user;
                utilizadorWeb.Morada = administrador.morada;
                utilizadorWeb.Cargo = administrador.cargo;
                utilizadorWeb.NInterno = administrador.nInterno;
                utilizadorWeb.Nome = administrador.nome;
                utilizadorWeb.DataNascimento = administrador.dataNascimento;

            }

            return utilizadorWeb;
            }
            return null;
        }
        public List<UtilizadorWeb> procurarUtilizadores(string campoPesquisa)
        {
            List<UtilizadorWeb> listaUtilizadoresWeb = new List<UtilizadorWeb>();
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            List<Utilizador> utilizadores = context.UtilizadorSet.ToList();
            foreach (Utilizador u in utilizadores)
            {
                if (u.tipoUtilizador == "Administrador")
                {
                    Administrador a = (Administrador)u;
                    if (a.nome == campoPesquisa || a.nInterno.ToString() == campoPesquisa || campoPesquisa == "")
                    {
                        UtilizadorWeb utilizadorWeb = new UtilizadorWeb();
                        utilizadorWeb.Morada = a.morada;
                        utilizadorWeb.Cargo = a.cargo;
                        utilizadorWeb.NInterno = a.nInterno;
                        utilizadorWeb.Nome = a.nome;
                        utilizadorWeb.DataNascimento = a.dataNascimento;
                        utilizadorWeb.Username = u.username;
                        utilizadorWeb.Password = u.password;
                        utilizadorWeb.TipoUtilizador = u.tipoUtilizador;
                        utilizadorWeb.ID = u.Id;
                        utilizadorWeb.Suspensao = u.suspensao;
                        listaUtilizadoresWeb.Add(utilizadorWeb);
                    }
                }
                if (u.tipoUtilizador == "Medico")
                {
                    Medico a = (Medico)u;
                    if (a.nome == campoPesquisa || a.nInterno.ToString() == campoPesquisa || campoPesquisa == "")
                    {
                        UtilizadorWeb utilizadorWeb = new UtilizadorWeb();
                        utilizadorWeb.Morada = a.morada;
                        utilizadorWeb.Cargo = a.cargo;
                        utilizadorWeb.NInterno = a.nInterno;
                        utilizadorWeb.Nome = a.nome;
                        utilizadorWeb.DataNascimento = a.dataNascimento;
                        utilizadorWeb.Username = u.username;
                        utilizadorWeb.Password = u.password;
                        utilizadorWeb.TipoUtilizador = u.tipoUtilizador;
                        utilizadorWeb.ID = u.Id;
                        utilizadorWeb.Suspensao = u.suspensao;
                        listaUtilizadoresWeb.Add(utilizadorWeb);
                    }
                }
                if (u.tipoUtilizador == "Rececionista")
                {
                    Rececionista a = (Rececionista)u;
                    if (a.nome == campoPesquisa || a.nInterno.ToString() == campoPesquisa || campoPesquisa == "")
                    {
                        UtilizadorWeb utilizadorWeb = new UtilizadorWeb();
                        utilizadorWeb.Morada = a.morada;
                        utilizadorWeb.Cargo = a.cargo;
                        utilizadorWeb.NInterno = a.nInterno;
                        utilizadorWeb.Nome = a.nome;
                        utilizadorWeb.DataNascimento = a.dataNascimento;
                        utilizadorWeb.Username = u.username;
                        utilizadorWeb.Password = u.password;
                        utilizadorWeb.TipoUtilizador = u.tipoUtilizador;
                        utilizadorWeb.ID = u.Id;
                        utilizadorWeb.Suspensao = u.suspensao;
                        listaUtilizadoresWeb.Add(utilizadorWeb);
                    }
                }
                if (u.tipoUtilizador == "Enfermeiro")
                {
                    Enfermeiro a = (Enfermeiro)u;
                    if (a.nome == campoPesquisa || a.nInterno.ToString() == campoPesquisa || campoPesquisa == "")
                    {
                        UtilizadorWeb utilizadorWeb = new UtilizadorWeb();
                        utilizadorWeb.Morada = a.morada;
                        utilizadorWeb.Cargo = a.cargo;
                        utilizadorWeb.NInterno = a.nInterno;
                        utilizadorWeb.Nome = a.nome;
                        utilizadorWeb.DataNascimento = a.dataNascimento;
                        utilizadorWeb.Username = u.username;
                        utilizadorWeb.Password = u.password;
                        utilizadorWeb.TipoUtilizador = u.tipoUtilizador;
                        utilizadorWeb.ID = u.Id;
                        utilizadorWeb.Suspensao = u.suspensao;
                        listaUtilizadoresWeb.Add(utilizadorWeb);
                    }
                }
            }
            return listaUtilizadoresWeb;

        }
        public bool alterarSuspensao(int id)
        {
            try { 
                EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
                Utilizador user = context.UtilizadorSet.Where(i => i.Id == id).FirstOrDefault();
                if(user.suspensao == true){
                     user.suspensao = false;
                 }else { user.suspensao = true; }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }




        public bool adicionarUtilizador(string nome, int nInterno, string morada, DateTime dataNascimento, string cargo, string password, string tipoUtilizador)
        {
            try
            {
                EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
                if (tipoUtilizador == "Medico")
                {
                    Medico m = new Medico();
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
                    m.suspensao = true;
                    m.tipoUtilizador = tipoUtilizador;
                    m.username = nInterno.ToString();
                    context.UtilizadorSet.Add(m);
                }
                if (tipoUtilizador == "Enfermeiro")
                {
                    Enfermeiro m = new Enfermeiro();
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
                    m.suspensao = true;
                    m.tipoUtilizador = tipoUtilizador;
                    m.username = nInterno.ToString();
                    context.UtilizadorSet.Add(m);
                }
                if (tipoUtilizador == "Administrador")
                {
                    Administrador m = new Administrador();
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
                    m.suspensao = true;
                    m.tipoUtilizador = tipoUtilizador;
                    m.username = nInterno.ToString();
                    context.UtilizadorSet.Add(m);
                }
                if (tipoUtilizador == "Rececionista")
                {
                    Rececionista m = new Rececionista();
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
                    m.suspensao = true;
                    m.tipoUtilizador = tipoUtilizador;
                    m.username = nInterno.ToString();
                    context.UtilizadorSet.Add(m);
                }

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool alterarUtilizador(string nome, int nInterno, string morada, DateTime dataNascimento, string cargo, string password, string tipoUtilizador, int id)
        {
            try 
            {
                EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
                Utilizador u = context.UtilizadorSet.Where(i => i.Id == id).FirstOrDefault();
                if (tipoUtilizador == "Medico")
                {
                
                    Medico m = (Medico)u; 
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
             
                    m.username = nInterno.ToString();
                    
                }
                if (tipoUtilizador == "Enfermeiro")
                {
          
                    Enfermeiro m = (Enfermeiro)u;
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
    
                    m.username = nInterno.ToString();
                  
                }
                if (tipoUtilizador == "Administrador")
                {
                   
                    Administrador m = (Administrador)u;
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
       
                    m.username = nInterno.ToString();
           
                }
                if (tipoUtilizador == "Rececionista")
                {
                  
                    Rececionista m = (Rececionista)u;
                    m.nome = nome;
                    m.morada = morada;
                    m.cargo = cargo;
                    m.dataNascimento = dataNascimento;
                    m.nInterno = nInterno;
                    m.password = password;
 
                    m.username = nInterno.ToString();
                
                }
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {

                return false;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Parte Diogo
        public UtenteWeb procurarUtente(int snsId)
        {
            UtenteWeb uWeb = new UtenteWeb();
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            Utente ut = context.UtenteSet.Where(i => i.snsId == snsId).FirstOrDefault();
            if(ut!=null)
            {
                uWeb.Altura = ut.altura;
                uWeb.Apelido = ut.apelido;
                uWeb.BatimentoCardiaco = ut.batimentoCardiaco;
                uWeb.CodigoPostal = ut.codigoPostal;
                uWeb.Colestrol = ut.colestrol;
                uWeb.Contacto = ut.contacto;
                uWeb.DataNascimento = ut.dataNascimento;
                uWeb.Email = ut.email;
                uWeb.Glicemia = ut.glicemia;
                uWeb.ID = ut.Id;
                uWeb.Morada = ut.morada;
                uWeb.Peso = ut.peso;
                uWeb.PrimeiroNome = ut.primeiroNome;
                uWeb.Saturacao = ut.saturacao;
                uWeb.Sexo = ut.sexo;
                uWeb.SnsId = ut.snsId;
                uWeb.Tensao = ut.tensao;

                return uWeb;
            }
            else
            {
               return null;
            }          

        }

        public List<SintomaWeb> procurarSintomas(string campoPesquisa)
        {
            List<SintomaWeb> listaSintomaWeb = new List<SintomaWeb>();
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            List<Sintomas> sintomas = context.SintomasSet.Where(i => i.descricao.Contains(campoPesquisa)).ToList();
            foreach (Sintomas s in sintomas)
            {
                SintomaWeb sintomaWeb = new SintomaWeb();
                sintomaWeb.Id = s.Id;
                sintomaWeb.Descricao = s.descricao;
                listaSintomaWeb.Add(sintomaWeb);              
            }
            return listaSintomaWeb;
        }

        public List<DiagnosticoWeb> procurarDiagnosticos(string campoPesquisa)
        {
            List<DiagnosticoWeb> listaDiagnosticoWeb = new List<DiagnosticoWeb>();
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            List<Diagnosticos> diagnosticos = context.DiagnosticosSet.Where(i => i.descricao.Contains(campoPesquisa)).ToList();
            foreach (Diagnosticos d in diagnosticos)
            {
                DiagnosticoWeb diagnosticoWeb = new DiagnosticoWeb();
                diagnosticoWeb.Id = d.Id;
                diagnosticoWeb.Descricao = d.descricao;
                listaDiagnosticoWeb.Add(diagnosticoWeb);
            }
            return listaDiagnosticoWeb;
        }

        public List<MedicacaoWeb> procurarMedicacoes(string campoPesquisa)
        {
            List<MedicacaoWeb> listaMedicacaoWeb = new List<MedicacaoWeb>();
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            List<Medicacao> medicacao = context.MedicacaoSet.Where(i => i.nomeMedicacao.Contains(campoPesquisa)).ToList();
            foreach (Medicacao m in medicacao)
            {
                MedicacaoWeb medicacaoWeb = new MedicacaoWeb();
                medicacaoWeb.Id = m.Id;
                medicacaoWeb.NomeMedicamento = m.nomeMedicacao;
                medicacaoWeb.Preco = m.preco;
                medicacaoWeb.Data = m.data;
                medicacaoWeb.Comparticao = m.comparticao;
                medicacaoWeb.Administracao = m.administracao;
                listaMedicacaoWeb.Add(medicacaoWeb);
            }
            return listaMedicacaoWeb;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

}
