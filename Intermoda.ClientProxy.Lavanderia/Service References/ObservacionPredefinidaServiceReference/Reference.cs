﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObservacionPredefinidaBusiness", Namespace="http://schemas.datacontract.org/2004/07/Intermoda.Business.Lavanderia")]
    [System.SerializableAttribute()]
    public partial class ObservacionPredefinidaBusiness : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.OperacionBusiness OperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OperacionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrdenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PosicionField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.OperacionBusiness Operacion {
            get {
                return this.OperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.OperacionField, value) != true)) {
                    this.OperacionField = value;
                    this.RaisePropertyChanged("Operacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OperacionId {
            get {
                return this.OperacionIdField;
            }
            set {
                if ((this.OperacionIdField.Equals(value) != true)) {
                    this.OperacionIdField = value;
                    this.RaisePropertyChanged("OperacionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Orden {
            get {
                return this.OrdenField;
            }
            set {
                if ((this.OrdenField.Equals(value) != true)) {
                    this.OrdenField = value;
                    this.RaisePropertyChanged("Orden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Posicion {
            get {
                return this.PosicionField;
            }
            set {
                if ((this.PosicionField.Equals(value) != true)) {
                    this.PosicionField = value;
                    this.RaisePropertyChanged("Posicion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OperacionBusiness", Namespace="http://schemas.datacontract.org/2004/07/Intermoda.Business.Lavanderia")]
    [System.SerializableAttribute()]
    public partial class OperacionBusiness : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short GrupoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineaProduccionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.OperacionPredefinidaBusiness OperacionPredefinidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short OperacionTipoIdField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short GrupoId {
            get {
                return this.GrupoIdField;
            }
            set {
                if ((this.GrupoIdField.Equals(value) != true)) {
                    this.GrupoIdField = value;
                    this.RaisePropertyChanged("GrupoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Id {
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
        public int LineaProduccionId {
            get {
                return this.LineaProduccionIdField;
            }
            set {
                if ((this.LineaProduccionIdField.Equals(value) != true)) {
                    this.LineaProduccionIdField = value;
                    this.RaisePropertyChanged("LineaProduccionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.OperacionPredefinidaBusiness OperacionPredefinida {
            get {
                return this.OperacionPredefinidaField;
            }
            set {
                if ((object.ReferenceEquals(this.OperacionPredefinidaField, value) != true)) {
                    this.OperacionPredefinidaField = value;
                    this.RaisePropertyChanged("OperacionPredefinida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short OperacionTipoId {
            get {
                return this.OperacionTipoIdField;
            }
            set {
                if ((this.OperacionTipoIdField.Equals(value) != true)) {
                    this.OperacionTipoIdField = value;
                    this.RaisePropertyChanged("OperacionTipoId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OperacionPredefinidaBusiness", Namespace="http://schemas.datacontract.org/2004/07/Intermoda.Business.Lavanderia")]
    [System.SerializableAttribute()]
    public partial class OperacionPredefinidaBusiness : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.OperacionBusiness OperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OperacionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RelacionBanoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SecuenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemperaturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TiempoMaximoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TiempoMinimoField;
        
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
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.OperacionBusiness Operacion {
            get {
                return this.OperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.OperacionField, value) != true)) {
                    this.OperacionField = value;
                    this.RaisePropertyChanged("Operacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OperacionId {
            get {
                return this.OperacionIdField;
            }
            set {
                if ((this.OperacionIdField.Equals(value) != true)) {
                    this.OperacionIdField = value;
                    this.RaisePropertyChanged("OperacionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ph {
            get {
                return this.PhField;
            }
            set {
                if ((object.ReferenceEquals(this.PhField, value) != true)) {
                    this.PhField = value;
                    this.RaisePropertyChanged("Ph");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RelacionBano {
            get {
                return this.RelacionBanoField;
            }
            set {
                if ((this.RelacionBanoField.Equals(value) != true)) {
                    this.RelacionBanoField = value;
                    this.RaisePropertyChanged("RelacionBano");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Secuencia {
            get {
                return this.SecuenciaField;
            }
            set {
                if ((this.SecuenciaField.Equals(value) != true)) {
                    this.SecuenciaField = value;
                    this.RaisePropertyChanged("Secuencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Temperatura {
            get {
                return this.TemperaturaField;
            }
            set {
                if ((this.TemperaturaField.Equals(value) != true)) {
                    this.TemperaturaField = value;
                    this.RaisePropertyChanged("Temperatura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TiempoMaximo {
            get {
                return this.TiempoMaximoField;
            }
            set {
                if ((this.TiempoMaximoField.Equals(value) != true)) {
                    this.TiempoMaximoField = value;
                    this.RaisePropertyChanged("TiempoMaximo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TiempoMinimo {
            get {
                return this.TiempoMinimoField;
            }
            set {
                if ((this.TiempoMinimoField.Equals(value) != true)) {
                    this.TiempoMinimoField = value;
                    this.RaisePropertyChanged("TiempoMinimo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ObservacionPredefinidaServiceReference.IObservacionPredefinida")]
    public interface IObservacionPredefinida {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/Update", ReplyAction="http://tempuri.org/IObservacionPredefinida/UpdateResponse")]
        Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness Update(Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness observacionPredefinida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/Update", ReplyAction="http://tempuri.org/IObservacionPredefinida/UpdateResponse")]
        System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness> UpdateAsync(Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness observacionPredefinida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/Delete", ReplyAction="http://tempuri.org/IObservacionPredefinida/DeleteResponse")]
        void Delete(int observacionPredefinidaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/Delete", ReplyAction="http://tempuri.org/IObservacionPredefinida/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int observacionPredefinidaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/Get", ReplyAction="http://tempuri.org/IObservacionPredefinida/GetResponse")]
        Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness Get(int observacionPredefinidaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/Get", ReplyAction="http://tempuri.org/IObservacionPredefinida/GetResponse")]
        System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness> GetAsync(int observacionPredefinidaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/GetAll", ReplyAction="http://tempuri.org/IObservacionPredefinida/GetAllResponse")]
        Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/GetAll", ReplyAction="http://tempuri.org/IObservacionPredefinida/GetAllResponse")]
        System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/GetByOperacion", ReplyAction="http://tempuri.org/IObservacionPredefinida/GetByOperacionResponse")]
        Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[] GetByOperacion(int operacionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObservacionPredefinida/GetByOperacion", ReplyAction="http://tempuri.org/IObservacionPredefinida/GetByOperacionResponse")]
        System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[]> GetByOperacionAsync(int operacionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IObservacionPredefinidaChannel : Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.IObservacionPredefinida, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ObservacionPredefinidaClient : System.ServiceModel.ClientBase<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.IObservacionPredefinida>, Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.IObservacionPredefinida {
        
        public ObservacionPredefinidaClient() {
        }
        
        public ObservacionPredefinidaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ObservacionPredefinidaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ObservacionPredefinidaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ObservacionPredefinidaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness Update(Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness observacionPredefinida) {
            return base.Channel.Update(observacionPredefinida);
        }
        
        public System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness> UpdateAsync(Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness observacionPredefinida) {
            return base.Channel.UpdateAsync(observacionPredefinida);
        }
        
        public void Delete(int observacionPredefinidaId) {
            base.Channel.Delete(observacionPredefinidaId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int observacionPredefinidaId) {
            return base.Channel.DeleteAsync(observacionPredefinidaId);
        }
        
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness Get(int observacionPredefinidaId) {
            return base.Channel.Get(observacionPredefinidaId);
        }
        
        public System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness> GetAsync(int observacionPredefinidaId) {
            return base.Channel.GetAsync(observacionPredefinidaId);
        }
        
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[] GetByOperacion(int operacionId) {
            return base.Channel.GetByOperacion(operacionId);
        }
        
        public System.Threading.Tasks.Task<Intermoda.ClientProxy.Lavanderia.ObservacionPredefinidaServiceReference.ObservacionPredefinidaBusiness[]> GetByOperacionAsync(int operacionId) {
            return base.Channel.GetByOperacionAsync(operacionId);
        }
    }
}
