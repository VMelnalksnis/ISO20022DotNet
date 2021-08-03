// Copyright 2021 Valters Melnalksnis
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License in the project root or at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Set of elements used to provide information on the underlying transaction(s).
	/// </summary>
	[Serializable]
	[XmlType("EntryTransaction2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record EntryTransaction2
	{
		[XmlIgnore]
		private Collection<CashBalanceAvailability2> _availability = new();

		[XmlIgnore]
		private Collection<ChargesInformation6> _charges = new();

		[XmlIgnore]
		private Collection<TransactionInterest2> _interest = new();

		[XmlIgnore]
		private Collection<RemittanceLocation2> _relatedRemittanceInformation = new();

		[XmlIgnore]
		private Collection<TransactionQuantities1Choice> _relatedQuantities = new();

		/// <summary>
		/// Gets set of elements used to provide the identification of the underlying transaction.
		/// </summary>
		[XmlElement("Refs")]
		public TransactionReferences2? References { get; init; }

		/// <summary>
		/// Gets set of elements providing detailed information on the original amount.
		/// </summary>
		/// <remarks>
		/// This component (on transaction level) should be used in case booking is for a single transaction and
		/// the original amount is different from the entry amount.
		/// It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
		/// </remarks>
		[XmlElement("AmtDtls")]
		public AmountAndCurrencyExchange3? AmountDetails { get; init; }

		/// <summary>
		/// Gets set of elements used to indicate when the booked amount of money will become available,
		/// that is can be accessed and starts generating interest.
		/// </summary>
		/// <remarks>
		/// This type of information is used in the US and is linked to particular instruments such as cheques.
		/// Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will
		/// only be accessible as of the indicated availability day (according to national banking regulations).
		/// </remarks>
		[XmlElement("Avlbty")]
		public Collection<CashBalanceAvailability2> Availability
		{
			get => _availability;
			private set => _availability = value;
		}

		/// <summary>
		/// Gets set of elements used to fully identify the type of underlying transaction resulting in an entry.
		/// </summary>
		[XmlElement("BkTxCd")]
		public BankTransactionCodeStructure4? BankTransactionCode { get; init; }

		/// <summary>
		/// Gets provides information on the charges included in the entry amount.
		/// </summary>
		/// <remarks>
		/// This component (on transaction level) can be used in case the booking is for a single transaction,
		/// and charges are included in the entry amount. It can also be used in case individual charge amounts
		/// are applied to individual transactions in case of a batch or aggregate amount booking.
		/// </remarks>
		[XmlElement("Chrgs")]
		public Collection<ChargesInformation6> Charges
		{
			get => _charges;
			private set => _charges = value;
		}

		/// <summary>
		/// Gets set of elements used to provide details of the interest amount included in the entry amount.
		/// </summary>
		/// <remarks>
		/// This component (on transaction level) can be used if the booking is for a single transaction,
		/// and interest amount is included in the entry amount. It can also be used if individual interest amounts
		/// are applied to individual transactions in the case of a batch or aggregate amount booking.
		/// </remarks>
		[XmlElement("Intrst")]
		public Collection<TransactionInterest2> Interest
		{
			get => _interest;
			private set => _interest = value;
		}

		/// <summary>
		/// Gets set of elements used to identify the parties related to the underlying transaction.
		/// </summary>
		[XmlElement("RltdPties")]
		public TransactionParty2? RelatedParties { get; init; }

		/// <summary>
		/// Gets set of elements used to identify the agents related to the underlying transaction.
		/// </summary>
		[XmlElement("RltdAgts")]
		public TransactionAgents2? RelatedAgents { get; init; }

		/// <summary>
		/// Gets underlying reason for the payment transaction.
		/// </summary>
		/// <remarks>
		/// Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor
		/// to provide information concerning the nature of the payment. Purpose is a content element,
		/// which is not used for processing by any of the agents involved in the payment chain.
		/// </remarks>
		[XmlElement("Purp")]
		public Purpose2Choice? Purpose { get; init; }

		/// <summary>
		/// Gets set of elements used to provide information related to the handling of the remittance information
		/// by any of the agents in the transaction processing chain.
		/// </summary>
		[XmlElement("RltdRmtInf")]
		public Collection<RemittanceLocation2> RelatedRemittanceInformation
		{
			get => _relatedRemittanceInformation;
			private set => _relatedRemittanceInformation = value;
		}

		/// <summary>
		/// Gets structured information that enables the matching, ie, reconciliation, of a payment with the items that
		/// the payment is intended to settle, such as commercial invoices in an account receivable system.
		/// </summary>
		[XmlElement("RmtInf")]
		public RemittanceInformation5? RemittanceInformation { get; init; }

		/// <summary>
		/// Gets set of elements used to identify the dates related to the underlying transactions.
		/// </summary>
		[XmlElement("RltdDts")]
		public TransactionDates2? RelatedDates { get; init; }

		/// <summary>
		/// Gets set of elements used to identify the price information related to the underlying transaction.
		/// </summary>
		[XmlElement("RltdPric")]
		public TransactionPrice2Choice? RelatedPrice { get; init; }

		/// <summary>
		/// Gets set of elements used to identify the related quantities, such as securities, in the underlying transaction.
		/// </summary>
		[XmlElement("RltdQties")]
		public Collection<TransactionQuantities1Choice> RelatedQuantities
		{
			get => _relatedQuantities;
			private set => _relatedQuantities = value;
		}

		/// <summary>
		/// Gets identification of a security, as assigned under a formal or proprietary identification scheme.
		/// </summary>
		[XmlElement("FinInstrmId")]
		public SecurityIdentification4Choice? FinancialInstrumentIdentification { get; init; }

		/// <summary>
		/// Gets set of elements used to provide details on the tax.
		/// </summary>
		[XmlElement("Tax")]
		public TaxInformation3? Tax { get; init; }

		/// <summary>
		/// Gets set of elements used to provide the return information.
		/// </summary>
		[XmlElement("RtrInf")]
		public ReturnReasonInformation10? ReturnInformation { get; init; }

		/// <summary>
		/// Gets set of elements used to identify the underlying corporate action.
		/// </summary>
		[XmlElement("CorpActn")]
		public CorporateAction1? CorporateAction { get; init; }

		/// <summary>
		/// Gets safekeeping or investment account. A safekeeping account is an account on which a securities entry is made.
		/// An investment account is an account between an investor(s) and a fund manager or a fund.
		/// The account can contain holdings in any investment fund or investment fund class managed (or distributed)
		/// by the fund manager, within the same fund family.
		/// </summary>
		[XmlElement("SfkpgAcct")]
		public CashAccount16? SafekeepingAccount { get; init; }

		/// <summary>
		/// Gets further details of the transaction.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 500.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlTxInf")]
		public string? AdditionalTransactionInformation { get; init; }
	}
}
