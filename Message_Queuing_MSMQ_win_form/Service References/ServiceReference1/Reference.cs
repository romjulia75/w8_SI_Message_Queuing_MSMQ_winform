﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Message_Queuing_MSMQ_win_form.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.webserviceX.NET/", ConfigurationName="ServiceReference1.StockQuoteSoap")]
    public interface StockQuoteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/GetQuote", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetQuote(string symbol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.webserviceX.NET/GetQuote", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetQuoteAsync(string symbol);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StockQuoteSoapChannel : Message_Queuing_MSMQ_win_form.ServiceReference1.StockQuoteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockQuoteSoapClient : System.ServiceModel.ClientBase<Message_Queuing_MSMQ_win_form.ServiceReference1.StockQuoteSoap>, Message_Queuing_MSMQ_win_form.ServiceReference1.StockQuoteSoap {
        
        public StockQuoteSoapClient() {
        }
        
        public StockQuoteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockQuoteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetQuote(string symbol) {
            return base.Channel.GetQuote(symbol);
        }
        
        public System.Threading.Tasks.Task<string> GetQuoteAsync(string symbol) {
            return base.Channel.GetQuoteAsync(symbol);
        }
    }
}
