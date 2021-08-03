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
	/// Coded or proprietary format balance type.
	/// </summary>
	[Serializable]
	[XmlType("BalanceType5Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BalanceType5Choice
	{
		/// <summary>
		/// Gets balance type, in a coded form.
		/// </summary>
		[XmlElement("Cd")]
		public BalanceType12Code? Code { get; init; }

		/// <summary>
		/// Gets balance type, in a proprietary form.
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Prtry")]
		public string? Proprietary { get; init; }
	}
}
