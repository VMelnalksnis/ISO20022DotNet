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
	/// Specifies the nature of a balance.
	/// </summary>
	[Serializable]
	[XmlType("BalanceType12", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BalanceType12
	{
		/// <summary>
		/// Gets coded or proprietary format balance type.
		/// </summary>
		[Required]
		[XmlElement("CdOrPrtry")]
		public BalanceType5Choice CodeOrProprietary { get; init; } = null!;

		/// <summary>
		/// Gets the balance sub-type.
		/// </summary>
		[XmlElement("SubTp")]
		public BalanceSubType1Choice? SubType { get; init; }
	}
}
