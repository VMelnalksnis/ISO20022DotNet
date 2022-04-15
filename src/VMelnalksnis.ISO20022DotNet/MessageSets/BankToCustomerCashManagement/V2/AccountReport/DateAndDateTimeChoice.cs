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
using System.Diagnostics;
using System.Xml.Serialization;

using NodaTime;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Choice between a date or a date and time format.
	/// </summary>
	[Serializable]
	[XmlType("DateAndDateTimeChoice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record DateAndDateTimeChoice
	{
		/// <summary>
		/// Gets specified date.
		/// </summary>
		[XmlElement("Dt")]
		public LocalDate? Date { get; init; }

		/// <summary>
		/// Gets specified date and time.
		/// </summary>
		[XmlElement("DtTm")]
		public LocalDateTime? DateTime { get; init; }
	}
}
