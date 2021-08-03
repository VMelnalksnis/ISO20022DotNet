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
	/// The <see cref="BankToCustomerAccountReportV02"/> message is sent by the account servicer to an account owner or
	/// to a party authorised by the account owner to receive the message.
	/// It can be used to inform the account owner, or authorised party, of the entries reported to the account,
	/// and/or to provide the owner with balance information on the account at a given point in time.
	/// </summary>
	/// <remarks>
	/// The <see cref="BankToCustomerAccountReportV02"/> message can contain reports for more than one account.
	/// It provides information for cash management and/or reconciliation.<br/>
	/// It can be used to:
	/// <list type="bullet">
	/// <item>report pending and booked items;</item>
	/// <item> provide balance information.</item>
	/// </list>
	/// It can include underlying details of transactions that have been included in the entry.
	/// It is possible that the receiver of the message is not the account owner,
	/// but a party entitled by the account owner to receive the account information (also known as recipient).
	/// For a statement, the Bank-to-Customer Account Statement message should be used.
	/// </remarks>
	[Serializable]
	[XmlType("BankToCustomerAccountReportV02", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BankToCustomerAccountReportV02
	{
		[XmlIgnore]
		private Collection<AccountReport11> _reports = new();

		/// <summary>
		/// Gets the header. This building block is mandatory and present once.
		/// It contains elements such as Message Identification and CreationDateTime.
		/// </summary>
		[Required]
		[XmlElement("GrpHdr")]
		public GroupHeader42 GroupHeader { get; init; } = null!;

		/// <summary>
		/// Gets the reports.
		/// This building block is mandatory and repetitive.
		/// It should be repeated for each account on which a report is provided.
		/// The report contains components such as Balance and Entry.
		/// </summary>
		[Required]
		[XmlElement("Rpt")]
		public Collection<AccountReport11> Reports
		{
			get => _reports;
			private set => _reports = value;
		}
	}
}
