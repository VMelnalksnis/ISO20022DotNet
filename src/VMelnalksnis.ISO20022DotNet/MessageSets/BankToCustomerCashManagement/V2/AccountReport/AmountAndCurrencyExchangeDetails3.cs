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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges,
	/// expressed in the currency as ordered by the initiating party and provides currency exchange information in
	/// case the instructed amount and/or currency is/are different from the entry amount and/or currency.
	/// </summary>
	[Serializable]
	[XmlType("AmountAndCurrencyExchangeDetails3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AmountAndCurrencyExchangeDetails3
	{
		/// <summary>
		/// Gets amount of money to be moved between the debtor and creditor, before deduction of charges,
		/// expressed in the currency as ordered by the initiating party.
		/// </summary>
		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } = null!;

		/// <summary>
		/// Gets set of elements used to provide details on the currency exchange.
		/// </summary>
		[XmlElement("CcyXchg")]
		public CurrencyExchange5? CurrencyExchange { get; init; }
	}
}
