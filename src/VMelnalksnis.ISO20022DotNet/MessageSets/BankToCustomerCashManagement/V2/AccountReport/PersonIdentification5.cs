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

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Unique and unambiguous identification of a person, eg, passport.
	/// </summary>
	[Serializable]
	[XmlType("PersonIdentification5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record PersonIdentification5
	{
		[XmlIgnore]
		private Collection<GenericPersonIdentification1> _other = new();

		/// <summary>
		/// Gets date and place of birth of a person.
		/// </summary>
		[XmlElement("DtAndPlcOfBirth")]
		public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; }

		/// <summary>
		/// Gets unique identification of a person, as assigned by an institution, using an identification scheme.
		/// </summary>
		[XmlElement("Othr")]
		public Collection<GenericPersonIdentification1> Other
		{
			get => _other;
			private set => _other = value;
		}
	}
}
