using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("BalanceType12", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BalanceType12
	{
		[Required]
		[XmlElement("CdOrPrtry")]
		public BalanceType5Choice CdOrPrtry { get; set; }

		[XmlElement("SubTp")]
		public BalanceSubType1Choice SubTp { get; set; }
	}
}
