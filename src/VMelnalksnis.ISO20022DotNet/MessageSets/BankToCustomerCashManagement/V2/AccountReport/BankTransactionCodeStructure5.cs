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
	/// Set of elements used to provide the domain, the family and the sub-family of the bank transaction code,
	/// in a structured and hierarchical format.
	/// </summary>
	/// <remarks>
	/// If a specific family or sub-family code cannot be provided, the generic family code defined
	/// for the domain or the generic sub-family code defined for the family should be provided.
	/// </remarks>
	[Serializable]
	[XmlType("BankTransactionCodeStructure5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BankTransactionCodeStructure5
	{
		/// <summary>
		/// Gets the business area of the underlying transaction.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 4.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(4)]
		[Required]
		[XmlElement("Cd")]
		public string Code { get; init; } = string.Empty;

		/// <summary>
		/// Gets the family and the sub-family of the bank transaction code, within a specific domain,
		/// in a structured and hierarchical format.
		/// </summary>
		[Required]
		[XmlElement("Fmly")]
		public BankTransactionCodeStructure6 Family { get; init; } = null!;
	}
}
