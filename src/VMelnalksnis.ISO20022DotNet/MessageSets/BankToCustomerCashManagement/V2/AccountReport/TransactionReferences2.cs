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
	/// Set of elements used to provide the identification of the underlying transaction.
	/// </summary>
	[Serializable]
	[XmlType("TransactionReferences2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionReferences2
	{
		/// <summary>
		/// Gets point to point reference, as assigned by the instructing party of the underlying message.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("MsgId")]
		public string? MessageIdentification { get; init; }

		/// <summary>
		/// Gets unique reference, as assigned by the account servicing institution,
		/// to unambiguously identify the instruction.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("AcctSvcrRef")]
		public string? AccountServicerReference { get; init; }

		/// <summary>
		/// Gets unique identification, as assigned by a sending party,
		/// to unambiguously identify the payment information group within the message.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("PmtInfId")]
		public string? PaymentInformationIdentification { get; init; }

		/// <summary>
		/// Gets unique identification, as assigned by an instructing party for an instructed party,
		/// to unambiguously identify the instruction.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		/// <remarks>
		/// The instruction identification is a point to point reference that can be used between
		/// the instructing party and the instructed party to refer to the individual instruction.
		/// It can be included in several messages related to the instruction.
		/// </remarks>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("InstrId")]
		public string? InstructionIdentification { get; init; }

		/// <summary>
		/// Gets unique identification, as assigned by the initiating party, to unambiguously identify the transaction.
		/// This identification is passed on, unchanged, throughout the entire end-to-end chain.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		/// <remarks>
		/// The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.
		/// It can be included in several messages related to the transaction.
		/// In case there are technical limitations to pass on multiple references,
		/// the end-to-end identification must be passed on throughout the entire end-to-end chain.
		/// </remarks>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("EndToEndId")]
		public string? EndToEndIdentification { get; init; }

		/// <summary>
		/// Gets unique identification, as assigned by the first instructing agent,
		/// to unambiguously identify the transaction that is passed on, unchanged,
		/// throughout the entire interbank chain.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		/// <remarks>
		/// The transaction identification can be used for reconciliation,
		/// tracking or to link tasks relating to the transaction on the interbank level.
		/// </remarks>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("TxId")]
		public string? TransactionIdentification { get; init; }

		/// <summary>
		/// Gets unique identification, as assigned by the creditor, to unambiguously identify the mandate.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("MndtId")]
		public string? MandateIdentification { get; init; }

		/// <summary>
		/// Gets unique and unambiguous identifier for a cheque as assigned by the agent.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("ChqNb")]
		public string? ChequeNumber { get; init; }

		/// <summary>
		/// Gets unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		/// <remarks>
		/// In case there are technical limitations to pass on multiple references,
		/// the end-to-end identification must be passed on throughout the entire end-to-end chain.
		/// </remarks>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("ClrSysRef")]
		public string? ClearingSystemReference { get; init; }

		/// <summary>
		/// Gets proprietary reference related to the underlying transaction.
		/// </summary>
		[XmlElement("Prtry")]
		public ProprietaryReference1? Proprietary { get; init; }
	}
}
