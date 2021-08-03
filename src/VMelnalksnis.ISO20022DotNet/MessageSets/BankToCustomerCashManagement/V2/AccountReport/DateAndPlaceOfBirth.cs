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
	[XmlType("DateAndPlaceOfBirth", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record DateAndPlaceOfBirth
	{
		[Required]
		[XmlElement("BirthDt", DataType = "date")]
		public DateTime BirthDt { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("PrvcOfBirth")]
		public string PrvcOfBirth { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[Required]
		[XmlElement("CityOfBirth")]
		public string CityOfBirth { get; init; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{2,2}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{2,2}")]
		[Required]
		[XmlElement("CtryOfBirth")]
		public string CtryOfBirth { get; init; }
	}
}
