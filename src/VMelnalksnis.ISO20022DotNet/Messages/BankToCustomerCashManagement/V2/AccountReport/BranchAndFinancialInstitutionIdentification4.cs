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
	/// Party that manages the account on behalf of the account owner,
	/// that is manages the registration and booking of entries on the account,
	/// calculates balances on the account and provides information about the account.
	/// </summary>
	[Serializable]
	[XmlType(
		"BranchAndFinancialInstitutionIdentification4",
		Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BranchAndFinancialInstitutionIdentification4
	{
		/// <summary>
		/// Gets unique and unambiguous identification of a financial institution,
		/// as assigned under an internationally recognised or proprietary identification scheme.
		/// </summary>
		[Required]
		[XmlElement("FinInstnId")]
		public FinancialInstitutionIdentification7 FinancialInstitutionIdentification { get; init; } = null!;

		/// <summary>
		/// Gets a specific branch of a financial institution.
		/// </summary>
		/// <remarks>
		/// This component should be used in case the identification information in the financial institution component
		/// does not provide identification up to branch level.
		/// </remarks>
		[XmlElement("BrnchId")]
		public BranchData2? BranchIdentification { get; init; }
	}
}
