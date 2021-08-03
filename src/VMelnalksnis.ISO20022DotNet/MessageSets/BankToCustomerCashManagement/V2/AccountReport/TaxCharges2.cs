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
	[XmlType("TaxCharges2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TaxCharges2
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Id")]
		public string Id { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Rate")]
		public decimal RateValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RateValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? Rate
		{
			get
			{
				if (RateValueSpecified)
				{
					return RateValue;
				}

				return null;
			}
			init
			{
				RateValue = value.GetValueOrDefault();
				RateValueSpecified = value.HasValue;
			}
		}

		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; init; }
	}
}
