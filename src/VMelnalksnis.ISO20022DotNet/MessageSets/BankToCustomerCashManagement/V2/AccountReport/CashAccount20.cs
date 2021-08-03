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
	[XmlType("CashAccount20", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CashAccount20
	{
		/// <summary>
		/// Gets unique and unambiguous identification for the account between the account owner and the account servicer.
		/// </summary>
		[Required]
		[XmlElement("Id")]
		public AccountIdentification4Choice Identification { get; init; } = null!;

		/// <summary>
		/// Gets specifies the nature, or use of the account.
		/// </summary>
		[XmlElement("Tp")]
		public CashAccountType2? Type { get; init; }

		/// <summary>
		/// Gets identification of the currency in which the account is held.
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("Ccy")]
		public string? Currency { get; init; }

		/// <summary>
		/// Gets name of the account, as assigned by the account servicing institution,
		/// in agreement with the account owner in order to provide an additional means of identification of the account.
		/// </summary>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("Nm")]
		public string? Name { get; init; }

		/// <summary>
		/// Gets party that legally owns the account.
		/// </summary>
		[XmlElement("Ownr")]
		public PartyIdentification32? Owner { get; init; }

		/// <summary>
		/// Gets party that manages the account on behalf of the account owner,
		/// that is manages the registration and booking of entries on the account,
		/// calculates balances on the account and provides information about the account.
		/// </summary>
		[XmlElement("Svcr")]
		public BranchAndFinancialInstitutionIdentification4? Servicer { get; init; }
	}
}
