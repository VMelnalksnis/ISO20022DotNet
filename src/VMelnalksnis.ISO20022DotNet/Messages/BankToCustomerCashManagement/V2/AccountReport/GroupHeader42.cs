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
	/// Common information for the message.
	/// </summary>
	[Serializable]
	[XmlType("GroupHeader42", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record GroupHeader42
	{
		/// <summary>
		/// Gets point to point reference, as assigned by the account servicing institution,
		/// and sent to the account owner or the party authorised to receive the message,
		/// to unambiguously identify the message.
		/// </summary>
		/// <remarks>
		/// The account servicing institution has to make sure that MessageIdentification is unique per account owner for a pre-agreed period.
		/// </remarks>
		[MinLength(1)]
		[MaxLength(35)]
		[Required]
		[XmlElement("MsgId")]
		public string MessageIdentification { get; init; } = string.Empty;

		/// <summary>
		/// Gets date and time at which the message was created.
		/// </summary>
		[Required]
		[XmlElement("CreDtTm", DataType = "dateTime")]
		public DateTime CreationDateTime { get; init; }

		/// <summary>
		/// Gets party authorised by the account owner to receive information about movements on the account.
		/// </summary>
		/// <remarks>
		/// MessageRecipient should only be identified when different from the account owner.
		/// </remarks>
		[XmlElement("MsgRcpt")]
		public PartyIdentification32? MessageRecipient { get; init; }

		/// <summary>
		/// Gets set of elements used to provide details on the page number of the message.
		/// </summary>
		/// <remarks>
		/// The pagination of the message is only allowed when agreed between the parties.
		/// </remarks>
		[XmlElement("MsgPgntn")]
		public Pagination? Pagination { get; init; }

		/// <summary>
		/// Gets further details of the message.
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlInf")]
		public string? AdditionalInformation { get; init; }
	}
}
