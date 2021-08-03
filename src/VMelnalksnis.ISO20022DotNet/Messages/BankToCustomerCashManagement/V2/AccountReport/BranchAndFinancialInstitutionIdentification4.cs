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
	[XmlType("BranchAndFinancialInstitutionIdentification4",
		Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BranchAndFinancialInstitutionIdentification4
	{
		[Required]
		[XmlElement("FinInstnId")]
		public FinancialInstitutionIdentification7 FinInstnId { get; init; }

		[XmlElement("BrnchId")]
		public BranchData2 BrnchId { get; init; }
	}
}
