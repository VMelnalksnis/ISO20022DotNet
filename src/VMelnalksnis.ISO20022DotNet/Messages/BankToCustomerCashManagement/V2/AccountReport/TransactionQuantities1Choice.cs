using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TransactionQuantities1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionQuantities1Choice
	{
		[XmlElement("Qty")]
		public FinancialInstrumentQuantityChoice Qty { get; set; }

		[XmlElement("Prtry")]
		public ProprietaryQuantity1 Prtry { get; set; }
	}
}
