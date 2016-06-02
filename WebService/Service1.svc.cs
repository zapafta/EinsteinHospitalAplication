using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity.Validation;
using System.Diagnostics;


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
            if (user != null)
            { 
            if(user.suspensao==false){
                user = null;
            }
           
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
                utilizadorWeb.ID = rececionista.Id;

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
            catch
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

        public bool adicionarConsulta(DateTime data, UtenteWeb utente, UtilizadorWeb medico, List<SintomaWeb> listaSintomas, List<DiagnosticoWeb> listaDiagnosticos, List<MedicacaoWeb> listaMedicacao)
        {
            try
            {
                EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
                Consulta c = new Consulta();
                c.data = data;
                c.diagnostico = "nao";
                c.Utente = context.UtenteSet.Where(i => i.snsId == utente.SnsId).FirstOrDefault();
                List<Utilizador> utilizadores = context.UtilizadorSet.Where(i => i.tipoUtilizador == "Medico").ToList();
                List<Medico> listaMedicos = utilizadores.Cast<Medico>().ToList();
                c.Medico = listaMedicos.Where(i => i.nInterno == medico.NInterno).FirstOrDefault();
                context.ConsultaSet.Add(c);               

                foreach (SintomaWeb s in listaSintomas)
                {
                    Sintomas sin = new Sintomas();
                    sin = context.SintomasSet.Where(i => i.Id == s.Id).FirstOrDefault();
                    sin.Consulta.Add(c);
                }

                foreach (DiagnosticoWeb d in listaDiagnosticos)
                {
                    Diagnosticos dia = new Diagnosticos();
                    dia = context.DiagnosticosSet.Where(i => i.Id == d.Id).FirstOrDefault();
                    dia.Consulta.Add(c);
                }

                foreach (MedicacaoWeb m in listaMedicacao)
                {
                    Medicacao med = new Medicacao();
                    med = context.MedicacaoSet.Where(i => i.Id == m.Id).FirstOrDefault();
                    med.Consulta.Add(c);
                }
                context.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }
            return true;

        }

          public  List<ConsultaWeb> procurarConsultas(UtenteWeb utente)
        {

            List<ConsultaWeb> listaFinal = new List<ConsultaWeb>();
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            List<Consulta> consultas = context.ConsultaSet.Where(i => i.Utente.snsId == (utente.SnsId)).ToList();
            foreach (Consulta c in consultas)
            {
                ConsultaWeb cweb = new ConsultaWeb();
                cweb.Id = c.Id;
                cweb.Data = c.data;
                cweb.Medico = c.Medico.nome;
                listaFinal.Add(cweb);
            }
           
            return listaFinal;
        }

          public List<SintomaWeb> procurarSintomasConsulta(int idConsulta)
          {
              List<SintomaWeb> listaFinal = new List<SintomaWeb>();
              EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
              Consulta consulta = context.ConsultaSet.Where(i => i.Id == idConsulta).FirstOrDefault();
              List<Sintomas> sintomas = consulta.Sintomas.ToList();
              foreach (Sintomas s in sintomas)
              {
                  SintomaWeb sweb = new SintomaWeb();
                  sweb.Id = s.Id;
                  sweb.Descricao = s.descricao;
                  listaFinal.Add(sweb);
              }
              return listaFinal;
          }

          public List<DiagnosticoWeb> procurarDiagnosticosConsulta(int idConsulta)
          {
              List<DiagnosticoWeb> listaFinal = new List<DiagnosticoWeb>();
              EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
              Consulta consulta = context.ConsultaSet.Where(i => i.Id == idConsulta).FirstOrDefault();
              List<Diagnosticos> diagnosticos = consulta.Diagnosticos.ToList();
              foreach (Diagnosticos d in diagnosticos)
              {
                  DiagnosticoWeb dweb = new DiagnosticoWeb();
                  dweb.Id = d.Id;
                  dweb.Descricao = d.descricao;
                  listaFinal.Add(dweb);
              }
              return listaFinal;
          }

          public List<MedicacaoWeb> procurarMedicacoesConsulta(int idConsulta)
          {
              List<MedicacaoWeb> listaFinal = new List<MedicacaoWeb>();
              EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
              Consulta consulta = context.ConsultaSet.Where(i => i.Id == idConsulta).FirstOrDefault();
              List<Medicacao> medicacoes = consulta.Medicacao.ToList();
              foreach (Medicacao m in medicacoes)
              {
                  MedicacaoWeb mweb = new MedicacaoWeb();
                  mweb.Id = m.Id;
                  mweb.NomeMedicamento = m.nomeMedicacao;
                  listaFinal.Add(mweb);
              }
              return listaFinal;
          }

          public List<MedicacaoWeb> procurarMedicacaoHistorico(int snsId)
          {
              List<MedicacaoWeb> listaFinal = new List<MedicacaoWeb>();
              EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
              List<Consulta> consultas = context.ConsultaSet.Where(i => i.Utente.snsId == snsId).ToList();
              foreach (Consulta c in consultas)
              {
              List<Medicacao> medicacoes = c.Medicacao.ToList();
              foreach (Medicacao m in medicacoes)
              {
                  MedicacaoWeb mweb = new MedicacaoWeb();
                  mweb.Id = m.Id;
                  mweb.NomeMedicamento = m.nomeMedicacao;
                  listaFinal.Add(mweb);
              }
              }
              
              return listaFinal;
          }

        /////////Parte Pinto da Costa/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public int RegistarUtenteDadosNãoClinicos(int sns, string PrimeiroNome, string apelido, DateTime dataNascimento, string morada, string codigoPostal, string email, string sexo, string contacto)
        {


            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            Utente utentebd = new Utente();
            utentebd.snsId = sns;
            utentebd.primeiroNome = PrimeiroNome;
            utentebd.apelido = apelido;
            utentebd.dataNascimento = dataNascimento;
            utentebd.morada = morada;
            utentebd.codigoPostal = codigoPostal;
            utentebd.email = email;
            utentebd.sexo = sexo;
            utentebd.contacto = contacto;

            context.UtenteSet.Add(utentebd);
            context.SaveChanges();
            int utenteid = utentebd.Id;
            if (utenteid != null)
            {
                return utenteid;
            }
            else
            {
                return -1;

            }
        }

             public int RegistarMedicacao(string nome, string administracao, string preco, DateTime data, string dosagem, string comparticipacao)
        {

            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            Medicacao medicacaobd = new Medicacao();

            medicacaobd.nomeMedicacao = nome;
            medicacaobd.administracao = administracao;
            medicacaobd.preco = preco;
            medicacaobd.dosagem = dosagem;
            medicacaobd.data = data;
            medicacaobd.comparticao = comparticipacao;


            context.MedicacaoSet.Add(medicacaobd);
            context.SaveChanges();
            int medicacoid = medicacaobd.Id;
            if (medicacoid != null)
            {
                return medicacoid;
            }
            else
            {
                return -1;

            }



        }




             public int RegistarExame(string especializacao, string preco, DateTime data, UtilizadorWeb rececionista, UtenteWeb utente, UtilizadorWeb medico)
       {

           EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
           Exame examebd = new Exame();

           examebd.especialidade = especializacao;
           examebd.preco = preco;
           examebd.data = data;
           Rececionista rec =(Rececionista) context.UtilizadorSet.Where(i => i.Id == rececionista.ID).FirstOrDefault();

           examebd.Rececionista = rec;
           Utente ut = (Utente) context.UtenteSet.Where(i => i.Id == utente.ID).FirstOrDefault();
           examebd.Utente = ut;

           Medico med = (Medico)context.UtilizadorSet.Where(i => i.Id == medico.ID).FirstOrDefault();

           examebd.Medico = med;

           context.ExameSet.Add(examebd);
           context.SaveChanges();
           int examebdid = examebd.Id;
           if (examebdid != null)
           {
               return examebdid;
           }
           else
           {
               return -1;

           }



       }

      
       public List<UtenteWeb> GetAllUtente()
       {

           EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
          List<Utente> utentebd = new List<Utente>();
          List<UtenteWeb> listaweb = new List<UtenteWeb>();
          utentebd = context.UtenteSet.ToList();
      

           foreach (Utente u in utentebd)
           {
                  UtenteWeb uWeb = new UtenteWeb();
               uWeb.ID = u.Id;
               uWeb.PrimeiroNome = u.primeiroNome;
               uWeb.Apelido = u.apelido;
               uWeb.DataNascimento = u.dataNascimento;
               uWeb.Morada = u.morada;
               uWeb.CodigoPostal = u.codigoPostal;
               uWeb.Email = u.email;
               uWeb.Sexo = u.sexo;
               uWeb.Contacto = u.contacto;
               uWeb.Peso = u.peso;
               uWeb.Altura = u.altura;
               uWeb.Glicemia = u.glicemia;
               uWeb.Tensao = u.tensao;
               uWeb.Colestrol = u.colestrol;
               uWeb.Saturacao = u.saturacao;
               uWeb.BatimentoCardiaco = u.batimentoCardiaco;
               uWeb.SnsId = u.snsId;
               listaweb.Add(uWeb);

           }
           
           return listaweb;

       }

       public List<UtilizadorWeb> GetAllMedicos()
       {

          EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
          List<Utilizador> medicobd = new List<Utilizador>();
          List<UtilizadorWeb> listaweb = new List<UtilizadorWeb>();
          medicobd = context.UtilizadorSet.Where(i => i.tipoUtilizador == "Medico").ToList();
      

           foreach (Medico u in medicobd)
           {
               UtilizadorWeb uWeb = new UtilizadorWeb();
               uWeb.Nome = u.nome;
               uWeb.ID = u.Id;
               listaweb.Add(uWeb);

           }

           return listaweb;


       }






        public int RegistarUtente(int sns, string PrimeiroNome, string apelido, DateTime dataNascimento, string morada, string codigoPostal, string email, string sexo, string contacto, string peso, string altura, string glicemia, string tensao, string colestrol, string saturacao, string batimento)
        {


            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            Utente utentebd = new Utente();
            utentebd.snsId = sns;
            utentebd.primeiroNome = PrimeiroNome;
            utentebd.apelido = apelido;
            utentebd.dataNascimento = dataNascimento;
            utentebd.morada = morada;
            utentebd.codigoPostal = codigoPostal;
            utentebd.email = email;
            utentebd.sexo = sexo;
            utentebd.contacto = contacto;
            utentebd.peso = peso;
            utentebd.altura = altura;
            utentebd.glicemia = glicemia;
            utentebd.tensao = tensao;
            utentebd.colestrol = colestrol;
            utentebd.saturacao = saturacao;
            utentebd.batimentoCardiaco = batimento;

            context.UtenteSet.Add(utentebd);
            context.SaveChanges();
            int utenteid = utentebd.Id;
            if (utenteid != null)
            {
                return utenteid;
            }
            else
            {
                return -1;

            }



        }




       
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public List<UtenteWeb> PesquisaPaciente(int sns, string PrimeiroNome, string apelido)
        {
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            List<Utente> utentesBD = new List<Utente>();
            if (sns != 0)
            {
                utentesBD = context.UtenteSet.Where(i => i.snsId == sns && i.primeiroNome.Contains("ze") && i.apelido.Contains("gu")).ToList();
            }
            else
            {
                utentesBD = context.UtenteSet.Where(i => i.primeiroNome.Contains(PrimeiroNome) && i.apelido.Contains(apelido)).ToList();
<<<<<<< HEAD

            }
            List<UtenteWeb> utentesWeb = new List<UtenteWeb>();
            if (utentesBD.Count != 0)
            {
                foreach (Utente u in utentesBD)
                {
                    UtenteWeb uWeb = new UtenteWeb();
                    uWeb.ID = u.Id;
                    uWeb.PrimeiroNome = u.primeiroNome;
                    uWeb.Apelido = u.apelido;
                    uWeb.DataNascimento = u.dataNascimento;
                    uWeb.Morada = u.morada;
                    uWeb.CodigoPostal = u.codigoPostal;
                    uWeb.Email = u.email;
                    uWeb.Sexo = u.sexo;
                    uWeb.Contacto = u.contacto;
                    uWeb.Peso = u.peso;
                    uWeb.Altura = u.altura;
                    uWeb.Glicemia = u.glicemia;
                    uWeb.Tensao = u.tensao;
                    uWeb.Colestrol = u.colestrol;
                    uWeb.Saturacao = u.saturacao;
                    uWeb.BatimentoCardiaco = u.batimentoCardiaco;
                    uWeb.SnsId = u.snsId;
                    utentesWeb.Add(uWeb);


=======

            }
            List<UtenteWeb> utentesWeb = new List<UtenteWeb>();
            if (utentesBD.Count != 0)
            {
                foreach (Utente u in utentesBD)
                {
                    UtenteWeb uWeb = new UtenteWeb();
                    uWeb.ID = u.Id;
                    uWeb.PrimeiroNome = u.primeiroNome;
                    uWeb.Apelido = u.apelido;
                    uWeb.DataNascimento = u.dataNascimento;
                    uWeb.Morada = u.morada;
                    uWeb.CodigoPostal = u.codigoPostal;
                    uWeb.Email = u.email;
                    uWeb.Sexo = u.sexo;
                    uWeb.Contacto = u.contacto;
                    uWeb.Peso = u.peso;
                    uWeb.Altura = u.altura;
                    uWeb.Glicemia = u.glicemia;
                    uWeb.Tensao = u.tensao;
                    uWeb.Colestrol = u.colestrol;
                    uWeb.Saturacao = u.saturacao;
                    uWeb.BatimentoCardiaco = u.batimentoCardiaco;
                    uWeb.SnsId = u.snsId;
                    utentesWeb.Add(uWeb);


>>>>>>> origin/FinalRenato
                }
                return utentesWeb;
            }
            else
            {
                return utentesWeb;
            }
        }
        public bool AlterarPaciente(int sns, string PrimeiroNome, string apelido, DateTime dataNascimento, string morada, string codigoPostal, string email, string sexo, string contacto)
        {
            EinsteinHospitalBDEntities context = new EinsteinHospitalBDEntities();
            Utente utenteBD = context.UtenteSet.Where(i => i.snsId == sns).FirstOrDefault();
            if (utenteBD != null)
            {

                utenteBD.primeiroNome = PrimeiroNome;
                utenteBD.apelido = apelido;
                utenteBD.dataNascimento = dataNascimento;
                utenteBD.morada = morada;
                utenteBD.codigoPostal = codigoPostal;
                utenteBD.email = email;
                utenteBD.sexo = sexo;
                utenteBD.contacto = contacto;
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

}
