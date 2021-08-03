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
	[XmlType("ActiveOrHistoricCurrencyAndAmount",
		Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ActiveOrHistoricCurrencyAndAmount
	{
		/// <summary>
		/// <para xml:lang="en">Gets or sets the text value.</para>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlText]
		public decimal Value { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[Required]
		[XmlAttribute("Ccy")]
		public string Ccy { get; set; }
	}
}
