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
    }

}
