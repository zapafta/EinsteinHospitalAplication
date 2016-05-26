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
        int Id;
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
            get { return ID; }
            set { ID = value; }
        }

        [DataMember]
        public string PrimeiroNome
        {
            get { return PrimeiroNome; }
            set { PrimeiroNome = value; }
        }

        [DataMember]
        public string Apelido
        {
            get { return Apelido; }
            set { Apelido = value; }
        }

        [DataMember]
        public DateTime DataNascimento
        {
            get { return DataNascimento; }
            set { DataNascimento = value; }
        }

        [DataMember]
        public string Morada
        {
            get { return Morada; }
            set { Morada = value; }
        }

        [DataMember]
        public string CodigoPostal
        {
            get { return CodigoPostal; }
            set { CodigoPostal = value; }
        }

        [DataMember]
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

        [DataMember]
        public string Sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

        [DataMember]
        public string Contacto
        {
            get { return Contacto; }
            set { Contacto = value; }
        }

        [DataMember]
        public string Peso
        {
            get { return Peso; }
            set { Peso = value; }
        }

        [DataMember]
        public string Altura
        {
            get { return Altura; }
            set { Altura = value; }
        }

        [DataMember]
        public string Glicemia
        {
            get { return Glicemia; }
            set { Glicemia = value; }
        }

        [DataMember]
        public string Tensao
        {
            get { return Tensao; }
            set { Tensao = value; }
        }

        [DataMember]
        public string Colestrol
        {
            get { return Colestrol; }
            set { Colestrol = value; }
        }

        [DataMember]
        public string Saturacao
        {
            get { return Saturacao; }
            set { Saturacao = value; }
        }

        [DataMember]
        public string BatimentoCardiaco
        {
            get { return BatimentoCardiaco; }
            set { BatimentoCardiaco = value; }
        }

        [DataMember]
        public int SnsId
        {
            get { return SnsId; }
            set { SnsId = value; }
        }
    }
}
