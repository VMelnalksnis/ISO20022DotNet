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

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Structured information that enables the matching, ie, reconciliation, of a payment with the items
	/// that the payment is intended to settle, such as commercial invoices in an account receivable system.
	/// </summary>
	[Serializable]
	[XmlType("RemittanceInformation5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record RemittanceInformation5
	{
		[XmlIgnore]
		private Collection<string> _unstructured = new();

		[XmlIgnore]
		private Collection<StructuredRemittanceInformation7> _structured = new();

		/// <summary>
		/// Gets information supplied to enable the matching/reconciliation of an entry with the items that the payment is
		/// intended to settle, such as commercial invoices in an accounts' receivable system, in an unstructured form.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("Ustrd")]
		public Collection<string> Unstructured
		{
			get => _unstructured;
			private set => _unstructured = value;
		}

		/// <summary>
		/// Gets information supplied to enable the matching/reconciliation of an entry with the items that the payment is
		/// intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
		/// </summary>
		[XmlElement("Strd")]
		public Collection<StructuredRemittanceInformation7> Structured
		{
			get => _structured;
			private set => _structured = value;
		}
	}
}
