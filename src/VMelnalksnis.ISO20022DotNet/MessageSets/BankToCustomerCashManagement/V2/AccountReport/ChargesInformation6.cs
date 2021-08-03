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
	[XmlType("ChargesInformation6", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ChargesInformation6
	{
		[XmlElement("TtlChrgsAndTaxAmt")]
		public ActiveOrHistoricCurrencyAndAmount TtlChrgsAndTaxAmt { get; init; }

		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; init; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CdtDbtIndValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CdtDbtIndValueSpecified { get; init; }

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
			init
			{
				CdtDbtIndValue = value.GetValueOrDefault();
				CdtDbtIndValueSpecified = value.HasValue;
			}
		}

		[XmlElement("Tp")]
		public ChargeType2Choice Tp { get; init; }

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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Br")]
		public ChargeBearerType1Code BrValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Br property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool BrValueSpecified { get; init; }

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
			init
			{
				BrValue = value.GetValueOrDefault();
				BrValueSpecified = value.HasValue;
			}
		}

		[XmlElement("Pty")]
		public BranchAndFinancialInstitutionIdentification4 Pty { get; init; }

		[XmlElement("Tax")]
		public TaxCharges2 Tax { get; init; }
	}
}
