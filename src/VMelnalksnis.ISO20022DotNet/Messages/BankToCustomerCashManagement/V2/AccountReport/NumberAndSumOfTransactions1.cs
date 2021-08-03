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
	[XmlType("NumberAndSumOfTransactions1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record NumberAndSumOfTransactions1
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [0-9]{1,15}.</para>
		/// </summary>
		[RegularExpression("[0-9]{1,15}")]
		[XmlElement("NbOfNtries")]
		public string NbOfNtries { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Sum")]
		public decimal SumValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Sum property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool SumValueSpecified { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? Sum
		{
			get
			{
				if (SumValueSpecified)
				{
					return SumValue;
				}

				return null;
			}
			set
			{
				SumValue = value.GetValueOrDefault();
				SumValueSpecified = value.HasValue;
			}
		}
	}
}
