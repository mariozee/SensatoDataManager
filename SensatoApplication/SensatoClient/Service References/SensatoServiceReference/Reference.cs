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
    [System.Runtime.Serialization.DataContractAttribute(Name="AlreadyExistFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
    [System.SerializableAttribute()]
    public partial class AlreadyExistFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FrameDTO", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.DataTransferObjects")]
    [System.SerializableAttribute()]
    public partial class FrameDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SensatoClient.SensatoServiceReference.MeasurmentDTO[] MeasurmentsField;
        
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
        public SensatoClient.SensatoServiceReference.MeasurmentDTO[] Measurments {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MeasurmentDTO", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.DataTransferObjects")]
    [System.SerializableAttribute()]
    public partial class MeasurmentDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeOfMeasurmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float FirstSensorTempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<float> OutsideTempField;
        
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
        public System.Nullable<float> OutsideTemp {
            get {
                return this.OutsideTempField;
            }
            set {
                if ((this.OutsideTempField.Equals(value) != true)) {
                    this.OutsideTempField = value;
                    this.RaisePropertyChanged("OutsideTemp");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetUserHivesByUsername", ReplyAction="http://tempuri.org/ISensatoService/GetUserHivesByUsernameResponse")]
        string[] GetUserHivesByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetUserHivesByUsername", ReplyAction="http://tempuri.org/ISensatoService/GetUserHivesByUsernameResponse")]
        System.Threading.Tasks.Task<string[]> GetUserHivesByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/AddHive", ReplyAction="http://tempuri.org/ISensatoService/AddHiveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.AlreadyExistFault), Action="http://tempuri.org/ISensatoService/AddHiveAlreadyExistFaultFault", Name="AlreadyExistFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        void AddHive(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/AddHive", ReplyAction="http://tempuri.org/ISensatoService/AddHiveResponse")]
        System.Threading.Tasks.Task AddHiveAsync(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RenameHive", ReplyAction="http://tempuri.org/ISensatoService/RenameHiveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SensatoClient.SensatoServiceReference.AlreadyExistFault), Action="http://tempuri.org/ISensatoService/RenameHiveAlreadyExistFaultFault", Name="AlreadyExistFault", Namespace="http://schemas.datacontract.org/2004/07/SensatoDBService.Faults")]
        bool RenameHive(string username, string newHiveName, string currentHiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RenameHive", ReplyAction="http://tempuri.org/ISensatoService/RenameHiveResponse")]
        System.Threading.Tasks.Task<bool> RenameHiveAsync(string username, string newHiveName, string currentHiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RemoveHive", ReplyAction="http://tempuri.org/ISensatoService/RemoveHiveResponse")]
        bool RemoveHive(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/RemoveHive", ReplyAction="http://tempuri.org/ISensatoService/RemoveHiveResponse")]
        System.Threading.Tasks.Task<bool> RemoveHiveAsync(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetFramesByHive", ReplyAction="http://tempuri.org/ISensatoService/GetFramesByHiveResponse")]
        int[] GetFramesByHive(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetFramesByHive", ReplyAction="http://tempuri.org/ISensatoService/GetFramesByHiveResponse")]
        System.Threading.Tasks.Task<int[]> GetFramesByHiveAsync(string username, string hiveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/ChangeFrameStatusByHive", ReplyAction="http://tempuri.org/ISensatoService/ChangeFrameStatusByHiveResponse")]
        void ChangeFrameStatusByHive(string username, string hivename, int[] activeFramesPositions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/ChangeFrameStatusByHive", ReplyAction="http://tempuri.org/ISensatoService/ChangeFrameStatusByHiveResponse")]
        System.Threading.Tasks.Task ChangeFrameStatusByHiveAsync(string username, string hivename, int[] activeFramesPositions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetMeasurmentData", ReplyAction="http://tempuri.org/ISensatoService/GetMeasurmentDataResponse")]
        SensatoClient.SensatoServiceReference.FrameDTO[] GetMeasurmentData(string username, string hiveName, System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetMeasurmentData", ReplyAction="http://tempuri.org/ISensatoService/GetMeasurmentDataResponse")]
        System.Threading.Tasks.Task<SensatoClient.SensatoServiceReference.FrameDTO[]> GetMeasurmentDataAsync(string username, string hiveName, System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/UploadMeasurmentData", ReplyAction="http://tempuri.org/ISensatoService/UploadMeasurmentDataResponse")]
        void UploadMeasurmentData(string usernama, string hiveName, System.Collections.Generic.Dictionary<int, object[][]> measurmentsData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/UploadMeasurmentData", ReplyAction="http://tempuri.org/ISensatoService/UploadMeasurmentDataResponse")]
        System.Threading.Tasks.Task UploadMeasurmentDataAsync(string usernama, string hiveName, System.Collections.Generic.Dictionary<int, object[][]> measurmentsData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/SendEmail", ReplyAction="http://tempuri.org/ISensatoService/SendEmailResponse")]
        bool SendEmail(string emailTo, string subject, string body, bool isBodyHtml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/SendEmail", ReplyAction="http://tempuri.org/ISensatoService/SendEmailResponse")]
        System.Threading.Tasks.Task<bool> SendEmailAsync(string emailTo, string subject, string body, bool isBodyHtml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetMeasurments", ReplyAction="http://tempuri.org/ISensatoService/GetMeasurmentsResponse")]
        string GetMeasurments(string strHiveId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISensatoService/GetMeasurments", ReplyAction="http://tempuri.org/ISensatoService/GetMeasurmentsResponse")]
        System.Threading.Tasks.Task<string> GetMeasurmentsAsync(string strHiveId);
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
        
        public string[] GetUserHivesByUsername(string username) {
            return base.Channel.GetUserHivesByUsername(username);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUserHivesByUsernameAsync(string username) {
            return base.Channel.GetUserHivesByUsernameAsync(username);
        }
        
        public void AddHive(string username, string hiveName) {
            base.Channel.AddHive(username, hiveName);
        }
        
        public System.Threading.Tasks.Task AddHiveAsync(string username, string hiveName) {
            return base.Channel.AddHiveAsync(username, hiveName);
        }
        
        public bool RenameHive(string username, string newHiveName, string currentHiveName) {
            return base.Channel.RenameHive(username, newHiveName, currentHiveName);
        }
        
        public System.Threading.Tasks.Task<bool> RenameHiveAsync(string username, string newHiveName, string currentHiveName) {
            return base.Channel.RenameHiveAsync(username, newHiveName, currentHiveName);
        }
        
        public bool RemoveHive(string username, string hiveName) {
            return base.Channel.RemoveHive(username, hiveName);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveHiveAsync(string username, string hiveName) {
            return base.Channel.RemoveHiveAsync(username, hiveName);
        }
        
        public int[] GetFramesByHive(string username, string hiveName) {
            return base.Channel.GetFramesByHive(username, hiveName);
        }
        
        public System.Threading.Tasks.Task<int[]> GetFramesByHiveAsync(string username, string hiveName) {
            return base.Channel.GetFramesByHiveAsync(username, hiveName);
        }
        
        public void ChangeFrameStatusByHive(string username, string hivename, int[] activeFramesPositions) {
            base.Channel.ChangeFrameStatusByHive(username, hivename, activeFramesPositions);
        }
        
        public System.Threading.Tasks.Task ChangeFrameStatusByHiveAsync(string username, string hivename, int[] activeFramesPositions) {
            return base.Channel.ChangeFrameStatusByHiveAsync(username, hivename, activeFramesPositions);
        }
        
        public SensatoClient.SensatoServiceReference.FrameDTO[] GetMeasurmentData(string username, string hiveName, System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetMeasurmentData(username, hiveName, startDate, endDate);
        }
        
        public System.Threading.Tasks.Task<SensatoClient.SensatoServiceReference.FrameDTO[]> GetMeasurmentDataAsync(string username, string hiveName, System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetMeasurmentDataAsync(username, hiveName, startDate, endDate);
        }
        
        public void UploadMeasurmentData(string usernama, string hiveName, System.Collections.Generic.Dictionary<int, object[][]> measurmentsData) {
            base.Channel.UploadMeasurmentData(usernama, hiveName, measurmentsData);
        }
        
        public System.Threading.Tasks.Task UploadMeasurmentDataAsync(string usernama, string hiveName, System.Collections.Generic.Dictionary<int, object[][]> measurmentsData) {
            return base.Channel.UploadMeasurmentDataAsync(usernama, hiveName, measurmentsData);
        }
        
        public bool SendEmail(string emailTo, string subject, string body, bool isBodyHtml) {
            return base.Channel.SendEmail(emailTo, subject, body, isBodyHtml);
        }
        
        public System.Threading.Tasks.Task<bool> SendEmailAsync(string emailTo, string subject, string body, bool isBodyHtml) {
            return base.Channel.SendEmailAsync(emailTo, subject, body, isBodyHtml);
        }
        
        public string GetMeasurments(string strHiveId) {
            return base.Channel.GetMeasurments(strHiveId);
        }
        
        public System.Threading.Tasks.Task<string> GetMeasurmentsAsync(string strHiveId) {
            return base.Channel.GetMeasurmentsAsync(strHiveId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SensatoServiceReference.IHardwareCommunication")]
    public interface IHardwareCommunication {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHardwareCommunication/TestRenameHive", ReplyAction="http://tempuri.org/IHardwareCommunication/TestRenameHiveResponse")]
        string TestRenameHive(string testData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHardwareCommunication/TestRenameHive", ReplyAction="http://tempuri.org/IHardwareCommunication/TestRenameHiveResponse")]
        System.Threading.Tasks.Task<string> TestRenameHiveAsync(string testData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHardwareCommunicationChannel : SensatoClient.SensatoServiceReference.IHardwareCommunication, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HardwareCommunicationClient : System.ServiceModel.ClientBase<SensatoClient.SensatoServiceReference.IHardwareCommunication>, SensatoClient.SensatoServiceReference.IHardwareCommunication {
        
        public HardwareCommunicationClient() {
        }
        
        public HardwareCommunicationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HardwareCommunicationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HardwareCommunicationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HardwareCommunicationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TestRenameHive(string testData) {
            return base.Channel.TestRenameHive(testData);
        }
        
        public System.Threading.Tasks.Task<string> TestRenameHiveAsync(string testData) {
            return base.Channel.TestRenameHiveAsync(testData);
        }
    }
}
