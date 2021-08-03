using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TaxRecordDetails1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TaxRecordDetails1
	{
		[XmlElement("Prd")]
		public TaxPeriod1 Prd { get; init; }

		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; init; }
	}
}
