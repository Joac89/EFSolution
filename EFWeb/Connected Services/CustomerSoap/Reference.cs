﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFWeb.CustomerSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerContract", Namespace="http://schemas.datacontract.org/2004/07/EFWCF.Contracts")]
    [System.SerializableAttribute()]
    public partial class CustomerContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DocumentTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentTypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthDateField, value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CityId {
            get {
                return this.CityIdField;
            }
            set {
                if ((this.CityIdField.Equals(value) != true)) {
                    this.CityIdField = value;
                    this.RaisePropertyChanged("CityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CountryId {
            get {
                return this.CountryIdField;
            }
            set {
                if ((this.CountryIdField.Equals(value) != true)) {
                    this.CountryIdField = value;
                    this.RaisePropertyChanged("CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryName {
            get {
                return this.CountryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryNameField, value) != true)) {
                    this.CountryNameField = value;
                    this.RaisePropertyChanged("CountryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((this.DepartmentIdField.Equals(value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentId {
            get {
                return this.DocumentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentIdField, value) != true)) {
                    this.DocumentIdField = value;
                    this.RaisePropertyChanged("DocumentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DocumentType {
            get {
                return this.DocumentTypeField;
            }
            set {
                if ((this.DocumentTypeField.Equals(value) != true)) {
                    this.DocumentTypeField = value;
                    this.RaisePropertyChanged("DocumentType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentTypeName {
            get {
                return this.DocumentTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentTypeNameField, value) != true)) {
                    this.DocumentTypeNameField = value;
                    this.RaisePropertyChanged("DocumentTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerSoap.ICustomer")]
    public interface ICustomer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/CreateCustomer", ReplyAction="http://tempuri.org/ICustomer/CreateCustomerResponse")]
        EFCommon.ResponseBase<long> CreateCustomer(EFWeb.CustomerSoap.CustomerContract data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/CreateCustomer", ReplyAction="http://tempuri.org/ICustomer/CreateCustomerResponse")]
        System.Threading.Tasks.Task<EFCommon.ResponseBase<long>> CreateCustomerAsync(EFWeb.CustomerSoap.CustomerContract data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/ReadCustomers", ReplyAction="http://tempuri.org/ICustomer/ReadCustomersResponse")]
        EFCommon.ResponseBase<System.Collections.Generic.List<EFWeb.CustomerSoap.CustomerContract>> ReadCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/ReadCustomers", ReplyAction="http://tempuri.org/ICustomer/ReadCustomersResponse")]
        System.Threading.Tasks.Task<EFCommon.ResponseBase<System.Collections.Generic.List<EFWeb.CustomerSoap.CustomerContract>>> ReadCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/ReadCustomerByIdOrName", ReplyAction="http://tempuri.org/ICustomer/ReadCustomerByIdOrNameResponse")]
        EFCommon.ResponseBase<EFWeb.CustomerSoap.CustomerContract> ReadCustomerByIdOrName(long id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/ReadCustomerByIdOrName", ReplyAction="http://tempuri.org/ICustomer/ReadCustomerByIdOrNameResponse")]
        System.Threading.Tasks.Task<EFCommon.ResponseBase<EFWeb.CustomerSoap.CustomerContract>> ReadCustomerByIdOrNameAsync(long id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomer/UpdateCustomerResponse")]
        EFCommon.ResponseBase<bool> UpdateCustomer(EFWeb.CustomerSoap.CustomerContract data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomer/UpdateCustomerResponse")]
        System.Threading.Tasks.Task<EFCommon.ResponseBase<bool>> UpdateCustomerAsync(EFWeb.CustomerSoap.CustomerContract data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/DeleteCustomerResponse")]
        EFCommon.ResponseBase<bool> DeleteCustomer(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/DeleteCustomerResponse")]
        System.Threading.Tasks.Task<EFCommon.ResponseBase<bool>> DeleteCustomerAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerChannel : EFWeb.CustomerSoap.ICustomer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerClient : System.ServiceModel.ClientBase<EFWeb.CustomerSoap.ICustomer>, EFWeb.CustomerSoap.ICustomer {
        
        public CustomerClient() {
        }
        
        public CustomerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EFCommon.ResponseBase<long> CreateCustomer(EFWeb.CustomerSoap.CustomerContract data) {
            return base.Channel.CreateCustomer(data);
        }
        
        public System.Threading.Tasks.Task<EFCommon.ResponseBase<long>> CreateCustomerAsync(EFWeb.CustomerSoap.CustomerContract data) {
            return base.Channel.CreateCustomerAsync(data);
        }
        
        public EFCommon.ResponseBase<System.Collections.Generic.List<EFWeb.CustomerSoap.CustomerContract>> ReadCustomers() {
            return base.Channel.ReadCustomers();
        }
        
        public System.Threading.Tasks.Task<EFCommon.ResponseBase<System.Collections.Generic.List<EFWeb.CustomerSoap.CustomerContract>>> ReadCustomersAsync() {
            return base.Channel.ReadCustomersAsync();
        }
        
        public EFCommon.ResponseBase<EFWeb.CustomerSoap.CustomerContract> ReadCustomerByIdOrName(long id, string name) {
            return base.Channel.ReadCustomerByIdOrName(id, name);
        }
        
        public System.Threading.Tasks.Task<EFCommon.ResponseBase<EFWeb.CustomerSoap.CustomerContract>> ReadCustomerByIdOrNameAsync(long id, string name) {
            return base.Channel.ReadCustomerByIdOrNameAsync(id, name);
        }
        
        public EFCommon.ResponseBase<bool> UpdateCustomer(EFWeb.CustomerSoap.CustomerContract data) {
            return base.Channel.UpdateCustomer(data);
        }
        
        public System.Threading.Tasks.Task<EFCommon.ResponseBase<bool>> UpdateCustomerAsync(EFWeb.CustomerSoap.CustomerContract data) {
            return base.Channel.UpdateCustomerAsync(data);
        }
        
        public EFCommon.ResponseBase<bool> DeleteCustomer(long id) {
            return base.Channel.DeleteCustomer(id);
        }
        
        public System.Threading.Tasks.Task<EFCommon.ResponseBase<bool>> DeleteCustomerAsync(long id) {
            return base.Channel.DeleteCustomerAsync(id);
        }
    }
}