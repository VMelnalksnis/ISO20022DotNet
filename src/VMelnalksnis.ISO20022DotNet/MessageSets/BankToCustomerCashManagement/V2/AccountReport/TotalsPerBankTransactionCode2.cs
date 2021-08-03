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
	/// Specifies the total number and sum of entries per bank transaction code.
	/// </summary>
	[Serializable]
	[XmlType("TotalsPerBankTransactionCode2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TotalsPerBankTransactionCode2
	{
		[XmlIgnore]
		private Collection<CashBalanceAvailability2> _availability = new();

		/// <summary>
		/// Gets number of individual entries for the bank transaction code.
		/// </summary>
		[RegularExpression("[0-9]{1,15}")]
		[XmlElement("NbOfNtries")]
		public long? NumberOfEntries { get; init; }

		/// <summary>
		/// Gets total of all individual entries included in the report.
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlElement("Sum")]
		public decimal? Sum { get; init; }

		/// <summary>
		/// Gets total amount that is the result of the netted amounts for all
		/// debit and credit entries per bank transaction code.
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlElement("TtlNetNtryAmt")]
		public decimal? TotalNetEntryAmount { get; init; }

		/// <summary>
		/// Gets a value indicating whether the total net entry amount is a credit or a debit amount.
		/// </summary>
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode? CreditDebitIndicator { get; init; }

		/// <summary>
		/// Gets a value indicating whether the bank transaction code is related to booked or forecast items.
		/// </summary>
		[XmlElement("FcstInd")]
		public bool? ForecastIndicator { get; init; }

		/// <summary>
		/// Gets set of elements used to fully identify the type of underlying transaction resulting in an entry.
		/// </summary>
		[Required]
		[XmlElement("BkTxCd")]
		public BankTransactionCodeStructure4 BankTransactionCode { get; init; } = null!;

		/// <summary>
		/// Gets set of elements used to indicate when the booked amount of money will become available,
		/// that is can be accessed and starts generating interest.
		/// </summary>
		[XmlElement("Avlbty")]
		public Collection<CashBalanceAvailability2> Availability
		{
			get => _availability;
			private set => _availability = value;
		}
	}
}
