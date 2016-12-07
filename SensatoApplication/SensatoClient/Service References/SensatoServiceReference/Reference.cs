﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SensatoClient.SensatoServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsernameValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
    [System.SerializableAttribute()]
    public partial class UsernameValidationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PasswordValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
    [System.SerializableAttribute()]
    public partial class PasswordValidationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HiveDTO", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.DataTransferObjects")]
    [System.SerializableAttribute()]
    public partial class HiveDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.Frame[] FramesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRemovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.User UserField;
        
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
        public SensatoClient.SensatoServiceReference.Frame[] Frames {
            get {
                return this.FramesField;
            }
            set {
                if ((object.ReferenceEquals(this.FramesField, value) != true)) {
                    this.FramesField = value;
                    this.RaisePropertyChanged("Frames");
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
        public bool IsRemoved {
            get {
                return this.IsRemovedField;
            }
            set {
                if ((this.IsRemovedField.Equals(value) != true)) {
                    this.IsRemovedField = value;
                    this.RaisePropertyChanged("IsRemoved");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SensatoClient.SensatoServiceReference.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/SensatoWebService.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.Hive[] HivesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsDisabledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsLoggedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.RoleType RoleField;
        
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
        public SensatoClient.SensatoServiceReference.Hive[] Hives {
            get {
                return this.HivesField;
            }
            set {
                if ((object.ReferenceEquals(this.HivesField, value) != true)) {
                    this.HivesField = value;
                    this.RaisePropertyChanged("Hives");
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
        public bool IsDisabled {
            get {
                return this.IsDisabledField;
            }
            set {
                if ((this.IsDisabledField.Equals(value) != true)) {
                    this.IsDisabledField = value;
                    this.RaisePropertyChanged("IsDisabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsLogged {
            get {
                return this.IsLoggedField;
            }
            set {
                if ((this.IsLoggedField.Equals(value) != true)) {
                    this.IsLoggedField = value;
                    this.RaisePropertyChanged("IsLogged");
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
        public SensatoClient.SensatoServiceReference.RoleType Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Frame", Namespace="http://schemas.datacontract.org/2004/07/SensatoWebService.Models")]
    [System.SerializableAttribute()]
    public partial class Frame : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.Hive HiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRemovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.Measurment[] MeasurmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PositionField;
        
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
        public SensatoClient.SensatoServiceReference.Hive Hive {
            get {
                return this.HiveField;
            }
            set {
                if ((object.ReferenceEquals(this.HiveField, value) != true)) {
                    this.HiveField = value;
                    this.RaisePropertyChanged("Hive");
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
        public bool IsRemoved {
            get {
                return this.IsRemovedField;
            }
            set {
                if ((this.IsRemovedField.Equals(value) != true)) {
                    this.IsRemovedField = value;
                    this.RaisePropertyChanged("IsRemoved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SensatoClient.SensatoServiceReference.Measurment[] Measurments {
            get {
                return this.MeasurmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.MeasurmentsField, value) != true)) {
                    this.MeasurmentsField = value;
                    this.RaisePropertyChanged("Measurments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Position {
            get {
                return this.PositionField;
            }
            set {
                if ((this.PositionField.Equals(value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Hive", Namespace="http://schemas.datacontract.org/2004/07/SensatoWebService.Models")]
    [System.SerializableAttribute()]
    public partial class Hive : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.Frame[] FramesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRemovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.User UserField;
        
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
        public SensatoClient.SensatoServiceReference.Frame[] Frames {
            get {
                return this.FramesField;
            }
            set {
                if ((object.ReferenceEquals(this.FramesField, value) != true)) {
                    this.FramesField = value;
                    this.RaisePropertyChanged("Frames");
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
        public bool IsRemoved {
            get {
                return this.IsRemovedField;
            }
            set {
                if ((this.IsRemovedField.Equals(value) != true)) {
                    this.IsRemovedField = value;
                    this.RaisePropertyChanged("IsRemoved");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SensatoClient.SensatoServiceReference.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Measurment", Namespace="http://schemas.datacontract.org/2004/07/SensatoWebService.Models")]
    [System.SerializableAttribute()]
    public partial class Measurment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeOfMeasurmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float FirstSensorTempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.Frame FrameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsDeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float SecondSensorTempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ThirdSensorTempField;
        
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
        public System.DateTime DateTimeOfMeasurment {
            get {
                return this.DateTimeOfMeasurmentField;
            }
            set {
                if ((this.DateTimeOfMeasurmentField.Equals(value) != true)) {
                    this.DateTimeOfMeasurmentField = value;
                    this.RaisePropertyChanged("DateTimeOfMeasurment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float FirstSensorTemp {
            get {
                return this.FirstSensorTempField;
            }
            set {
                if ((this.FirstSensorTempField.Equals(value) != true)) {
                    this.FirstSensorTempField = value;
                    this.RaisePropertyChanged("FirstSensorTemp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SensatoClient.SensatoServiceReference.Frame Frame {
            get {
                return this.FrameField;
            }
            set {
                if ((object.ReferenceEquals(this.FrameField, value) != true)) {
                    this.FrameField = value;
                    this.RaisePropertyChanged("Frame");
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
        public bool IsDeleted {
            get {
                return this.IsDeletedField;
            }
            set {
                if ((this.IsDeletedField.Equals(value) != true)) {
                    this.IsDeletedField = value;
                    this.RaisePropertyChanged("IsDeleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float SecondSensorTemp {
            get {
                return this.SecondSensorTempField;
            }
            set {
                if ((this.SecondSensorTempField.Equals(value) != true)) {
                    this.SecondSensorTempField = value;
                    this.RaisePropertyChanged("SecondSensorTemp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float ThirdSensorTemp {
            get {
                return this.ThirdSensorTempField;
            }
            set {
                if ((this.ThirdSensorTempField.Equals(value) != true)) {
                    this.ThirdSensorTempField = value;
                    this.RaisePropertyChanged("ThirdSensorTemp");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleType", Namespace="http://schemas.datacontract.org/2004/07/SensatoWebService.Models.Enumerations")]
    public enum RoleType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        User = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Administrator = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SensatoServiceReference.ISensatoService")]
    public interface ISensatoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckUserExists", ReplyAction="http://tempuri.org/ISensatoService/CheckUserExistsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.UsernameValidationFault), Action="http://tempuri.org/ISensatoService/CheckUserExistsUsernameValidationFaultFault", Name="UsernameValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        bool CheckUserExists(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckUserExists", ReplyAction="http://tempuri.org/ISensatoService/CheckUserExistsResponse")]
        System.Threading.Tasks.Task<bool> CheckUserExistsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckPassowrdMatch", ReplyAction="http://tempuri.org/ISensatoService/CheckPassowrdMatchResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.PasswordValidationFault), Action="http://tempuri.org/ISensatoService/CheckPassowrdMatchPasswordValidationFaultFault" +
            "", Name="PasswordValidationFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        bool CheckPassowrdMatch(string passwordHash, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/CheckPassowrdMatch", ReplyAction="http://tempuri.org/ISensatoService/CheckPassowrdMatchResponse")]
        System.Threading.Tasks.Task<bool> CheckPassowrdMatchAsync(string passwordHash, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetHivesByUser", ReplyAction="http://tempuri.org/ISensatoService/GetHivesByUserResponse")]
        SensatoClient.SensatoServiceReference.HiveDTO[] GetHivesByUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetHivesByUser", ReplyAction="http://tempuri.org/ISensatoService/GetHivesByUserResponse")]
        System.Threading.Tasks.Task<SensatoClient.SensatoServiceReference.HiveDTO[]> GetHivesByUserAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISensatoServiceChannel : SensatoClient.SensatoServiceReference.ISensatoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SensatoServiceClient : System.ServiceModel.ClientBase<SensatoClient.SensatoServiceReference.ISensatoService>, SensatoClient.SensatoServiceReference.ISensatoService {
        
        public SensatoServiceClient() {
        }
        
        public SensatoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SensatoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensatoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensatoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckUserExists(string username) {
            return base.Channel.CheckUserExists(username);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserExistsAsync(string username) {
            return base.Channel.CheckUserExistsAsync(username);
        }
        
        public bool CheckPassowrdMatch(string passwordHash, string username) {
            return base.Channel.CheckPassowrdMatch(passwordHash, username);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPassowrdMatchAsync(string passwordHash, string username) {
            return base.Channel.CheckPassowrdMatchAsync(passwordHash, username);
        }
        
        public SensatoClient.SensatoServiceReference.HiveDTO[] GetHivesByUser(string username) {
            return base.Channel.GetHivesByUser(username);
        }
        
        public System.Threading.Tasks.Task<SensatoClient.SensatoServiceReference.HiveDTO[]> GetHivesByUserAsync(string username) {
            return base.Channel.GetHivesByUserAsync(username);
        }
    }
}
