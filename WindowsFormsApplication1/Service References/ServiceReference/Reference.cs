﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UtilizadorWeb", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class UtilizadorWeb : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CargoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoradaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NInternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuspensaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoUtilizadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cargo {
            get {
                return this.CargoField;
            }
            set {
                if ((object.ReferenceEquals(this.CargoField, value) != true)) {
                    this.CargoField = value;
                    this.RaisePropertyChanged("Cargo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Morada {
            get {
                return this.MoradaField;
            }
            set {
                if ((object.ReferenceEquals(this.MoradaField, value) != true)) {
                    this.MoradaField = value;
                    this.RaisePropertyChanged("Morada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NInterno {
            get {
                return this.NInternoField;
            }
            set {
                if ((this.NInternoField.Equals(value) != true)) {
                    this.NInternoField = value;
                    this.RaisePropertyChanged("NInterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Suspensao {
            get {
                return this.SuspensaoField;
            }
            set {
                if ((this.SuspensaoField.Equals(value) != true)) {
                    this.SuspensaoField = value;
                    this.RaisePropertyChanged("Suspensao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoUtilizador {
            get {
                return this.TipoUtilizadorField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoUtilizadorField, value) != true)) {
                    this.TipoUtilizadorField = value;
                    this.RaisePropertyChanged("TipoUtilizador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UtenteWeb", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class UtenteWeb : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApelidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BatimentoCardiacoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoPostalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColestrolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GlicemiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoradaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PesoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrimeiroNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaturacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SnsIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TensaoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Altura {
            get {
                return this.AlturaField;
            }
            set {
                if ((object.ReferenceEquals(this.AlturaField, value) != true)) {
                    this.AlturaField = value;
                    this.RaisePropertyChanged("Altura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apelido {
            get {
                return this.ApelidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApelidoField, value) != true)) {
                    this.ApelidoField = value;
                    this.RaisePropertyChanged("Apelido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BatimentoCardiaco {
            get {
                return this.BatimentoCardiacoField;
            }
            set {
                if ((object.ReferenceEquals(this.BatimentoCardiacoField, value) != true)) {
                    this.BatimentoCardiacoField = value;
                    this.RaisePropertyChanged("BatimentoCardiaco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoPostal {
            get {
                return this.CodigoPostalField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoPostalField, value) != true)) {
                    this.CodigoPostalField = value;
                    this.RaisePropertyChanged("CodigoPostal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Colestrol {
            get {
                return this.ColestrolField;
            }
            set {
                if ((object.ReferenceEquals(this.ColestrolField, value) != true)) {
                    this.ColestrolField = value;
                    this.RaisePropertyChanged("Colestrol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contacto {
            get {
                return this.ContactoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactoField, value) != true)) {
                    this.ContactoField = value;
                    this.RaisePropertyChanged("Contacto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Glicemia {
            get {
                return this.GlicemiaField;
            }
            set {
                if ((object.ReferenceEquals(this.GlicemiaField, value) != true)) {
                    this.GlicemiaField = value;
                    this.RaisePropertyChanged("Glicemia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Morada {
            get {
                return this.MoradaField;
            }
            set {
                if ((object.ReferenceEquals(this.MoradaField, value) != true)) {
                    this.MoradaField = value;
                    this.RaisePropertyChanged("Morada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Peso {
            get {
                return this.PesoField;
            }
            set {
                if ((object.ReferenceEquals(this.PesoField, value) != true)) {
                    this.PesoField = value;
                    this.RaisePropertyChanged("Peso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrimeiroNome {
            get {
                return this.PrimeiroNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.PrimeiroNomeField, value) != true)) {
                    this.PrimeiroNomeField = value;
                    this.RaisePropertyChanged("PrimeiroNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Saturacao {
            get {
                return this.SaturacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.SaturacaoField, value) != true)) {
                    this.SaturacaoField = value;
                    this.RaisePropertyChanged("Saturacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SnsId {
            get {
                return this.SnsIdField;
            }
            set {
                if ((this.SnsIdField.Equals(value) != true)) {
                    this.SnsIdField = value;
                    this.RaisePropertyChanged("SnsId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tensao {
            get {
                return this.TensaoField;
            }
            set {
                if ((object.ReferenceEquals(this.TensaoField, value) != true)) {
                    this.TensaoField = value;
                    this.RaisePropertyChanged("Tensao");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WindowsFormsApplication1.ServiceReference.CompositeType GetDataUsingDataContract(WindowsFormsApplication1.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.CompositeType> GetDataUsingDataContractAsync(WindowsFormsApplication1.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/validarLogin", ReplyAction="http://tempuri.org/IService1/validarLoginResponse")]
        WindowsFormsApplication1.ServiceReference.UtilizadorWeb validarLogin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/validarLogin", ReplyAction="http://tempuri.org/IService1/validarLoginResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.UtilizadorWeb> validarLoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/procurarUtilizadores", ReplyAction="http://tempuri.org/IService1/procurarUtilizadoresResponse")]
        WindowsFormsApplication1.ServiceReference.UtilizadorWeb[] procurarUtilizadores(string campoPesquisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/procurarUtilizadores", ReplyAction="http://tempuri.org/IService1/procurarUtilizadoresResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.UtilizadorWeb[]> procurarUtilizadoresAsync(string campoPesquisa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarSuspensao", ReplyAction="http://tempuri.org/IService1/alterarSuspensaoResponse")]
        bool alterarSuspensao(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarSuspensao", ReplyAction="http://tempuri.org/IService1/alterarSuspensaoResponse")]
        System.Threading.Tasks.Task<bool> alterarSuspensaoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/adicionarUtilizador", ReplyAction="http://tempuri.org/IService1/adicionarUtilizadorResponse")]
        bool adicionarUtilizador(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/adicionarUtilizador", ReplyAction="http://tempuri.org/IService1/adicionarUtilizadorResponse")]
        System.Threading.Tasks.Task<bool> adicionarUtilizadorAsync(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarUtilizador", ReplyAction="http://tempuri.org/IService1/alterarUtilizadorResponse")]
        bool alterarUtilizador(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarUtilizador", ReplyAction="http://tempuri.org/IService1/alterarUtilizadorResponse")]
        System.Threading.Tasks.Task<bool> alterarUtilizadorAsync(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/procurarUtente", ReplyAction="http://tempuri.org/IService1/procurarUtenteResponse")]
        WindowsFormsApplication1.ServiceReference.UtenteWeb procurarUtente(int snsId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/procurarUtente", ReplyAction="http://tempuri.org/IService1/procurarUtenteResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.UtenteWeb> procurarUtenteAsync(int snsId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApplication1.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference.IService1>, WindowsFormsApplication1.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WindowsFormsApplication1.ServiceReference.CompositeType GetDataUsingDataContract(WindowsFormsApplication1.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.CompositeType> GetDataUsingDataContractAsync(WindowsFormsApplication1.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WindowsFormsApplication1.ServiceReference.UtilizadorWeb validarLogin(string username, string password) {
            return base.Channel.validarLogin(username, password);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.UtilizadorWeb> validarLoginAsync(string username, string password) {
            return base.Channel.validarLoginAsync(username, password);
        }
        
        public WindowsFormsApplication1.ServiceReference.UtilizadorWeb[] procurarUtilizadores(string campoPesquisa) {
            return base.Channel.procurarUtilizadores(campoPesquisa);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.UtilizadorWeb[]> procurarUtilizadoresAsync(string campoPesquisa) {
            return base.Channel.procurarUtilizadoresAsync(campoPesquisa);
        }
        
        public bool alterarSuspensao(int id) {
            return base.Channel.alterarSuspensao(id);
        }
        
        public System.Threading.Tasks.Task<bool> alterarSuspensaoAsync(int id) {
            return base.Channel.alterarSuspensaoAsync(id);
        }
        
        public bool adicionarUtilizador(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador) {
            return base.Channel.adicionarUtilizador(nome, nInterno, morada, dataNascimento, cargo, password, tipoUtilizador);
        }
        
        public System.Threading.Tasks.Task<bool> adicionarUtilizadorAsync(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador) {
            return base.Channel.adicionarUtilizadorAsync(nome, nInterno, morada, dataNascimento, cargo, password, tipoUtilizador);
        }
        
        public bool alterarUtilizador(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador, int id) {
            return base.Channel.alterarUtilizador(nome, nInterno, morada, dataNascimento, cargo, password, tipoUtilizador, id);
        }
        
        public System.Threading.Tasks.Task<bool> alterarUtilizadorAsync(string nome, int nInterno, string morada, System.DateTime dataNascimento, string cargo, string password, string tipoUtilizador, int id) {
            return base.Channel.alterarUtilizadorAsync(nome, nInterno, morada, dataNascimento, cargo, password, tipoUtilizador, id);
        }
        
        public WindowsFormsApplication1.ServiceReference.UtenteWeb procurarUtente(int snsId) {
            return base.Channel.procurarUtente(snsId);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference.UtenteWeb> procurarUtenteAsync(int snsId) {
            return base.Channel.procurarUtenteAsync(snsId);
        }
    }
}