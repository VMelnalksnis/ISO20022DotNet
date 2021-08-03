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
	[XmlType("RateType4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record RateType4Choice
	{
		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Pctg")]
		public decimal PctgValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Pctg property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool PctgValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? Pctg
		{
			get
			{
				if (PctgValueSpecified)
				{
					return PctgValue;
				}

				return null;
			}
			init
			{
				PctgValue = value.GetValueOrDefault();
				PctgValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Othr")]
		public string Othr { get; init; }
	}
}
