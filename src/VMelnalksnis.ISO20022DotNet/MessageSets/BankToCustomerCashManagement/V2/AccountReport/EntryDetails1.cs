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
	/// Set of elements used to provide details on the entry.
	/// </summary>
	[Serializable]
	[XmlType("EntryDetails1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record EntryDetails1
	{
		[XmlIgnore]
		private Collection<EntryTransaction2> _transactionDetails = new();

		/// <summary>
		/// Gets set of elements used to provide details on batched transactions.
		/// </summary>
		[XmlElement("Btch")]
		public BatchInformation2? Batch { get; init; }

		/// <summary>
		/// Gets set of elements used to provide information on the underlying transaction(s).
		/// </summary>
		[XmlElement("TxDtls")]
		public Collection<EntryTransaction2> TransactionDetails
		{
			get => _transactionDetails;
			private set => _transactionDetails = value;
		}
	}
}
