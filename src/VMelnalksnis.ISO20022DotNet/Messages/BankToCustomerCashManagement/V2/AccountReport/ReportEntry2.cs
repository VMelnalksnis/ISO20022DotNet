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

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Set of elements used to specify an entry in the report.
	/// </summary>
	[Serializable]
	[XmlType("ReportEntry2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ReportEntry2
	{
		[XmlIgnore]
		private Collection<CashBalanceAvailability2> _availability = new();

		[XmlIgnore]
		private Collection<ChargesInformation6> _charges = new();

		[XmlIgnore]
		private Collection<TransactionInterest2> _interest = new();

		[XmlIgnore]
		private Collection<EntryDetails1> _entryDetails = new();

		/// <summary>
		/// Gets unique reference for the entry.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("NtryRef")]
		public string? EntryReference { get; init; }

		/// <summary>
		/// Gets amount of money in the cash entry.
		/// </summary>
		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } = null!;

		/// <summary>
		/// Gets a value indicating whether the entry is a credit or a debit entry.
		/// </summary>
		[Required]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CreditDebitIndicator { get; init; }

		/// <summary>
		/// Gets a value indicating whether or not the entry is the result of a reversal.
		/// </summary>
		/// <remarks>
		/// This element should only be present if the entry is the result of a reversal.
		/// If the <see cref="CreditDebitIndicator"/> is <see cref="CreditDebitCode.CRDT"/> and
		/// <see cref="ReversalIndicator"/> is Yes, the original operation was a debit entry.
		/// If the <see cref="CreditDebitIndicator"/> is <see cref="CreditDebitCode.DBIT"/> and
		/// <see cref="ReversalIndicator"/> is Yes, the original operation was a credit entry.
		/// </remarks>
		[XmlElement("RvslInd")]
		public bool? ReversalIndicator { get; init; }

		/// <summary>
		/// Gets status of an entry on the books of the account servicer.
		/// </summary>
		[Required]
		[XmlElement("Sts")]
		public EntryStatus2Code Status { get; init; }

		/// <summary>
		/// Gets date and time when an entry is posted to an account on the account servicer's books.
		/// </summary>
		/// <remarks>
		/// Booking date is the expected booking date, unless the status is booked,
		/// in which case it is the actual booking date.
		/// </remarks>
		[XmlElement("BookgDt")]
		public DateAndDateTimeChoice? BookingDate { get; init; }

		/// <summary>
		/// Gets date and time at which assets become available to the account owner in case of a credit entry,
		/// or cease to be available to the account owner in case of a debit entry.
		/// </summary>
		/// <remarks>
		/// If entry status is pending and value date is present, then the value date refers to an
		/// expected/requested value date. For entries subject to availability/float and
		/// for which availability information is provided, the value date must not be used.
		/// In this case the availability component identifies the number of availability days.
		/// </remarks>
		[XmlElement("ValDt")]
		public DateAndDateTimeChoice? ValueDate { get; init; }

		/// <summary>
		/// Gets unique reference as assigned by the account servicing institution to unambiguously identify the entry.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("AcctSvcrRef")]
		public string? AccountServicerReference { get; init; }

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
		[Required]
		[XmlElement("BkTxCd")]
		public BankTransactionCodeStructure4 BankTransactionCode { get; init; } = null!;

		/// <summary>
		/// Gets a value indicating whether the transaction is exempt from commission.
		/// </summary>
		[XmlElement("ComssnWvrInd")]
		public bool? CommissionWaiverIndicator { get; init; }

		/// <summary>
		/// Gets a value indicating whether the underlying transaction details are provided through a separate message,
		/// as in the case of aggregate bookings.
		/// </summary>
		[XmlElement("AddtlInfInd")]
		public MessageIdentification2? AdditionalInformationIndicator { get; init; }

		/// <summary>
		/// Gets set of elements providing information on the original amount.
		/// </summary>
		/// <remarks>
		/// This component (on entry level) should be used when
		/// a total original batch or aggregate amount has to be provided. If required,
		/// the individual original amounts can be included in the same component on transaction details level.
		/// </remarks>
		[XmlElement("AmtDtls")]
		public AmountAndCurrencyExchange3? AmountDetails { get; init; }

		/// <summary>
		/// Gets information on the charges included in the entry amount.
		/// </summary>
		/// <remarks>
		/// This component is used on entry level in case of batch or aggregate bookings.
		/// </remarks>
		[XmlElement("Chrgs")]
		public Collection<ChargesInformation6> Charges
		{
			get => _charges;
			private set => _charges = value;
		}

		/// <summary>
		/// Gets channel used to technically input the instruction related to the entry.
		/// </summary>
		[XmlElement("TechInptChanl")]
		public TechnicalInputChannel1Choice? TechnicalInputChannel { get; init; }

		/// <summary>
		/// Gets set of elements used to provide details of the interest amount included in the entry amount.
		/// </summary>
		/// <remarks>
		/// This component is used on entry level in the case of batch or aggregate bookings.
		/// </remarks>
		[XmlElement("Intrst")]
		public Collection<TransactionInterest2> Interest
		{
			get => _interest;
			private set => _interest = value;
		}

		/// <summary>
		/// Gets set of elements used to provide details on the entry.
		/// </summary>
		[XmlElement("NtryDtls")]
		public Collection<EntryDetails1> EntryDetails
		{
			get => _entryDetails;
			private set => _entryDetails = value;
		}

		/// <summary>
		/// Gets further details of the entry.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 500.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlNtryInf")]
		public string? AdditionalEntryInformation { get; init; }
	}
}
