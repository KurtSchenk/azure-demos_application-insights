﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontEndWCFService.InternalServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InternalServiceReference.IInternalService")]
    public interface IInternalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetData", ReplyAction="http://tempuri.org/IInternalService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetData", ReplyAction="http://tempuri.org/IInternalService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetValueOfPi", ReplyAction="http://tempuri.org/IInternalService/GetValueOfPiResponse")]
        double GetValueOfPi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetValueOfPi", ReplyAction="http://tempuri.org/IInternalService/GetValueOfPiResponse")]
        System.Threading.Tasks.Task<double> GetValueOfPiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetValueOfPi2", ReplyAction="http://tempuri.org/IInternalService/GetValueOfPi2Response")]
        double GetValueOfPi2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetValueOfPi2", ReplyAction="http://tempuri.org/IInternalService/GetValueOfPi2Response")]
        System.Threading.Tasks.Task<double> GetValueOfPi2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetActivityRootId2", ReplyAction="http://tempuri.org/IInternalService/GetActivityRootId2Response")]
        string GetActivityRootId2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalService/GetActivityRootId2", ReplyAction="http://tempuri.org/IInternalService/GetActivityRootId2Response")]
        System.Threading.Tasks.Task<string> GetActivityRootId2Async();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInternalServiceChannel : FrontEndWCFService.InternalServiceReference.IInternalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InternalServiceClient : System.ServiceModel.ClientBase<FrontEndWCFService.InternalServiceReference.IInternalService>, FrontEndWCFService.InternalServiceReference.IInternalService {
        
        public InternalServiceClient() {
        }
        
        public InternalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InternalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InternalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InternalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public double GetValueOfPi() {
            return base.Channel.GetValueOfPi();
        }
        
        public System.Threading.Tasks.Task<double> GetValueOfPiAsync() {
            return base.Channel.GetValueOfPiAsync();
        }
        
        public double GetValueOfPi2() {
            return base.Channel.GetValueOfPi2();
        }
        
        public System.Threading.Tasks.Task<double> GetValueOfPi2Async() {
            return base.Channel.GetValueOfPi2Async();
        }
        
        public string GetActivityRootId2() {
            return base.Channel.GetActivityRootId2();
        }
        
        public System.Threading.Tasks.Task<string> GetActivityRootId2Async() {
            return base.Channel.GetActivityRootId2Async();
        }
    }
}
