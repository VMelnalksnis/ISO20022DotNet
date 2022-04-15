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

using NodaTime;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Reports on a cash account.
	/// </summary>
	[Serializable]
	[XmlType("AccountReport11", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AccountReport11
	{
		[XmlIgnore]
		private Collection<AccountInterest2> _interest = new();
		[XmlIgnore]
		private Collection<CashBalance3> _balance = new();
		[XmlIgnore]
		private Collection<ReportEntry2> _entry = new();

		/// <summary>
		/// Gets unique identification, as assigned by the account servicer, to unambiguously identify the account report.
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[Required]
		[XmlElement("Id")]
		public string Identification { get; init; } = string.Empty;

		/// <summary>
		/// Gets sequential number of the report, as assigned by the account servicer.
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		/// <remarks>
		/// The sequential number is increased incrementally for each report sent electronically.
		/// </remarks>
		[XmlElement("ElctrncSeqNb")]
		public decimal? ElectronicSequenceNumber { get; init; }

		/// <summary>
		/// Gets legal sequential number of the report, as assigned by the account servicer.
		/// It is increased incrementally for each report sent.
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlElement("LglSeqNb")]
		public decimal? LegalSequenceNumber { get; init; }

		/// <summary>
		/// Gets date and time at which the message was created.
		/// </summary>
		[Required]
		[XmlElement("CreDtTm")]
		public Instant CreationDateTime { get; init; }

		/// <summary>
		/// Gets range of time between a start date and an end date for which the account report is issued.
		/// </summary>
		[XmlElement("FrToDt")]
		public DateTimePeriodDetails? FromToDate { get; init; }

		/// <summary>
		/// Gets a value which indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
		/// </summary>
		[XmlElement("CpyDplctInd")]
		public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; }

		/// <summary>
		/// Gets specifies the application used to generate the reporting.
		/// </summary>
		[XmlElement("RptgSrc")]
		public ReportingSource1Choice? ReportingSource { get; init; }

		/// <summary>
		/// Gets unambiguous identification of the account to which credit and debit entries are made.
		/// </summary>
		[Required]
		[XmlElement("Acct")]
		public CashAccount20 Account { get; init; } = null!;

		/// <summary>
		/// Gets identifies the parent account of the account for which the report has been issued.
		/// </summary>
		[XmlElement("RltdAcct")]
		public CashAccount16? RelatedAccount { get; init; }

		/// <summary>
		/// Gets set of elements used to provide general interest information
		/// that applies to the account at a particular moment in time.
		/// </summary>
		[XmlElement("Intrst")]
		public Collection<AccountInterest2> Interest
		{
			get => _interest;
			private set => _interest = value;
		}

		/// <summary>
		/// Gets set of elements used to define the balance as a numerical representation of the
		/// net increases and decreases in an account at a specific point in time.
		/// </summary>
		[XmlElement("Bal")]
		public Collection<CashBalance3> Balance
		{
			get => _balance;
			private set => _balance = value;
		}

		/// <summary>
		/// Gets set of elements used to provide summary information on entries.
		/// </summary>
		[XmlElement("TxsSummry")]
		public TotalTransactions2? TransactionsSummary { get; init; }

		/// <summary>
		/// Gets set of elements used to specify an entry in the report.
		/// </summary>
		/// <remarks>
		/// At least one reference must be provided to identify the entry and its underlying transaction(s).
		/// </remarks>
		[XmlElement("Ntry")]
		public Collection<ReportEntry2> Entry
		{
			get => _entry;
			private set => _entry = value;
		}

		/// <summary>
		/// Gets further details of the account report.
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlRptInf")]
		public string? AdditionalReportInformation { get; init; }
	}
}
