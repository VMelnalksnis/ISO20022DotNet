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
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Set of elements used to provide information on the original amount.
	/// </summary>
	[Serializable]
	[XmlType("AmountAndCurrencyExchange3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AmountAndCurrencyExchange3
	{
		[XmlIgnore]
		private Collection<AmountAndCurrencyExchangeDetails4> _proprietaryAmounts = new();

		/// <summary>
		/// Gets the amount of money to be moved between the debtor and creditor, before deduction of charges,
		/// expressed in the currency as ordered by the initiating party and provides currency exchange information
		/// in case the instructed amount and/or currency is/are different from the entry amount and/or currency.
		/// </summary>
		[XmlElement("InstdAmt")]
		public AmountAndCurrencyExchangeDetails3? InstructedAmount { get; init; }

		/// <summary>
		/// Gets amount of the underlying transaction.
		/// </summary>
		[XmlElement("TxAmt")]
		public AmountAndCurrencyExchangeDetails3? TransactionAmount { get; init; }

		/// <summary>
		/// Gets set of elements used to provide the countervalue amount and  currency exchange information.
		/// </summary>
		/// <remarks>
		/// This can be either the counter amount quoted in an FX deal, or the result of the currency information
		/// applied to an instructed amount, before deduction of charges.
		/// </remarks>
		[XmlElement("CntrValAmt")]
		public AmountAndCurrencyExchangeDetails3? CounterValueAmount { get; init; }

		/// <summary>
		/// Gets amount of money, based on terms of corporate action event and balance of underlying securities,
		/// entitled to/from the account owner. In some situations, this amount may alternatively be called entitled amount.
		/// </summary>
		[XmlElement("AnncdPstngAmt")]
		public AmountAndCurrencyExchangeDetails3? AnnouncedPostingAmount { get; init; }

		/// <summary>
		/// Gets set of elements used to provide information on the original amount and currency exchange.
		/// </summary>
		[XmlElement("PrtryAmt")]
		public Collection<AmountAndCurrencyExchangeDetails4> ProprietaryAmounts
		{
			get => _proprietaryAmounts;
			private set => _proprietaryAmounts = value;
		}
	}
}
