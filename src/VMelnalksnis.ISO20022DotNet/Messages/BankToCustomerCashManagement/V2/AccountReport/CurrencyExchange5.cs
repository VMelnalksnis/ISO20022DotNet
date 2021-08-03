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
	[XmlType("CurrencyExchange5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CurrencyExchange5
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[Required]
		[XmlElement("SrcCcy")]
		public string SrcCcy { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("TrgtCcy")]
		public string TrgtCcy { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("UnitCcy")]
		public string UnitCcy { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[Required]
		[XmlElement("XchgRate")]
		public decimal XchgRate { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("CtrctId")]
		public string CtrctId { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("QtnDt", DataType = "dateTime")]
		public DateTime QtnDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the QtnDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool QtnDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? QtnDt
		{
			get
			{
				if (QtnDtValueSpecified)
				{
					return QtnDtValue;
				}

				return null;
			}
			set
			{
				QtnDtValue = value.GetValueOrDefault();
				QtnDtValueSpecified = value.HasValue;
			}
		}
	}
}
