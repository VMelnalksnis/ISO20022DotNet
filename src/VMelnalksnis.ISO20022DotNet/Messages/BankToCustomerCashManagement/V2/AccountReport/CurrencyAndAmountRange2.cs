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
	[XmlType("CurrencyAndAmountRange2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CurrencyAndAmountRange2
	{
		[Required]
		[XmlElement("Amt")]
		public ImpliedCurrencyAmountRangeChoice Amt { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CdtDbtIndValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CdtDbtIndValueSpecified { get; set; }

		[XmlIgnore]
		public CreditDebitCode? CdtDbtInd
		{
			get
			{
				if (CdtDbtIndValueSpecified)
				{
					return CdtDbtIndValue;
				}

				return null;
			}
			set
			{
				CdtDbtIndValue = value.GetValueOrDefault();
				CdtDbtIndValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[Required]
		[XmlElement("Ccy")]
		public string Ccy { get; set; }
	}
}
