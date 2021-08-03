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

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Set of elements used to provide summary information on entries.
	/// </summary>
	[Serializable]
	[XmlType("TotalTransactions2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TotalTransactions2
	{
		[XmlIgnore]
		private Collection<TotalsPerBankTransactionCode2> _totalEntriesPerBankTransactionCode = new();

		/// <summary>
		/// Gets the total number and sum of debit and credit entries.
		/// </summary>
		[XmlElement("TtlNtries")]
		public NumberAndSumOfTransactions2? TotalEntries { get; init; }

		/// <summary>
		/// Gets the total number and sum of credit entries.
		/// </summary>
		[XmlElement("TtlCdtNtries")]
		public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; }

		/// <summary>
		/// Gets the total number and sum of debit entries.
		/// </summary>
		[XmlElement("TtlDbtNtries")]
		public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; }

		/// <summary>
		/// Gets the total number and sum of entries per bank transaction code.
		/// </summary>
		[XmlElement("TtlNtriesPerBkTxCd")]
		public Collection<TotalsPerBankTransactionCode2> TotalEntriesPerBankTransactionCode
		{
			get => _totalEntriesPerBankTransactionCode;
			private set => _totalEntriesPerBankTransactionCode = value;
		}
	}
}
