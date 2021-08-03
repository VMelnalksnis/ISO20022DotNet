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
	[XmlType("ReportEntry2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ReportEntry2
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("NtryRef")]
		public string NtryRef { get; set; }

		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

		[Required]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CdtDbtInd { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("RvslInd")]
		public bool RvslIndValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the RvslInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RvslIndValueSpecified { get; set; }

		[XmlIgnore]
		public bool? RvslInd
		{
			get
			{
				if (RvslIndValueSpecified)
				{
					return RvslIndValue;
				}

				return null;
			}
			set
			{
				RvslIndValue = value.GetValueOrDefault();
				RvslIndValueSpecified = value.HasValue;
			}
		}

		[Required]
		[XmlElement("Sts")]
		public EntryStatus2Code Sts { get; set; }

		[XmlElement("BookgDt")]
		public DateAndDateTimeChoice BookgDt { get; set; }

		[XmlElement("ValDt")]
		public DateAndDateTimeChoice ValDt { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("AcctSvcrRef")]
		public string AcctSvcrRef { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<CashBalanceAvailability2> _avlbty;

		[XmlElement("Avlbty")]
		public System.Collections.ObjectModel.Collection<CashBalanceAvailability2> Avlbty
		{
			get => _avlbty;
			private set => _avlbty = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Avlbty collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool AvlbtySpecified => Avlbty.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="ReportEntry2" /> class.</para>
		/// </summary>
		public ReportEntry2()
		{
			_avlbty = new();
			_chrgs = new();
			_intrst = new();
			_ntryDtls = new();
		}

		[Required]
		[XmlElement("BkTxCd")]
		public BankTransactionCodeStructure4 BkTxCd { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("ComssnWvrInd")]
		public bool ComssnWvrIndValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the ComssnWvrInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ComssnWvrIndValueSpecified { get; set; }

		[XmlIgnore]
		public bool? ComssnWvrInd
		{
			get
			{
				if (ComssnWvrIndValueSpecified)
				{
					return ComssnWvrIndValue;
				}

				return null;
			}
			set
			{
				ComssnWvrIndValue = value.GetValueOrDefault();
				ComssnWvrIndValueSpecified = value.HasValue;
			}
		}

		[XmlElement("AddtlInfInd")]
		public MessageIdentification2 AddtlInfInd { get; set; }

		[XmlElement("AmtDtls")]
		public AmountAndCurrencyExchange3 AmtDtls { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<ChargesInformation6> _chrgs;

		[XmlElement("Chrgs")]
		public System.Collections.ObjectModel.Collection<ChargesInformation6> Chrgs
		{
			get => _chrgs;
			private set => _chrgs = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Chrgs collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool ChrgsSpecified => Chrgs.Count != 0;

		[XmlElement("TechInptChanl")]
		public TechnicalInputChannel1Choice TechInptChanl { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<TransactionInterest2> _intrst;

		[XmlElement("Intrst")]
		public System.Collections.ObjectModel.Collection<TransactionInterest2> Intrst
		{
			get => _intrst;
			private set => _intrst = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Intrst collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool IntrstSpecified => Intrst.Count != 0;

		[XmlIgnore] private System.Collections.ObjectModel.Collection<EntryDetails1> _ntryDtls;

		[XmlElement("NtryDtls")]
		public System.Collections.ObjectModel.Collection<EntryDetails1> NtryDtls
		{
			get => _ntryDtls;
			private set => _ntryDtls = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the NtryDtls collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool NtryDtlsSpecified => NtryDtls.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 500.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlNtryInf")]
		public string AddtlNtryInf { get; set; }
	}
}
