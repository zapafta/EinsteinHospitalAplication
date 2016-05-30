using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Parte Zé

        [OperationContract]
        UtilizadorWeb validarLogin(string username, string password);

        [OperationContract]
        List<UtilizadorWeb> procurarUtilizadores(string campoPesquisa);

        [OperationContract]
        bool alterarSuspensao(int id);

        [OperationContract]
        bool adicionarUtilizador(string nome, int nInterno, string morada, DateTime dataNascimento, string cargo, string password, string tipoUtilizador);

        [OperationContract]
        bool alterarUtilizador(string nome, int nInterno, string morada, DateTime dataNascimento, string cargo, string password, string tipoUtilizador, int id);
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Parte Diogo
        [OperationContract]
        UtenteWeb procurarUtente(int snsId);

        [OperationContract]
        List<SintomaWeb> procurarSintomas(string campoPesquisa);

        [OperationContract]
        List<DiagnosticoWeb> procurarDiagnosticos(string campoPesquisa);

        [OperationContract]
        List<MedicacaoWeb> procurarMedicacoes(string campoPesquisa);
        
        [OperationContract]
        bool adicionarConsulta(DateTime data, UtenteWeb utente, MedicoWeb medico, List<SintomaWeb> listaSintomas, List<DiagnosticoWeb> listaDiagnosticos, List<MedicacaoWeb> listaMedicacao);
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class UtilizadorWeb
    {
        string username;
        string password;
        string tipoUtilizador;
        string nome;
        int nInterno;
        int id;
        string morada;
        DateTime dataNascimento;
        string cargo;
        bool suspensao;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public bool Suspensao
        {
            get { return suspensao; }
            set { suspensao = value; }
        }


        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string TipoUtilizador
        {
            get { return tipoUtilizador; }
            set { tipoUtilizador = value; }
        }
        [DataMember]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        [DataMember]
        public int NInterno
        {
            get { return nInterno; }
            set { nInterno = value; }
        }
        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        [DataMember]
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        [DataMember]
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
    }

    [DataContract]
    public class UtenteWeb
    {
        int id;
        string primeiroNome;
        string apelido;
        DateTime dataNascimento;
        string morada;
        string codigoPostal;
        string email;
        string sexo;
        string contacto;
        string peso;
        string altura;
        string glicemia;
        string tensao;
        string colestrol;
        string saturacao;
        string batimentoCardiaco;
        int snsId;


        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        [DataMember]
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        [DataMember]
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        [DataMember]
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        [DataMember]
        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        [DataMember]
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        [DataMember]
        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        [DataMember]
        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        [DataMember]
        public string Glicemia
        {
            get { return glicemia; }
            set { glicemia = value; }
        }

        [DataMember]
        public string Tensao
        {
            get { return tensao; }
            set { tensao = value; }
        }

        [DataMember]
        public string Colestrol
        {
            get { return colestrol; }
            set { colestrol = value; }
        }

        [DataMember]
        public string Saturacao
        {
            get { return saturacao; }
            set { saturacao = value; }
        }

        [DataMember]
        public string BatimentoCardiaco
        {
            get { return batimentoCardiaco; }
            set { batimentoCardiaco = value; }
        }


        [DataMember]
        public int SnsId
        {
            get { return snsId; }
            set { snsId = value; }
        }
    }

    [DataContract]
    public class SintomaWeb
    {
        int id;
        string descricao;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }

    [DataContract]
    public class DiagnosticoWeb
    {
        int id;
        string descricao;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
    [DataContract]
    public class MedicacaoWeb
    {
        int id;
        string nomeMedicacao;
        string administracao;
        string preco;
        DateTime data;
        string dosagem;
        string comparticao;


        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string NomeMedicamento
        {
            get { return nomeMedicacao; }
            set { nomeMedicacao = value; }
        }

        [DataMember]
        public string Administracao
        {
            get { return administracao; }
            set { administracao = value; }
        }

        [DataMember]
        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        [DataMember]
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        [DataMember]
        public string Dosagem
        {
            get { return dosagem; }
            set { dosagem = value; }
        }

        [DataMember]
        public string Comparticao
        {
            get { return comparticao; }
            set { comparticao = value; }
        }
    }

    [DataContract]
    public class ConsultaWeb
    {
        int id;
        DateTime data;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
    }

     [DataContract]
    public class MedicoWeb
    {
        int id;
        string nome;
        int idInterno;
        string morada;
        DateTime dataNascimento;
        string cargo;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

         
        [DataMember]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

         
        [DataMember]
        public int IdInterno
        {
            get { return idInterno; }
            set { idInterno = value; }
        }

         
        [DataMember]
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

            
        [DataMember]
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
    }
}
