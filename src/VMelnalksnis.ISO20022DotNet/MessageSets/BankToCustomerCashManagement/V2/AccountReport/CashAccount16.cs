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
	/// Set of elements used to identify an account.
	/// </summary>
	[Serializable]
	[XmlType("CashAccount16", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CashAccount16
	{
		/// <summary>
		/// Gets unique and unambiguous identification for the account between the account owner and the account servicer.
		/// </summary>
		[Required]
		[XmlElement("Id")]
		public AccountIdentification4Choice Identification { get; init; } = null!;

		/// <summary>
		/// Gets the nature, or use of the account.
		/// </summary>
		[XmlElement("Tp")]
		public CashAccountType2? Type { get; init; }

		/// <summary>
		/// Gets identification of the currency in which the account is held.
		/// </summary>
		/// <remarks>
		/// Currency should only be used in case one and the same account number covers several currencies
		/// and the initiating party needs to identify which currency needs to be used for settlement on the account.
		/// </remarks>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("Ccy")]
		public string? Currency { get; init; }

		/// <summary>
		/// Gets name of the account, as assigned by the account servicing institution, in agreement with the account owner
		/// in order to provide an additional means of identification of the account.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 70.</para>
		/// </summary>
		/// <remarks>
		/// The account name is different from the account owner name. The account name is used in certain user
		/// communities to provide a means of identifying the account, in addition to the account owner's identity
		/// and the account number.
		/// </remarks>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("Nm")]
		public string? Name { get; init; }
	}
}
