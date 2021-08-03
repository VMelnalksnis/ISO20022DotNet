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
	/// Set of elements used to define the balance as a numerical representation of the net increases and decreases
	/// in an account at a specific point in time.
	/// </summary>
	[Serializable]
	[XmlType("CashBalance3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CashBalance3
	{
		[XmlIgnore]
		private Collection<CashBalanceAvailability2> _availability = new();

		/// <summary>
		/// Gets the nature of a balance.
		/// </summary>
		[Required]
		[XmlElement("Tp")]
		public BalanceType12 Type { get; init; } = null!;

		/// <summary>
		/// Gets set of elements used to provide details on the credit line.
		/// </summary>
		[XmlElement("CdtLine")]
		public CreditLine2? CreditLine { get; init; }

		/// <summary>
		/// Gets amount of money of the cash balance.
		/// </summary>
		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } = null!;

		/// <summary>
		/// Gets a value indicating whether the balance is a credit or a debit balance.
		/// </summary>
		/// <remarks>
		/// A zero balance is considered to be a credit balance.
		/// </remarks>
		[Required]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CreditDebitIndicator { get; init; }

		/// <summary>
		/// Gets the date (and time) of the balance.
		/// </summary>
		[Required]
		[XmlElement("Dt")]
		public DateAndDateTimeChoice Date { get; init; } = null!;

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
	}
}
