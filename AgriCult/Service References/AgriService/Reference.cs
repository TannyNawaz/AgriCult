﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgriCult.AgriService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Farm", Namespace="http://schemas.datacontract.org/2004/07/AgriRepository.Entities")]
    [System.SerializableAttribute()]
    public partial class Farm : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FarmNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float FarmSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AgriCult.AgriService.FarmType FarmTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AgriCult.AgriService.AgriAddress LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AgriCult.AgriService.Person OwnerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecializationField;
        
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
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FarmName {
            get {
                return this.FarmNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FarmNameField, value) != true)) {
                    this.FarmNameField = value;
                    this.RaisePropertyChanged("FarmName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float FarmSize {
            get {
                return this.FarmSizeField;
            }
            set {
                if ((this.FarmSizeField.Equals(value) != true)) {
                    this.FarmSizeField = value;
                    this.RaisePropertyChanged("FarmSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AgriCult.AgriService.FarmType FarmType {
            get {
                return this.FarmTypeField;
            }
            set {
                if ((this.FarmTypeField.Equals(value) != true)) {
                    this.FarmTypeField = value;
                    this.RaisePropertyChanged("FarmType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AgriCult.AgriService.AgriAddress Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AgriCult.AgriService.Person Owner {
            get {
                return this.OwnerField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerField, value) != true)) {
                    this.OwnerField = value;
                    this.RaisePropertyChanged("Owner");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialization {
            get {
                return this.SpecializationField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecializationField, value) != true)) {
                    this.SpecializationField = value;
                    this.RaisePropertyChanged("Specialization");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AgriAddress", Namespace="http://schemas.datacontract.org/2004/07/AgriRepository.Entities")]
    [System.SerializableAttribute()]
    public partial class AgriAddress : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgriAddressIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ZipCodeField;
        
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
        public int AgriAddressID {
            get {
                return this.AgriAddressIDField;
            }
            set {
                if ((this.AgriAddressIDField.Equals(value) != true)) {
                    this.AgriAddressIDField = value;
                    this.RaisePropertyChanged("AgriAddressID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Area {
            get {
                return this.AreaField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaField, value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((this.ZipCodeField.Equals(value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/AgriRepository.Entities")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BackgroundField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string Background {
            get {
                return this.BackgroundField;
            }
            set {
                if ((object.ReferenceEquals(this.BackgroundField, value) != true)) {
                    this.BackgroundField = value;
                    this.RaisePropertyChanged("Background");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FarmType", Namespace="http://schemas.datacontract.org/2004/07/AgriRepository.Entities")]
    public enum FarmType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Agriculture = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dairy = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Poultry = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fishing = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hatchery = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgriCultSvcData", Namespace="http://schemas.datacontract.org/2004/07/AgriCult.Service")]
    [System.SerializableAttribute()]
    public partial class AgriCultSvcData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultField;
        
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
        public string ErrorDetails {
            get {
                return this.ErrorDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDetailsField, value) != true)) {
                    this.ErrorDetailsField = value;
                    this.RaisePropertyChanged("ErrorDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgriService.IFarmService")]
    public interface IFarmService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/GetFarms", ReplyAction="http://tempuri.org/IFarmService/GetFarmsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AgriCult.AgriService.AgriCultSvcData), Action="http://tempuri.org/IFarmService/GetFarmsAgriCultSvcDataFault", Name="AgriCultSvcData", Namespace="http://schemas.datacontract.org/2004/07/AgriCult.Service")]
        AgriCult.AgriService.Farm[] GetFarms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/GetFarms", ReplyAction="http://tempuri.org/IFarmService/GetFarmsResponse")]
        System.Threading.Tasks.Task<AgriCult.AgriService.Farm[]> GetFarmsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/GetFarm", ReplyAction="http://tempuri.org/IFarmService/GetFarmResponse")]
        AgriCult.AgriService.Farm GetFarm(int farmID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/GetFarm", ReplyAction="http://tempuri.org/IFarmService/GetFarmResponse")]
        System.Threading.Tasks.Task<AgriCult.AgriService.Farm> GetFarmAsync(int farmID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/Add", ReplyAction="http://tempuri.org/IFarmService/AddResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AgriCult.AgriService.AgriCultSvcData), Action="http://tempuri.org/IFarmService/AddAgriCultSvcDataFault", Name="AgriCultSvcData", Namespace="http://schemas.datacontract.org/2004/07/AgriCult.Service")]
        void Add(AgriCult.AgriService.Farm farm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/Add", ReplyAction="http://tempuri.org/IFarmService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(AgriCult.AgriService.Farm farm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/Update", ReplyAction="http://tempuri.org/IFarmService/UpdateResponse")]
        void Update(AgriCult.AgriService.Farm farm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/Update", ReplyAction="http://tempuri.org/IFarmService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(AgriCult.AgriService.Farm farm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/Delete", ReplyAction="http://tempuri.org/IFarmService/DeleteResponse")]
        void Delete(int farmID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFarmService/Delete", ReplyAction="http://tempuri.org/IFarmService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int farmID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFarmServiceChannel : AgriCult.AgriService.IFarmService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FarmServiceClient : System.ServiceModel.ClientBase<AgriCult.AgriService.IFarmService>, AgriCult.AgriService.IFarmService {
        
        public FarmServiceClient() {
        }
        
        public FarmServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FarmServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FarmServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FarmServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AgriCult.AgriService.Farm[] GetFarms() {
            return base.Channel.GetFarms();
        }
        
        public System.Threading.Tasks.Task<AgriCult.AgriService.Farm[]> GetFarmsAsync() {
            return base.Channel.GetFarmsAsync();
        }
        
        public AgriCult.AgriService.Farm GetFarm(int farmID) {
            return base.Channel.GetFarm(farmID);
        }
        
        public System.Threading.Tasks.Task<AgriCult.AgriService.Farm> GetFarmAsync(int farmID) {
            return base.Channel.GetFarmAsync(farmID);
        }
        
        public void Add(AgriCult.AgriService.Farm farm) {
            base.Channel.Add(farm);
        }
        
        public System.Threading.Tasks.Task AddAsync(AgriCult.AgriService.Farm farm) {
            return base.Channel.AddAsync(farm);
        }
        
        public void Update(AgriCult.AgriService.Farm farm) {
            base.Channel.Update(farm);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(AgriCult.AgriService.Farm farm) {
            return base.Channel.UpdateAsync(farm);
        }
        
        public void Delete(int farmID) {
            base.Channel.Delete(farmID);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int farmID) {
            return base.Channel.DeleteAsync(farmID);
        }
    }
}