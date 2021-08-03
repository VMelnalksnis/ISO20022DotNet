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
	/// Amount of money of the cash balance.
	/// </summary>
	[Serializable]
	[XmlType("ActiveOrHistoricCurrencyAndAmount", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ActiveOrHistoricCurrencyAndAmount
	{
		/// <summary>
		/// Gets amount of money of the cash balance.
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlText]
		public decimal Value { get; init; }

		/// <summary>
		/// Gets the ISO 4217 currency code of the amount.
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[Required]
		[XmlAttribute("Ccy")]
		public string Currency { get; init; } = string.Empty;
	}
}
