﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utilizator.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name Name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertDB", ReplyAction="*")]
        Utilizator.ServiceReference1.insertDBResponse insertDB(Utilizator.ServiceReference1.insertDBRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertDB", ReplyAction="*")]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.insertDBResponse> insertDBAsync(Utilizator.ServiceReference1.insertDBRequest request);
        
        // CODEGEN: Generating message contract since element name Shop from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/selectdb", ReplyAction="*")]
        Utilizator.ServiceReference1.selectdbResponse selectdb(Utilizator.ServiceReference1.selectdbRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/selectdb", ReplyAction="*")]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.selectdbResponse> selectdbAsync(Utilizator.ServiceReference1.selectdbRequest request);
        
        // CODEGEN: Generating message contract since element name Product from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteDB", ReplyAction="*")]
        Utilizator.ServiceReference1.deleteDBResponse deleteDB(Utilizator.ServiceReference1.deleteDBRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteDB", ReplyAction="*")]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.deleteDBResponse> deleteDBAsync(Utilizator.ServiceReference1.deleteDBRequest request);
        
        // CODEGEN: Generating message contract since element name Product from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateDB", ReplyAction="*")]
        Utilizator.ServiceReference1.updateDBResponse updateDB(Utilizator.ServiceReference1.updateDBRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateDB", ReplyAction="*")]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.updateDBResponse> updateDBAsync(Utilizator.ServiceReference1.updateDBRequest request);
        
        // CODEGEN: Generating message contract since element name Shop from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/selectAnItem", ReplyAction="*")]
        Utilizator.ServiceReference1.selectAnItemResponse selectAnItem(Utilizator.ServiceReference1.selectAnItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/selectAnItem", ReplyAction="*")]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.selectAnItemResponse> selectAnItemAsync(Utilizator.ServiceReference1.selectAnItemRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertDBRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertDB", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.insertDBRequestBody Body;
        
        public insertDBRequest() {
        }
        
        public insertDBRequest(Utilizator.ServiceReference1.insertDBRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertDBRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int No;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public float Price;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Shop;
        
        public insertDBRequestBody() {
        }
        
        public insertDBRequestBody(int id, string Name, int No, float Price, string Shop) {
            this.id = id;
            this.Name = Name;
            this.No = No;
            this.Price = Price;
            this.Shop = Shop;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertDBResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertDBResponse", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.insertDBResponseBody Body;
        
        public insertDBResponse() {
        }
        
        public insertDBResponse(Utilizator.ServiceReference1.insertDBResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertDBResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool insertDBResult;
        
        public insertDBResponseBody() {
        }
        
        public insertDBResponseBody(bool insertDBResult) {
            this.insertDBResult = insertDBResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectdbRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectdb", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.selectdbRequestBody Body;
        
        public selectdbRequest() {
        }
        
        public selectdbRequest(Utilizator.ServiceReference1.selectdbRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class selectdbRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Shop;
        
        public selectdbRequestBody() {
        }
        
        public selectdbRequestBody(string Shop) {
            this.Shop = Shop;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectdbResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectdbResponse", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.selectdbResponseBody Body;
        
        public selectdbResponse() {
        }
        
        public selectdbResponse(Utilizator.ServiceReference1.selectdbResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class selectdbResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Utilizator.ServiceReference1.ArrayOfString selectdbResult;
        
        public selectdbResponseBody() {
        }
        
        public selectdbResponseBody(Utilizator.ServiceReference1.ArrayOfString selectdbResult) {
            this.selectdbResult = selectdbResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteDBRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteDB", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.deleteDBRequestBody Body;
        
        public deleteDBRequest() {
        }
        
        public deleteDBRequest(Utilizator.ServiceReference1.deleteDBRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deleteDBRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Product;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Shop;
        
        public deleteDBRequestBody() {
        }
        
        public deleteDBRequestBody(string Product, string Shop) {
            this.Product = Product;
            this.Shop = Shop;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteDBResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteDBResponse", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.deleteDBResponseBody Body;
        
        public deleteDBResponse() {
        }
        
        public deleteDBResponse(Utilizator.ServiceReference1.deleteDBResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class deleteDBResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool deleteDBResult;
        
        public deleteDBResponseBody() {
        }
        
        public deleteDBResponseBody(bool deleteDBResult) {
            this.deleteDBResult = deleteDBResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateDBRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateDB", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.updateDBRequestBody Body;
        
        public updateDBRequest() {
        }
        
        public updateDBRequest(Utilizator.ServiceReference1.updateDBRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateDBRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Product;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Shop;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int nId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string nName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int nNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public float nPrice;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string nShop;
        
        public updateDBRequestBody() {
        }
        
        public updateDBRequestBody(string Product, string Shop, int nId, string nName, int nNo, float nPrice, string nShop) {
            this.Product = Product;
            this.Shop = Shop;
            this.nId = nId;
            this.nName = nName;
            this.nNo = nNo;
            this.nPrice = nPrice;
            this.nShop = nShop;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateDBResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateDBResponse", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.updateDBResponseBody Body;
        
        public updateDBResponse() {
        }
        
        public updateDBResponse(Utilizator.ServiceReference1.updateDBResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateDBResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool updateDBResult;
        
        public updateDBResponseBody() {
        }
        
        public updateDBResponseBody(bool updateDBResult) {
            this.updateDBResult = updateDBResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectAnItemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectAnItem", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.selectAnItemRequestBody Body;
        
        public selectAnItemRequest() {
        }
        
        public selectAnItemRequest(Utilizator.ServiceReference1.selectAnItemRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class selectAnItemRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Shop;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name;
        
        public selectAnItemRequestBody() {
        }
        
        public selectAnItemRequestBody(string Shop, string Name) {
            this.Shop = Shop;
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectAnItemResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectAnItemResponse", Namespace="http://tempuri.org/", Order=0)]
        public Utilizator.ServiceReference1.selectAnItemResponseBody Body;
        
        public selectAnItemResponse() {
        }
        
        public selectAnItemResponse(Utilizator.ServiceReference1.selectAnItemResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class selectAnItemResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Utilizator.ServiceReference1.ArrayOfString selectAnItemResult;
        
        public selectAnItemResponseBody() {
        }
        
        public selectAnItemResponseBody(Utilizator.ServiceReference1.ArrayOfString selectAnItemResult) {
            this.selectAnItemResult = selectAnItemResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Utilizator.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Utilizator.ServiceReference1.WebService1Soap>, Utilizator.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Utilizator.ServiceReference1.insertDBResponse Utilizator.ServiceReference1.WebService1Soap.insertDB(Utilizator.ServiceReference1.insertDBRequest request) {
            return base.Channel.insertDB(request);
        }
        
        public bool insertDB(int id, string Name, int No, float Price, string Shop) {
            Utilizator.ServiceReference1.insertDBRequest inValue = new Utilizator.ServiceReference1.insertDBRequest();
            inValue.Body = new Utilizator.ServiceReference1.insertDBRequestBody();
            inValue.Body.id = id;
            inValue.Body.Name = Name;
            inValue.Body.No = No;
            inValue.Body.Price = Price;
            inValue.Body.Shop = Shop;
            Utilizator.ServiceReference1.insertDBResponse retVal = ((Utilizator.ServiceReference1.WebService1Soap)(this)).insertDB(inValue);
            return retVal.Body.insertDBResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.insertDBResponse> Utilizator.ServiceReference1.WebService1Soap.insertDBAsync(Utilizator.ServiceReference1.insertDBRequest request) {
            return base.Channel.insertDBAsync(request);
        }
        
        public System.Threading.Tasks.Task<Utilizator.ServiceReference1.insertDBResponse> insertDBAsync(int id, string Name, int No, float Price, string Shop) {
            Utilizator.ServiceReference1.insertDBRequest inValue = new Utilizator.ServiceReference1.insertDBRequest();
            inValue.Body = new Utilizator.ServiceReference1.insertDBRequestBody();
            inValue.Body.id = id;
            inValue.Body.Name = Name;
            inValue.Body.No = No;
            inValue.Body.Price = Price;
            inValue.Body.Shop = Shop;
            return ((Utilizator.ServiceReference1.WebService1Soap)(this)).insertDBAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Utilizator.ServiceReference1.selectdbResponse Utilizator.ServiceReference1.WebService1Soap.selectdb(Utilizator.ServiceReference1.selectdbRequest request) {
            return base.Channel.selectdb(request);
        }
        
        public Utilizator.ServiceReference1.ArrayOfString selectdb(string Shop) {
            Utilizator.ServiceReference1.selectdbRequest inValue = new Utilizator.ServiceReference1.selectdbRequest();
            inValue.Body = new Utilizator.ServiceReference1.selectdbRequestBody();
            inValue.Body.Shop = Shop;
            Utilizator.ServiceReference1.selectdbResponse retVal = ((Utilizator.ServiceReference1.WebService1Soap)(this)).selectdb(inValue);
            return retVal.Body.selectdbResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.selectdbResponse> Utilizator.ServiceReference1.WebService1Soap.selectdbAsync(Utilizator.ServiceReference1.selectdbRequest request) {
            return base.Channel.selectdbAsync(request);
        }
        
        public System.Threading.Tasks.Task<Utilizator.ServiceReference1.selectdbResponse> selectdbAsync(string Shop) {
            Utilizator.ServiceReference1.selectdbRequest inValue = new Utilizator.ServiceReference1.selectdbRequest();
            inValue.Body = new Utilizator.ServiceReference1.selectdbRequestBody();
            inValue.Body.Shop = Shop;
            return ((Utilizator.ServiceReference1.WebService1Soap)(this)).selectdbAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Utilizator.ServiceReference1.deleteDBResponse Utilizator.ServiceReference1.WebService1Soap.deleteDB(Utilizator.ServiceReference1.deleteDBRequest request) {
            return base.Channel.deleteDB(request);
        }
        
        public bool deleteDB(string Product, string Shop) {
            Utilizator.ServiceReference1.deleteDBRequest inValue = new Utilizator.ServiceReference1.deleteDBRequest();
            inValue.Body = new Utilizator.ServiceReference1.deleteDBRequestBody();
            inValue.Body.Product = Product;
            inValue.Body.Shop = Shop;
            Utilizator.ServiceReference1.deleteDBResponse retVal = ((Utilizator.ServiceReference1.WebService1Soap)(this)).deleteDB(inValue);
            return retVal.Body.deleteDBResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.deleteDBResponse> Utilizator.ServiceReference1.WebService1Soap.deleteDBAsync(Utilizator.ServiceReference1.deleteDBRequest request) {
            return base.Channel.deleteDBAsync(request);
        }
        
        public System.Threading.Tasks.Task<Utilizator.ServiceReference1.deleteDBResponse> deleteDBAsync(string Product, string Shop) {
            Utilizator.ServiceReference1.deleteDBRequest inValue = new Utilizator.ServiceReference1.deleteDBRequest();
            inValue.Body = new Utilizator.ServiceReference1.deleteDBRequestBody();
            inValue.Body.Product = Product;
            inValue.Body.Shop = Shop;
            return ((Utilizator.ServiceReference1.WebService1Soap)(this)).deleteDBAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Utilizator.ServiceReference1.updateDBResponse Utilizator.ServiceReference1.WebService1Soap.updateDB(Utilizator.ServiceReference1.updateDBRequest request) {
            return base.Channel.updateDB(request);
        }
        
        public bool updateDB(string Product, string Shop, int nId, string nName, int nNo, float nPrice, string nShop) {
            Utilizator.ServiceReference1.updateDBRequest inValue = new Utilizator.ServiceReference1.updateDBRequest();
            inValue.Body = new Utilizator.ServiceReference1.updateDBRequestBody();
            inValue.Body.Product = Product;
            inValue.Body.Shop = Shop;
            inValue.Body.nId = nId;
            inValue.Body.nName = nName;
            inValue.Body.nNo = nNo;
            inValue.Body.nPrice = nPrice;
            inValue.Body.nShop = nShop;
            Utilizator.ServiceReference1.updateDBResponse retVal = ((Utilizator.ServiceReference1.WebService1Soap)(this)).updateDB(inValue);
            return retVal.Body.updateDBResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.updateDBResponse> Utilizator.ServiceReference1.WebService1Soap.updateDBAsync(Utilizator.ServiceReference1.updateDBRequest request) {
            return base.Channel.updateDBAsync(request);
        }
        
        public System.Threading.Tasks.Task<Utilizator.ServiceReference1.updateDBResponse> updateDBAsync(string Product, string Shop, int nId, string nName, int nNo, float nPrice, string nShop) {
            Utilizator.ServiceReference1.updateDBRequest inValue = new Utilizator.ServiceReference1.updateDBRequest();
            inValue.Body = new Utilizator.ServiceReference1.updateDBRequestBody();
            inValue.Body.Product = Product;
            inValue.Body.Shop = Shop;
            inValue.Body.nId = nId;
            inValue.Body.nName = nName;
            inValue.Body.nNo = nNo;
            inValue.Body.nPrice = nPrice;
            inValue.Body.nShop = nShop;
            return ((Utilizator.ServiceReference1.WebService1Soap)(this)).updateDBAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Utilizator.ServiceReference1.selectAnItemResponse Utilizator.ServiceReference1.WebService1Soap.selectAnItem(Utilizator.ServiceReference1.selectAnItemRequest request) {
            return base.Channel.selectAnItem(request);
        }
        
        public Utilizator.ServiceReference1.ArrayOfString selectAnItem(string Shop, string Name) {
            Utilizator.ServiceReference1.selectAnItemRequest inValue = new Utilizator.ServiceReference1.selectAnItemRequest();
            inValue.Body = new Utilizator.ServiceReference1.selectAnItemRequestBody();
            inValue.Body.Shop = Shop;
            inValue.Body.Name = Name;
            Utilizator.ServiceReference1.selectAnItemResponse retVal = ((Utilizator.ServiceReference1.WebService1Soap)(this)).selectAnItem(inValue);
            return retVal.Body.selectAnItemResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Utilizator.ServiceReference1.selectAnItemResponse> Utilizator.ServiceReference1.WebService1Soap.selectAnItemAsync(Utilizator.ServiceReference1.selectAnItemRequest request) {
            return base.Channel.selectAnItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Utilizator.ServiceReference1.selectAnItemResponse> selectAnItemAsync(string Shop, string Name) {
            Utilizator.ServiceReference1.selectAnItemRequest inValue = new Utilizator.ServiceReference1.selectAnItemRequest();
            inValue.Body = new Utilizator.ServiceReference1.selectAnItemRequestBody();
            inValue.Body.Shop = Shop;
            inValue.Body.Name = Name;
            return ((Utilizator.ServiceReference1.WebService1Soap)(this)).selectAnItemAsync(inValue);
        }
    }
}