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
	/// Unique and unambiguous identification of a financial institution,
	/// as assigned under an internationally recognised or proprietary identification scheme.
	/// </summary>
	[Serializable]
	[XmlType("FinancialInstitutionIdentification7", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record FinancialInstitutionIdentification7
	{
		/// <summary>
		/// Gets Bank Identifier Code. Code allocated to financial institutions by the Registration Authority,
		/// under an international identification scheme, as described in the latest version of the
		/// standard ISO 9362 Banking (Banking telecommunication messages, Bank Identifier Codes).
		/// </summary>
		[RegularExpression("[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
		[XmlElement("BIC")]
		public string? Bic { get; init; }

		/// <summary>
		/// Gets information used to identify a member within a clearing system.
		/// </summary>
		[XmlElement("ClrSysMmbId")]
		public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; }

		/// <summary>
		/// Gets name by which an agent is known and which is usually used to identify that agent.
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
		/// Gets unique identification of an agent, as assigned by an institution, using an identification scheme.
		/// </summary>
		[XmlElement("Othr")]
		public GenericFinancialIdentification1? Other { get; init; }
	}
}
