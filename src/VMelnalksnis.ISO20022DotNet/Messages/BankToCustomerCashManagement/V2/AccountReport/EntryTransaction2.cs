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
	[XmlType("EntryTransaction2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record EntryTransaction2
	{
		[XmlElement("Refs")]
		public TransactionReferences2 Refs { get; init; }

		[XmlElement("AmtDtls")]
		public AmountAndCurrencyExchange3 AmtDtls { get; init; }

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
		/// <para xml:lang="en">Initializes a new instance of the <see cref="EntryTransaction2" /> class.</para>
		/// </summary>
		public EntryTransaction2()
		{
			_avlbty = new();
			_chrgs = new();
			_intrst = new();
			_rltdRmtInf = new();
			_rltdQties = new();
		}

		[XmlElement("BkTxCd")]
		public BankTransactionCodeStructure4 BkTxCd { get; init; }

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

		[XmlElement("RltdPties")]
		public TransactionParty2 RltdPties { get; init; }

		[XmlElement("RltdAgts")]
		public TransactionAgents2 RltdAgts { get; init; }

		[XmlElement("Purp")]
		public Purpose2Choice Purp { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<RemittanceLocation2> _rltdRmtInf;

		[XmlElement("RltdRmtInf")]
		public System.Collections.ObjectModel.Collection<RemittanceLocation2> RltdRmtInf
		{
			get => _rltdRmtInf;
			private set => _rltdRmtInf = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the RltdRmtInf collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool RltdRmtInfSpecified => RltdRmtInf.Count != 0;

		[XmlElement("RmtInf")]
		public RemittanceInformation5 RmtInf { get; init; }

		[XmlElement("RltdDts")]
		public TransactionDates2 RltdDts { get; init; }

		[XmlElement("RltdPric")]
		public TransactionPrice2Choice RltdPric { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<TransactionQuantities1Choice> _rltdQties;

		[XmlElement("RltdQties")]
		public System.Collections.ObjectModel.Collection<TransactionQuantities1Choice> RltdQties
		{
			get => _rltdQties;
			private set => _rltdQties = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the RltdQties collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool RltdQtiesSpecified => RltdQties.Count != 0;

		[XmlElement("FinInstrmId")]
		public SecurityIdentification4Choice FinInstrmId { get; init; }

		[XmlElement("Tax")]
		public TaxInformation3 Tax { get; init; }

		[XmlElement("RtrInf")]
		public ReturnReasonInformation10 RtrInf { get; init; }

		[XmlElement("CorpActn")]
		public CorporateAction1 CorpActn { get; init; }

		[XmlElement("SfkpgAcct")]
		public CashAccount16 SfkpgAcct { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 500.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlTxInf")]
		public string AddtlTxInf { get; init; }
	}
}
