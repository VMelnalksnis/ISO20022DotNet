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

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
	/// </summary>
	/// <remarks>
	/// Either Proprietary or Domain or both must be present.<br/>
	/// If a specific (non-generic) Family code is not present,
	/// then a specific (non-generic) SubFamily code is not allowed.
	/// </remarks>
	[Serializable]
	[XmlType("BankTransactionCodeStructure4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BankTransactionCodeStructure4
	{
		/// <summary>
		/// Gets set of elements used to provide the domain, the family and the sub-family of the bank transaction code,
		/// in a structured and hierarchical format.
		/// </summary>
		/// <remarks>
		/// If a specific family or sub-family code cannot be provided, the generic family code defined
		/// for the domain or the generic sub-family code defined for the family should be provided.
		/// </remarks>
		[XmlElement("Domn")]
		public BankTransactionCodeStructure5? Domain { get; init; }

		/// <summary>
		/// Gets bank transaction code in a proprietary form, as defined by the issuer.
		/// </summary>
		[XmlElement("Prtry")]
		public ProprietaryBankTransactionCodeStructure1? Proprietary { get; init; }
	}
}
