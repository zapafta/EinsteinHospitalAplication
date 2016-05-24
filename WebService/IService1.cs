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

        [OperationContract]
        UtilizadorWeb validarLogin(string username, string password);

        [OperationContract]
        List<UtilizadorWeb> procurarUtilizadores(string campoPesquisa);



        // TODO: Add your service operations here
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
}
