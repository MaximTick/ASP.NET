﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab06_WinForms.TMAService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TMAService.TMAWebServiceSoap")]
    public interface TMAWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        int Sub(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        int Mul(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSessionValue", ReplyAction="*")]
        int GetSessionValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSessionValue", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetSessionValueAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetSessionValue", ReplyAction="*")]
        void SetSessionValue(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetSessionValue", ReplyAction="*")]
        System.Threading.Tasks.Task SetSessionValueAsync(int value);
        
        // CODEGEN: Контракт генерации сообщений с именем GetHistoryResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetHistory", ReplyAction="*")]
        Lab06_WinForms.TMAService.GetHistoryResponse GetHistory(Lab06_WinForms.TMAService.GetHistoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetHistory", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab06_WinForms.TMAService.GetHistoryResponse> GetHistoryAsync(Lab06_WinForms.TMAService.GetHistoryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetHistoryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetHistory", Namespace="http://tempuri.org/", Order=0)]
        public Lab06_WinForms.TMAService.GetHistoryRequestBody Body;
        
        public GetHistoryRequest() {
        }
        
        public GetHistoryRequest(Lab06_WinForms.TMAService.GetHistoryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetHistoryRequestBody {
        
        public GetHistoryRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetHistoryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetHistoryResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab06_WinForms.TMAService.GetHistoryResponseBody Body;
        
        public GetHistoryResponse() {
        }
        
        public GetHistoryResponse(Lab06_WinForms.TMAService.GetHistoryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetHistoryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetHistoryResult;
        
        public GetHistoryResponseBody() {
        }
        
        public GetHistoryResponseBody(string GetHistoryResult) {
            this.GetHistoryResult = GetHistoryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TMAWebServiceSoapChannel : Lab06_WinForms.TMAService.TMAWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TMAWebServiceSoapClient : System.ServiceModel.ClientBase<Lab06_WinForms.TMAService.TMAWebServiceSoap>, Lab06_WinForms.TMAService.TMAWebServiceSoap {
        
        public TMAWebServiceSoapClient() {
        }
        
        public TMAWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TMAWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TMAWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TMAWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public int Sub(int x, int y) {
            return base.Channel.Sub(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int x, int y) {
            return base.Channel.SubAsync(x, y);
        }
        
        public int Mul(int x, int y) {
            return base.Channel.Mul(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int x, int y) {
            return base.Channel.MulAsync(x, y);
        }
        
        public int GetSessionValue() {
            return base.Channel.GetSessionValue();
        }
        
        public System.Threading.Tasks.Task<int> GetSessionValueAsync() {
            return base.Channel.GetSessionValueAsync();
        }
        
        public void SetSessionValue(int value) {
            base.Channel.SetSessionValue(value);
        }
        
        public System.Threading.Tasks.Task SetSessionValueAsync(int value) {
            return base.Channel.SetSessionValueAsync(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab06_WinForms.TMAService.GetHistoryResponse Lab06_WinForms.TMAService.TMAWebServiceSoap.GetHistory(Lab06_WinForms.TMAService.GetHistoryRequest request) {
            return base.Channel.GetHistory(request);
        }
        
        public string GetHistory() {
            Lab06_WinForms.TMAService.GetHistoryRequest inValue = new Lab06_WinForms.TMAService.GetHistoryRequest();
            inValue.Body = new Lab06_WinForms.TMAService.GetHistoryRequestBody();
            Lab06_WinForms.TMAService.GetHistoryResponse retVal = ((Lab06_WinForms.TMAService.TMAWebServiceSoap)(this)).GetHistory(inValue);
            return retVal.Body.GetHistoryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab06_WinForms.TMAService.GetHistoryResponse> Lab06_WinForms.TMAService.TMAWebServiceSoap.GetHistoryAsync(Lab06_WinForms.TMAService.GetHistoryRequest request) {
            return base.Channel.GetHistoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab06_WinForms.TMAService.GetHistoryResponse> GetHistoryAsync() {
            Lab06_WinForms.TMAService.GetHistoryRequest inValue = new Lab06_WinForms.TMAService.GetHistoryRequest();
            inValue.Body = new Lab06_WinForms.TMAService.GetHistoryRequestBody();
            return ((Lab06_WinForms.TMAService.TMAWebServiceSoap)(this)).GetHistoryAsync(inValue);
        }
    }
}
