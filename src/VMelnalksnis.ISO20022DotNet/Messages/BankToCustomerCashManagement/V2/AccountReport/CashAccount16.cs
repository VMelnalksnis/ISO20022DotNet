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
	[XmlType("CashAccount16", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CashAccount16
	{
		[Required]
		[XmlElement("Id")]
		public AccountIdentification4Choice Id { get; set; }

		[XmlElement("Tp")]
		public CashAccountType2 Tp { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("Ccy")]
		public string Ccy { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 70.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("Nm")]
		public string Nm { get; set; }
	}
}
