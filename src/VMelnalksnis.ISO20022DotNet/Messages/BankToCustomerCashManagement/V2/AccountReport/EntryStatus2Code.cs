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
using System.Xml.Serialization;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Status of an entry on the books of the account servicer.
	/// </summary>
	[Serializable]
	[XmlType("EntryStatus2Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	public enum EntryStatus2Code
	{
		/// <summary>
		/// Booked means that the transfer of money has been completed between account servicer and account owner.
		/// </summary>
		/// <remarks>
		/// Status Booked does not necessarily imply finality of money as this depends on other factors such as
		/// the payment system used, the completion of the end-to-end transaction and the terms agreed
		/// between account servicer and owner. Status <see cref="BOOK"/> is the only status that can be reversed.
		/// </remarks>
		BOOK,

		/// <summary>
		/// Booking on the account owner's account in the account servicer's ledger has not been completed.
		/// </summary>
		/// <remarks>
		/// This can be used for expected items, or for items for which some conditions still need to be fulfilled
		/// before they can be booked. If booking takes place, the entry will be included with status
		/// <see cref="BOOK"/> in subsequent account report or statement. Status Pending cannot be reversed.
		/// </remarks>
		PDNG,

		/// <summary>
		/// Entry is only provided for information,
		/// and no booking on the account owner's account in the account servicer's ledger has been performed.
		/// </summary>
		INFO,
	}
}
