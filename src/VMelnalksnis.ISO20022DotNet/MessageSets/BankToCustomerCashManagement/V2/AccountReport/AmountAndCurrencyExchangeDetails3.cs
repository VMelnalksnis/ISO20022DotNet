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
	[XmlType("AmountAndCurrencyExchangeDetails3",
		Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AmountAndCurrencyExchangeDetails3
	{
		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; init; }

		[XmlElement("CcyXchg")]
		public CurrencyExchange5 CcyXchg { get; init; }
	}
}
