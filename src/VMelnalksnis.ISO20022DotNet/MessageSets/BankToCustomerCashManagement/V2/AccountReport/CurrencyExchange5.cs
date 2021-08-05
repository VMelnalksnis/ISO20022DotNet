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
	/// Set of elements used to provide details on the currency exchange.
	/// </summary>
	[Serializable]
	[XmlType("CurrencyExchange5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CurrencyExchange5
	{
		/// <summary>
		/// Gets currency from which an amount is to be converted in a currency conversion.
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[Required]
		[XmlElement("SrcCcy")]
		public string SourceCurrency { get; init; } = string.Empty;

		/// <summary>
		/// Gets currency into which an amount is to be converted in a currency conversion.
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("TrgtCcy")]
		public string? TargetCurrency { get; init; }

		/// <summary>
		/// Gets currency in which the rate of exchange is expressed in a currency exchange.
		/// In the example 1GBP = xxxCUR, the unit currency is GBP.
		/// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{3,3}")]
		[XmlElement("UnitCcy")]
		public string? UnitCurrency { get; init; }

		/// <summary>
		/// Gets factor used to convert an amount from one currency into another.
		/// This reflects the price at which one currency was bought with another currency.
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		/// <remarks>
		/// ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency
		/// (ExchangeRate = UnitCurrency/QuotedCurrency).
		/// </remarks>
		[Required]
		[XmlElement("XchgRate")]
		public decimal ExchangeRate { get; init; }

		/// <summary>
		/// Gets unique identification to unambiguously identify the foreign exchange contract.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("CtrctId")]
		public string? ContractIdentification { get; init; }

		/// <summary>
		/// Gets date and time at which an exchange rate is quoted.
		/// </summary>
		[XmlElement("QtnDt", DataType = "dateTime")]
		public DateTime? QuotationDate { get; init; }
	}
}
