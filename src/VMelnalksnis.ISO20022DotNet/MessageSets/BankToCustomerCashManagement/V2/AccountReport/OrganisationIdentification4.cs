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
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Unique and unambiguous way to identify an organisation.
	/// </summary>
	[Serializable]
	[XmlType("OrganisationIdentification4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record OrganisationIdentification4
	{
		[XmlIgnore]
		private Collection<GenericOrganisationIdentification1> _other = new();

		/// <summary>
		/// Gets code allocated to organisations by the ISO 9362 Registration Authority,
		/// under an international identification scheme, as described in the latest version of the standard
		/// ISO 9362 Banking (Banking telecommunication messages, Bank Identifier Codes).
		/// <para xml:lang="en">Pattern: [A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
		[XmlElement("BICOrBEI")]
		public string? BicOrBei { get; init; }

		/// <summary>
		/// Gets unique identification of an organisation, as assigned by an institution, using an identification scheme.
		/// </summary>
		[XmlElement("Othr")]
		public Collection<GenericOrganisationIdentification1> Other
		{
			get => _other;
			private set => _other = value;
		}
	}
}
