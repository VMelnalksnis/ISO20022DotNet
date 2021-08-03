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
	/// Unique and unambiguous identification for the account between the account owner and the account servicer.
	/// </summary>
	[Serializable]
	[XmlType("AccountIdentification4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AccountIdentification4Choice
	{
		/// <summary>
		/// Gets International Bank Account Number (IBAN) - identifier used internationally by financial institutions to
		/// uniquely identify the account of a customer. Further specifications of the format and content of the IBAN
		/// can be found in the standard ISO 13616 "Banking and related financial services - International Bank Account
		/// Number (IBAN)" version 1997-10-01, or later revisions.
		/// </summary>
		[RegularExpression("[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}")]
		[XmlElement("IBAN")]
		public string? Iban { get; init; }

		/// <summary>
		/// Gets unique identification of an account, as assigned by the account servicer, using an identification scheme.
		/// </summary>
		[XmlElement("Othr")]
		public GenericAccountIdentification1? Other { get; init; }
	}
}
