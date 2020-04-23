﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErcotTools.ErcotNotificationService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ercot.com/schema/2007-06/nodal/notification")]
    public partial class Fault : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string faultCodeField;
        
        private System.DateTime timestampField;
        
        private bool timestampFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FaultCode {
            get {
                return this.faultCodeField;
            }
            set {
                this.faultCodeField = value;
                this.RaisePropertyChanged("FaultCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("Timestamp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimestampSpecified {
            get {
                return this.timestampFieldSpecified;
            }
            set {
                this.timestampFieldSpecified = value;
                this.RaisePropertyChanged("TimestampSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ercot.com/schema/2007-06/nodal/notification")]
    public partial class NotificationMessageHolderType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Xml.XmlElement Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ercot.com/wsdl/2007-06/nodal/notification", ConfigurationName="ErcotNotificationService.NotificationConsumer")]
    public interface NotificationConsumer {
        
        // CODEGEN: Generating message contract since the operation Notify is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ercot.com/wsdl/2007-06/nodal/notification/NotificationConsumer/NotifyR" +
            "equest", ReplyAction="http://www.ercot.com/wsdl/2007-06/nodal/notification/NotificationConsumer/NotifyR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ErcotTools.ErcotNotificationService.Fault), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="Fault", Namespace="http://www.ercot.com/schema/2007-06/nodal/notification")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ErcotTools.ErcotNotificationService.NotifyResponse Notify(ErcotTools.ErcotNotificationService.NotifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ercot.com/wsdl/2007-06/nodal/notification/NotificationConsumer/NotifyR" +
            "equest", ReplyAction="http://www.ercot.com/wsdl/2007-06/nodal/notification/NotificationConsumer/NotifyR" +
            "esponse")]
        System.Threading.Tasks.Task<ErcotTools.ErcotNotificationService.NotifyResponse> NotifyAsync(ErcotTools.ErcotNotificationService.NotifyRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ercot.com/schema/2007-06/nodal/notification")]
    public partial class Notify : object, System.ComponentModel.INotifyPropertyChanged {
        
        private NotificationMessageHolderType[] notificationMessageField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationMessage", Order=0)]
        public NotificationMessageHolderType[] NotificationMessage {
            get {
                return this.notificationMessageField;
            }
            set {
                this.notificationMessageField = value;
                this.RaisePropertyChanged("NotificationMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ercot.com/schema/2007-06/nodal/notification")]
    public partial class Acknowledge : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string replyCodeField;
        
        private System.DateTime timestampField;
        
        private bool timestampFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ReplyCode {
            get {
                return this.replyCodeField;
            }
            set {
                this.replyCodeField = value;
                this.RaisePropertyChanged("ReplyCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("Timestamp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimestampSpecified {
            get {
                return this.timestampFieldSpecified;
            }
            set {
                this.timestampFieldSpecified = value;
                this.RaisePropertyChanged("TimestampSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotifyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ercot.com/schema/2007-06/nodal/notification", Order=0)]
        public ErcotTools.ErcotNotificationService.Notify Notify;
        
        public NotifyRequest() {
        }
        
        public NotifyRequest(ErcotTools.ErcotNotificationService.Notify Notify) {
            this.Notify = Notify;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotifyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ercot.com/schema/2007-06/nodal/notification", Order=0)]
        public ErcotTools.ErcotNotificationService.Acknowledge Acknowledge;
        
        public NotifyResponse() {
        }
        
        public NotifyResponse(ErcotTools.ErcotNotificationService.Acknowledge Acknowledge) {
            this.Acknowledge = Acknowledge;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NotificationConsumerChannel : ErcotTools.ErcotNotificationService.NotificationConsumer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotificationConsumerClient : System.ServiceModel.ClientBase<ErcotTools.ErcotNotificationService.NotificationConsumer>, ErcotTools.ErcotNotificationService.NotificationConsumer {
        
        public NotificationConsumerClient() {
        }
        
        public NotificationConsumerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NotificationConsumerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationConsumerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationConsumerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ErcotTools.ErcotNotificationService.NotifyResponse ErcotTools.ErcotNotificationService.NotificationConsumer.Notify(ErcotTools.ErcotNotificationService.NotifyRequest request) {
            return base.Channel.Notify(request);
        }
        
        public ErcotTools.ErcotNotificationService.Acknowledge Notify(ErcotTools.ErcotNotificationService.Notify Notify1) {
            ErcotTools.ErcotNotificationService.NotifyRequest inValue = new ErcotTools.ErcotNotificationService.NotifyRequest();
            inValue.Notify = Notify1;
            ErcotTools.ErcotNotificationService.NotifyResponse retVal = ((ErcotTools.ErcotNotificationService.NotificationConsumer)(this)).Notify(inValue);
            return retVal.Acknowledge;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ErcotTools.ErcotNotificationService.NotifyResponse> ErcotTools.ErcotNotificationService.NotificationConsumer.NotifyAsync(ErcotTools.ErcotNotificationService.NotifyRequest request) {
            return base.Channel.NotifyAsync(request);
        }
        
        public System.Threading.Tasks.Task<ErcotTools.ErcotNotificationService.NotifyResponse> NotifyAsync(ErcotTools.ErcotNotificationService.Notify Notify) {
            ErcotTools.ErcotNotificationService.NotifyRequest inValue = new ErcotTools.ErcotNotificationService.NotifyRequest();
            inValue.Notify = Notify;
            return ((ErcotTools.ErcotNotificationService.NotificationConsumer)(this)).NotifyAsync(inValue);
        }
    }
}
