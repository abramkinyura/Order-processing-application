﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.0.3705.0.
// 
using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;


/// <remarks/>
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
public class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    /// <remarks/>
    public Service1() {
        this.Url = "http://localhost/MathService/service1.asmx";
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SalesTax", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Single SalesTax(System.Single salesAmount, System.Single fractionalTaxRate) {
        object[] results = this.Invoke("SalesTax", new object[] {
                    salesAmount,
                    fractionalTaxRate});
        return ((System.Single)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSalesTax(System.Single salesAmount, System.Single fractionalTaxRate, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SalesTax", new object[] {
                    salesAmount,
                    fractionalTaxRate}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Single EndSalesTax(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Single)(results[0]));
    }
}
