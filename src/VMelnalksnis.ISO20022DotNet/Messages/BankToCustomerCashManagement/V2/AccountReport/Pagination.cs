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
	[XmlType("Pagination", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record Pagination
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [0-9]{1,5}.</para>
		/// </summary>
		[RegularExpression("[0-9]{1,5}")]
		[Required]
		[XmlElement("PgNb")]
		public string PgNb { get; init; }

		[Required]
		[XmlElement("LastPgInd")]
		public bool LastPgInd { get; init; }
	}
}
