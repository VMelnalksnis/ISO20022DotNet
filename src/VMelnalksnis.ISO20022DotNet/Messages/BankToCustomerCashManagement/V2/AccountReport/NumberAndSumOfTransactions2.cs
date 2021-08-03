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

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Specifies the total number and sum of debit and credit entries.
	/// </summary>
	/// <remarks>
	/// <see cref="CreditDebitIndicator"/> should be present when <see cref="TotalNetEntryAmount"/> is present.
	/// </remarks>
	[Serializable]
	[XmlType("NumberAndSumOfTransactions2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record NumberAndSumOfTransactions2
	{
		/// <summary>
		/// Gets number of individual entries included in the report.
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
		/// Gets resulting amount of the netted amounts for all debit and credit entries.
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
	}
}
