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

using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.AccountReport
{
	/// <summary>
	/// The <see cref="BankToCustomerAccountReport"/> message is sent by the account servicer to an account owner or
	/// to a party authorised by the account owner to receive the message.
	/// It can be used to inform the account owner, or authorised party, of the entries reported to the account,
	/// and/or to provide the owner with balance information on the account at a given point in time.
	/// </summary>
	/// <remarks>
	/// The <see cref="BankToCustomerAccountReport"/> message can contain reports for more than one account.
	/// It provides information for cash management and/or reconciliation.
	/// It can be used to:
	/// <list type="bullet">
	///     <item>report pending and booked items;</item>
	///     <item> provide balance information.</item>
	/// </list>
	/// It can include underlying details of transactions that have been included in the entry.
	/// It is possible that the receiver of the message is not the account owner,
	/// but a party entitled by the account owner to receive the account information (also known as recipient).
	/// For a statement, the Bank-to-Customer Account Statement message should be used.
	/// </remarks>
	[XmlRoot("BkToCstmrAcctRpt")]
	public sealed record BankToCustomerAccountReport
	{
		/// <summary>
		/// Gets common information for the message.
		/// </summary>
		[XmlElement("GrpHdr")]
		public GroupHeader GroupHeader { get; init; } = null!;
	}
}
