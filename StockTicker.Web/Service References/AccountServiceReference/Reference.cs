﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTicker.Web.AccountServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultModelOfUserModel", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ResultModelOfUserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool SuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StockTicker.Web.AccountServiceReference.UserModel ResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public StockTicker.Web.AccountServiceReference.UserModel Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        private StockTicker.Web.AccountServiceReference.MemberRole RoleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public StockTicker.Web.AccountServiceReference.MemberRole Role {
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MemberRole", Namespace="http://tempuri.org/")]
    public enum MemberRole : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Developer = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Client = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountServiceReference.AccountWebServiceSoap")]
    public interface AccountWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name user from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        StockTicker.Web.AccountServiceReference.LoginResponse Login(StockTicker.Web.AccountServiceReference.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<StockTicker.Web.AccountServiceReference.LoginResponse> LoginAsync(StockTicker.Web.AccountServiceReference.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name fullName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        StockTicker.Web.AccountServiceReference.RegisterResponse Register(StockTicker.Web.AccountServiceReference.RegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        System.Threading.Tasks.Task<StockTicker.Web.AccountServiceReference.RegisterResponse> RegisterAsync(StockTicker.Web.AccountServiceReference.RegisterRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public StockTicker.Web.AccountServiceReference.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(StockTicker.Web.AccountServiceReference.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string user, string password) {
            this.user = user;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public StockTicker.Web.AccountServiceReference.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(StockTicker.Web.AccountServiceReference.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public StockTicker.Web.AccountServiceReference.ResultModelOfUserModel LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(StockTicker.Web.AccountServiceReference.ResultModelOfUserModel LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Register", Namespace="http://tempuri.org/", Order=0)]
        public StockTicker.Web.AccountServiceReference.RegisterRequestBody Body;
        
        public RegisterRequest() {
        }
        
        public RegisterRequest(StockTicker.Web.AccountServiceReference.RegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fullName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string password;
        
        public RegisterRequestBody() {
        }
        
        public RegisterRequestBody(string fullName, string email, string password) {
            this.fullName = fullName;
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public StockTicker.Web.AccountServiceReference.RegisterResponseBody Body;
        
        public RegisterResponse() {
        }
        
        public RegisterResponse(StockTicker.Web.AccountServiceReference.RegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public StockTicker.Web.AccountServiceReference.ResultModelOfUserModel RegisterResult;
        
        public RegisterResponseBody() {
        }
        
        public RegisterResponseBody(StockTicker.Web.AccountServiceReference.ResultModelOfUserModel RegisterResult) {
            this.RegisterResult = RegisterResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AccountWebServiceSoapChannel : StockTicker.Web.AccountServiceReference.AccountWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountWebServiceSoapClient : System.ServiceModel.ClientBase<StockTicker.Web.AccountServiceReference.AccountWebServiceSoap>, StockTicker.Web.AccountServiceReference.AccountWebServiceSoap {
        
        public AccountWebServiceSoapClient() {
        }
        
        public AccountWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockTicker.Web.AccountServiceReference.LoginResponse StockTicker.Web.AccountServiceReference.AccountWebServiceSoap.Login(StockTicker.Web.AccountServiceReference.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public StockTicker.Web.AccountServiceReference.ResultModelOfUserModel Login(string user, string password) {
            StockTicker.Web.AccountServiceReference.LoginRequest inValue = new StockTicker.Web.AccountServiceReference.LoginRequest();
            inValue.Body = new StockTicker.Web.AccountServiceReference.LoginRequestBody();
            inValue.Body.user = user;
            inValue.Body.password = password;
            StockTicker.Web.AccountServiceReference.LoginResponse retVal = ((StockTicker.Web.AccountServiceReference.AccountWebServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockTicker.Web.AccountServiceReference.LoginResponse> StockTicker.Web.AccountServiceReference.AccountWebServiceSoap.LoginAsync(StockTicker.Web.AccountServiceReference.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockTicker.Web.AccountServiceReference.LoginResponse> LoginAsync(string user, string password) {
            StockTicker.Web.AccountServiceReference.LoginRequest inValue = new StockTicker.Web.AccountServiceReference.LoginRequest();
            inValue.Body = new StockTicker.Web.AccountServiceReference.LoginRequestBody();
            inValue.Body.user = user;
            inValue.Body.password = password;
            return ((StockTicker.Web.AccountServiceReference.AccountWebServiceSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockTicker.Web.AccountServiceReference.RegisterResponse StockTicker.Web.AccountServiceReference.AccountWebServiceSoap.Register(StockTicker.Web.AccountServiceReference.RegisterRequest request) {
            return base.Channel.Register(request);
        }
        
        public StockTicker.Web.AccountServiceReference.ResultModelOfUserModel Register(string fullName, string email, string password) {
            StockTicker.Web.AccountServiceReference.RegisterRequest inValue = new StockTicker.Web.AccountServiceReference.RegisterRequest();
            inValue.Body = new StockTicker.Web.AccountServiceReference.RegisterRequestBody();
            inValue.Body.fullName = fullName;
            inValue.Body.email = email;
            inValue.Body.password = password;
            StockTicker.Web.AccountServiceReference.RegisterResponse retVal = ((StockTicker.Web.AccountServiceReference.AccountWebServiceSoap)(this)).Register(inValue);
            return retVal.Body.RegisterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockTicker.Web.AccountServiceReference.RegisterResponse> StockTicker.Web.AccountServiceReference.AccountWebServiceSoap.RegisterAsync(StockTicker.Web.AccountServiceReference.RegisterRequest request) {
            return base.Channel.RegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockTicker.Web.AccountServiceReference.RegisterResponse> RegisterAsync(string fullName, string email, string password) {
            StockTicker.Web.AccountServiceReference.RegisterRequest inValue = new StockTicker.Web.AccountServiceReference.RegisterRequest();
            inValue.Body = new StockTicker.Web.AccountServiceReference.RegisterRequestBody();
            inValue.Body.fullName = fullName;
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((StockTicker.Web.AccountServiceReference.AccountWebServiceSoap)(this)).RegisterAsync(inValue);
        }
    }
}
