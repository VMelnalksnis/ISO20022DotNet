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
	/// Set of elements used to identify the parties related to the underlying transaction.
	/// </summary>
	[Serializable]
	[XmlType("TransactionParty2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionParty2
	{
		[XmlIgnore]
		private Collection<ProprietaryParty2> _proprietary = new();

		/// <summary>
		/// Gets party that initiated the payment that is reported in the entry.
		/// </summary>
		[XmlElement("InitgPty")]
		public PartyIdentification32? InitiatingParty { get; init; }

		/// <summary>
		/// Gets party that owes an amount of money to the (ultimate) creditor.
		/// </summary>
		[XmlElement("Dbtr")]
		public PartyIdentification32? Debtor { get; init; }

		/// <summary>
		/// Gets unambiguous identification of the account of the debtor.
		/// </summary>
		[XmlElement("DbtrAcct")]
		public CashAccount16? DebtorAccount { get; init; }

		/// <summary>
		/// Gets ultimate party that owes an amount of money to the (ultimate) creditor.
		/// </summary>
		[XmlElement("UltmtDbtr")]
		public PartyIdentification32? UltimateDebtor { get; init; }

		/// <summary>
		/// Gets party to which an amount of money is due.
		/// </summary>
		[XmlElement("Cdtr")]
		public PartyIdentification32? Creditor { get; init; }

		/// <summary>
		/// Gets unambiguous identification of the account of the creditor to which a credit entry has been posted
		/// as a result of the payment transaction.
		/// </summary>
		[XmlElement("CdtrAcct")]
		public CashAccount16? CreditorAccount { get; init; }

		/// <summary>
		/// Gets ultimate party to which an amount of money is due.
		/// </summary>
		[XmlElement("UltmtCdtr")]
		public PartyIdentification32? UltimateCreditor { get; init; }

		/// <summary>
		/// Gets party that plays an active role in planning and executing the transactions that create or
		/// liquidate investments of the investors assets, or that move the investor's assets
		/// from one investment to another. A trading party is a trade instructor, an investment decision-maker,
		/// a post trade administrator, or a trader. In the context of treasury,
		/// it is the party that negotiates and executes the treasury transaction.
		/// </summary>
		[XmlElement("TradgPty")]
		public PartyIdentification32? TradingParty { get; init; }

		/// <summary>
		/// Gets proprietary party related to the underlying transaction.
		/// </summary>
		[XmlElement("Prtry")]
		public Collection<ProprietaryParty2> Proprietary
		{
			get => _proprietary;
			private set => _proprietary = value;
		}
	}
}
