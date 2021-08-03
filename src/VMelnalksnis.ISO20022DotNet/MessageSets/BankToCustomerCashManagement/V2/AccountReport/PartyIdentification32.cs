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
	/// Set of elements used to identify a person or an organisation.
	/// </summary>
	[Serializable]
	[XmlType("PartyIdentification32", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record PartyIdentification32
	{
		/// <summary>
		/// Gets name by which a party is known and which is usually used to identify that party.
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("Nm")]
		public string? Name { get; init; }

		/// <summary>
		/// Gets information that locates and identifies a specific address, as defined by postal services.
		/// </summary>
		[XmlElement("PstlAdr")]
		public PostalAddress6? PostalAddress { get; init; }

		/// <summary>
		/// Gets unique and unambiguous identification of a party.
		/// </summary>
		[XmlElement("Id")]
		public Party6Choice? Identification { get; init; }

		/// <summary>
		/// Gets country in which a person resides (the place of a person's home).
		/// In the case of a company, it is the country from which the affairs of that company are directed.
		/// </summary>
		[RegularExpression("[A-Z]{2,2}")]
		[XmlElement("CtryOfRes")]
		public string? CountryOfResidence { get; init; }

		/// <summary>
		/// Gets set of elements used to indicate how to contact the party.
		/// </summary>
		[XmlElement("CtctDtls")]
		public ContactDetails2? ContactDetails { get; init; }
	}
}
