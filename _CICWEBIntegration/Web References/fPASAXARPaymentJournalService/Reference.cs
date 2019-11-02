﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace _CICWEBIntegration.fPASAXARPaymentJournalService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    // CODEGEN: No methods were found in the WSDL for this protocol.
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="serviceEndpoint", Namespace="http://tempuri.org/")]
    public partial class serviceEndpoint : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public serviceEndpoint() {
            this.Url = global::_CICWEBIntegration.Properties.Settings.Default._CICWEBIntegration_fPASAXARPaymentJournalService_RoutingService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_CICFPASARPaymentJournalService", Namespace="http://tempuri.org/")]
    public partial class BasicHttpBinding_CICFPASARPaymentJournalService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private CallContext callContextValueField;
        
        private System.Threading.SendOrPostCallback sendPaymentJournalOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_CICFPASARPaymentJournalService() {
            this.Url = global::_CICWEBIntegration.Properties.Settings.Default._CICWEBIntegration_fPASAXARPaymentJournalService_RoutingService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public CallContext CallContextValue {
            get {
                return this.callContextValueField;
            }
            set {
                this.callContextValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event sendPaymentJournalCompletedEventHandler sendPaymentJournalCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("CallContextValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CICFPASARPaymentJournalService/sendPaymentJournal", RequestElementName="CICFPASARPaymentJournalServiceSendPaymentJournalRequest", RequestNamespace="http://tempuri.org", ResponseElementName="CICFPASARPaymentJournalServiceSendPaymentJournalResponse", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("response", IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] sendPaymentJournal() {
            object[] results = this.Invoke("sendPaymentJournal", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void sendPaymentJournalAsync() {
            this.sendPaymentJournalAsync(null);
        }
        
        /// <remarks/>
        public void sendPaymentJournalAsync(object userState) {
            if ((this.sendPaymentJournalOperationCompleted == null)) {
                this.sendPaymentJournalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendPaymentJournalOperationCompleted);
            }
            this.InvokeAsync("sendPaymentJournal", new object[0], this.sendPaymentJournalOperationCompleted, userState);
        }
        
        private void OnsendPaymentJournalOperationCompleted(object arg) {
            if ((this.sendPaymentJournalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendPaymentJournalCompleted(this, new sendPaymentJournalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts", IsNullable=true)]
    public partial class CallContext : System.Web.Services.Protocols.SoapHeader {
        
        private string companyField;
        
        private string languageField;
        
        private string logonAsUserField;
        
        private string messageIdField;
        
        private string partitionKeyField;
        
        private ArrayOfKeyValueOfstringstringKeyValueOfstringstring[] propertyBagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LogonAsUser {
            get {
                return this.logonAsUserField;
            }
            set {
                this.logonAsUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MessageId {
            get {
                return this.messageIdField;
            }
            set {
                this.messageIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string PartitionKey {
            get {
                return this.partitionKeyField;
            }
            set {
                this.partitionKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringstring", Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public ArrayOfKeyValueOfstringstringKeyValueOfstringstring[] PropertyBag {
            get {
                return this.propertyBagField;
            }
            set {
                this.propertyBagField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfstringstringKeyValueOfstringstring {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void sendPaymentJournalCompletedEventHandler(object sender, sendPaymentJournalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendPaymentJournalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendPaymentJournalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591