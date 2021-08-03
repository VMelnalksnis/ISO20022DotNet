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
	[XmlType("FinancialInstitutionIdentification7",
		Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record FinancialInstitutionIdentification7
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
		[XmlElement("BIC")]
		public string BIC { get; set; }

		[XmlElement("ClrSysMmbId")]
		public ClearingSystemMemberIdentification2 ClrSysMmbId { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("Nm")]
		public string Nm { get; set; }

		[XmlElement("PstlAdr")]
		public PostalAddress6 PstlAdr { get; set; }

		[XmlElement("Othr")]
		public GenericFinancialIdentification1 Othr { get; set; }
	}
}
