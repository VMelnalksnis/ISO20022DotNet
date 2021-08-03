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
	[XmlType("ChargesInformation6", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ChargesInformation6
	{
		[XmlElement("TtlChrgsAndTaxAmt")]
		public ActiveOrHistoricCurrencyAndAmount TtlChrgsAndTaxAmt { get; set; }

		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

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

		[XmlElement("Tp")]
		public ChargeType2Choice Tp { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Rate")]
		public decimal RateValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RateValueSpecified { get; set; }

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
			set
			{
				RateValue = value.GetValueOrDefault();
				RateValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Br")]
		public ChargeBearerType1Code BrValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Br property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool BrValueSpecified { get; set; }

		[XmlIgnore]
		public ChargeBearerType1Code? Br
		{
			get
			{
				if (BrValueSpecified)
				{
					return BrValue;
				}

				return null;
			}
			set
			{
				BrValue = value.GetValueOrDefault();
				BrValueSpecified = value.HasValue;
			}
		}

		[XmlElement("Pty")]
		public BranchAndFinancialInstitutionIdentification4 Pty { get; set; }

		[XmlElement("Tax")]
		public TaxCharges2 Tax { get; set; }
	}
}
