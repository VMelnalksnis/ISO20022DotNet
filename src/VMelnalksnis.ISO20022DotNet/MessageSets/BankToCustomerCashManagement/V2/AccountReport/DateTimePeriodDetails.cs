using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

using NodaTime;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("DateTimePeriodDetails", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record DateTimePeriodDetails
	{
		[Required]
		[XmlElement("FrDtTm")]
		public Instant FrDtTm { get; init; }

		[Required]
		[XmlElement("ToDtTm")]
		public Instant ToDtTm { get; init; }
	}
}
