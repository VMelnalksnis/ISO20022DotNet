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
	[XmlType("PartyIdentification32", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record PartyIdentification32
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("Nm")]
		public string Nm { get; init; }

		[XmlElement("PstlAdr")]
		public PostalAddress6 PstlAdr { get; init; }

		[XmlElement("Id")]
		public Party6Choice Id { get; init; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{2,2}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{2,2}")]
		[XmlElement("CtryOfRes")]
		public string CtryOfRes { get; init; }

		[XmlElement("CtctDtls")]
		public ContactDetails2 CtctDtls { get; init; }
	}
}
