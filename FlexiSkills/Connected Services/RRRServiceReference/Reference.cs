﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRRServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/", ConfigurationName="RRRServiceReference.WebService1Soap")]
    public interface WebService1Soap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://paymentsys.portal.yabatech.edu.ng/Chk_rrr_status", ReplyAction="*")]
        System.Threading.Tasks.Task<RRRServiceReference.Chk_rrr_statusResponse> Chk_rrr_statusAsync(RRRServiceReference.Chk_rrr_statusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://paymentsys.portal.yabatech.edu.ng/geninvAsync", ReplyAction="*")]
        System.Threading.Tasks.Task<RRRServiceReference.geninvAsyncResponse> geninvAsyncAsync(RRRServiceReference.geninvAsyncRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://paymentsys.portal.yabatech.edu.ng/process_rrr", ReplyAction="*")]
        System.Threading.Tasks.Task<RRRServiceReference.process_rrrResponse> process_rrrAsync(RRRServiceReference.process_rrrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://paymentsys.portal.yabatech.edu.ng/Chk_rrr_status_addtransactions", ReplyAction="*")]
        System.Threading.Tasks.Task<RRRServiceReference.Chk_rrr_status_addtransactionsResponse> Chk_rrr_status_addtransactionsAsync(RRRServiceReference.Chk_rrr_status_addtransactionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://paymentsys.portal.yabatech.edu.ng/get_rrr_for_application", ReplyAction="*")]
        System.Threading.Tasks.Task<RRRServiceReference.get_rrr_for_applicationResponse> get_rrr_for_applicationAsync(RRRServiceReference.get_rrr_for_applicationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Chk_rrr_statusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Chk_rrr_status", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.Chk_rrr_statusRequestBody Body;
        
        public Chk_rrr_statusRequest()
        {
        }
        
        public Chk_rrr_statusRequest(RRRServiceReference.Chk_rrr_statusRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class Chk_rrr_statusRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rrr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string token;
        
        public Chk_rrr_statusRequestBody()
        {
        }
        
        public Chk_rrr_statusRequestBody(string rrr, string user, string token)
        {
            this.rrr = rrr;
            this.user = user;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Chk_rrr_statusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Chk_rrr_statusResponse", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.Chk_rrr_statusResponseBody Body;
        
        public Chk_rrr_statusResponse()
        {
        }
        
        public Chk_rrr_statusResponse(RRRServiceReference.Chk_rrr_statusResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class Chk_rrr_statusResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Chk_rrr_statusResult;
        
        public Chk_rrr_statusResponseBody()
        {
        }
        
        public Chk_rrr_statusResponseBody(string Chk_rrr_statusResult)
        {
            this.Chk_rrr_statusResult = Chk_rrr_statusResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class geninvAsyncRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="geninvAsync", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.geninvAsyncRequestBody Body;
        
        public geninvAsyncRequest()
        {
        }
        
        public geninvAsyncRequest(RRRServiceReference.geninvAsyncRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class geninvAsyncRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string phone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string matno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string paymentid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string session;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string token;
        
        public geninvAsyncRequestBody()
        {
        }
        
        public geninvAsyncRequestBody(string amount, string name, string phone, string email, string description, string matno, string paymentid, string session, string user, string token)
        {
            this.amount = amount;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.description = description;
            this.matno = matno;
            this.paymentid = paymentid;
            this.session = session;
            this.user = user;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class geninvAsyncResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="geninvAsyncResponse", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.geninvAsyncResponseBody Body;
        
        public geninvAsyncResponse()
        {
        }
        
        public geninvAsyncResponse(RRRServiceReference.geninvAsyncResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class geninvAsyncResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string geninvAsyncResult;
        
        public geninvAsyncResponseBody()
        {
        }
        
        public geninvAsyncResponseBody(string geninvAsyncResult)
        {
            this.geninvAsyncResult = geninvAsyncResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class process_rrrRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="process_rrr", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.process_rrrRequestBody Body;
        
        public process_rrrRequest()
        {
        }
        
        public process_rrrRequest(RRRServiceReference.process_rrrRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class process_rrrRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rrr;
        
        public process_rrrRequestBody()
        {
        }
        
        public process_rrrRequestBody(string rrr)
        {
            this.rrr = rrr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class process_rrrResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="process_rrrResponse", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.process_rrrResponseBody Body;
        
        public process_rrrResponse()
        {
        }
        
        public process_rrrResponse(RRRServiceReference.process_rrrResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class process_rrrResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string process_rrrResult;
        
        public process_rrrResponseBody()
        {
        }
        
        public process_rrrResponseBody(string process_rrrResult)
        {
            this.process_rrrResult = process_rrrResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Chk_rrr_status_addtransactionsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Chk_rrr_status_addtransactions", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.Chk_rrr_status_addtransactionsRequestBody Body;
        
        public Chk_rrr_status_addtransactionsRequest()
        {
        }
        
        public Chk_rrr_status_addtransactionsRequest(RRRServiceReference.Chk_rrr_status_addtransactionsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class Chk_rrr_status_addtransactionsRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rrr;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string token;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int paymentid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string matricnum;
        
        public Chk_rrr_status_addtransactionsRequestBody()
        {
        }
        
        public Chk_rrr_status_addtransactionsRequestBody(string rrr, string user, string token, int paymentid, string matricnum)
        {
            this.rrr = rrr;
            this.user = user;
            this.token = token;
            this.paymentid = paymentid;
            this.matricnum = matricnum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Chk_rrr_status_addtransactionsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Chk_rrr_status_addtransactionsResponse", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.Chk_rrr_status_addtransactionsResponseBody Body;
        
        public Chk_rrr_status_addtransactionsResponse()
        {
        }
        
        public Chk_rrr_status_addtransactionsResponse(RRRServiceReference.Chk_rrr_status_addtransactionsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class Chk_rrr_status_addtransactionsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Chk_rrr_status_addtransactionsResult;
        
        public Chk_rrr_status_addtransactionsResponseBody()
        {
        }
        
        public Chk_rrr_status_addtransactionsResponseBody(string Chk_rrr_status_addtransactionsResult)
        {
            this.Chk_rrr_status_addtransactionsResult = Chk_rrr_status_addtransactionsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_rrr_for_applicationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_rrr_for_application", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.get_rrr_for_applicationRequestBody Body;
        
        public get_rrr_for_applicationRequest()
        {
        }
        
        public get_rrr_for_applicationRequest(RRRServiceReference.get_rrr_for_applicationRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class get_rrr_for_applicationRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string surname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string firstname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string othername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string progidn;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string phone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string dob;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string sex;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string token;
        
        public get_rrr_for_applicationRequestBody()
        {
        }
        
        public get_rrr_for_applicationRequestBody(string surname, string firstname, string othername, string progidn, string email, string phone, string dob, string sex, string user, string token)
        {
            this.surname = surname;
            this.firstname = firstname;
            this.othername = othername;
            this.progidn = progidn;
            this.email = email;
            this.phone = phone;
            this.dob = dob;
            this.sex = sex;
            this.user = user;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_rrr_for_applicationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_rrr_for_applicationResponse", Namespace="http://paymentsys.portal.yabatech.edu.ng/", Order=0)]
        public RRRServiceReference.get_rrr_for_applicationResponseBody Body;
        
        public get_rrr_for_applicationResponse()
        {
        }
        
        public get_rrr_for_applicationResponse(RRRServiceReference.get_rrr_for_applicationResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://paymentsys.portal.yabatech.edu.ng/")]
    public partial class get_rrr_for_applicationResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string get_rrr_for_applicationResult;
        
        public get_rrr_for_applicationResponseBody()
        {
        }
        
        public get_rrr_for_applicationResponseBody(string get_rrr_for_applicationResult)
        {
            this.get_rrr_for_applicationResult = get_rrr_for_applicationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface WebService1SoapChannel : RRRServiceReference.WebService1Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<RRRServiceReference.WebService1Soap>, RRRServiceReference.WebService1Soap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebService1SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), WebService1SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebService1SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebService1SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RRRServiceReference.Chk_rrr_statusResponse> RRRServiceReference.WebService1Soap.Chk_rrr_statusAsync(RRRServiceReference.Chk_rrr_statusRequest request)
        {
            return base.Channel.Chk_rrr_statusAsync(request);
        }
        
        public System.Threading.Tasks.Task<RRRServiceReference.Chk_rrr_statusResponse> Chk_rrr_statusAsync(string rrr, string user, string token)
        {
            RRRServiceReference.Chk_rrr_statusRequest inValue = new RRRServiceReference.Chk_rrr_statusRequest();
            inValue.Body = new RRRServiceReference.Chk_rrr_statusRequestBody();
            inValue.Body.rrr = rrr;
            inValue.Body.user = user;
            inValue.Body.token = token;
            return ((RRRServiceReference.WebService1Soap)(this)).Chk_rrr_statusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RRRServiceReference.geninvAsyncResponse> RRRServiceReference.WebService1Soap.geninvAsyncAsync(RRRServiceReference.geninvAsyncRequest request)
        {
            return base.Channel.geninvAsyncAsync(request);
        }
        
        public System.Threading.Tasks.Task<RRRServiceReference.geninvAsyncResponse> geninvAsyncAsync(string amount, string name, string phone, string email, string description, string matno, string paymentid, string session, string user, string token)
        {
            RRRServiceReference.geninvAsyncRequest inValue = new RRRServiceReference.geninvAsyncRequest();
            inValue.Body = new RRRServiceReference.geninvAsyncRequestBody();
            inValue.Body.amount = amount;
            inValue.Body.name = name;
            inValue.Body.phone = phone;
            inValue.Body.email = email;
            inValue.Body.description = description;
            inValue.Body.matno = matno;
            inValue.Body.paymentid = paymentid;
            inValue.Body.session = session;
            inValue.Body.user = user;
            inValue.Body.token = token;
            return ((RRRServiceReference.WebService1Soap)(this)).geninvAsyncAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RRRServiceReference.process_rrrResponse> RRRServiceReference.WebService1Soap.process_rrrAsync(RRRServiceReference.process_rrrRequest request)
        {
            return base.Channel.process_rrrAsync(request);
        }
        
        public System.Threading.Tasks.Task<RRRServiceReference.process_rrrResponse> process_rrrAsync(string rrr)
        {
            RRRServiceReference.process_rrrRequest inValue = new RRRServiceReference.process_rrrRequest();
            inValue.Body = new RRRServiceReference.process_rrrRequestBody();
            inValue.Body.rrr = rrr;
            return ((RRRServiceReference.WebService1Soap)(this)).process_rrrAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RRRServiceReference.Chk_rrr_status_addtransactionsResponse> RRRServiceReference.WebService1Soap.Chk_rrr_status_addtransactionsAsync(RRRServiceReference.Chk_rrr_status_addtransactionsRequest request)
        {
            return base.Channel.Chk_rrr_status_addtransactionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<RRRServiceReference.Chk_rrr_status_addtransactionsResponse> Chk_rrr_status_addtransactionsAsync(string rrr, string user, string token, int paymentid, string matricnum)
        {
            RRRServiceReference.Chk_rrr_status_addtransactionsRequest inValue = new RRRServiceReference.Chk_rrr_status_addtransactionsRequest();
            inValue.Body = new RRRServiceReference.Chk_rrr_status_addtransactionsRequestBody();
            inValue.Body.rrr = rrr;
            inValue.Body.user = user;
            inValue.Body.token = token;
            inValue.Body.paymentid = paymentid;
            inValue.Body.matricnum = matricnum;
            return ((RRRServiceReference.WebService1Soap)(this)).Chk_rrr_status_addtransactionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RRRServiceReference.get_rrr_for_applicationResponse> RRRServiceReference.WebService1Soap.get_rrr_for_applicationAsync(RRRServiceReference.get_rrr_for_applicationRequest request)
        {
            return base.Channel.get_rrr_for_applicationAsync(request);
        }
        
        public System.Threading.Tasks.Task<RRRServiceReference.get_rrr_for_applicationResponse> get_rrr_for_applicationAsync(string surname, string firstname, string othername, string progidn, string email, string phone, string dob, string sex, string user, string token)
        {
            RRRServiceReference.get_rrr_for_applicationRequest inValue = new RRRServiceReference.get_rrr_for_applicationRequest();
            inValue.Body = new RRRServiceReference.get_rrr_for_applicationRequestBody();
            inValue.Body.surname = surname;
            inValue.Body.firstname = firstname;
            inValue.Body.othername = othername;
            inValue.Body.progidn = progidn;
            inValue.Body.email = email;
            inValue.Body.phone = phone;
            inValue.Body.dob = dob;
            inValue.Body.sex = sex;
            inValue.Body.user = user;
            inValue.Body.token = token;
            return ((RRRServiceReference.WebService1Soap)(this)).get_rrr_for_applicationAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://portal.yabatech.edu.ng/paymentsys/webservice1.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WebService1Soap12))
            {
                return new System.ServiceModel.EndpointAddress("https://portal.yabatech.edu.ng/paymentsys/webservice1.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WebService1Soap,
            
            WebService1Soap12,
        }
    }
}
