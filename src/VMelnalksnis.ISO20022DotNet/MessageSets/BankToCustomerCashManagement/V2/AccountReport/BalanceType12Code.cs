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
using System.Xml.Serialization;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	/// <summary>
	/// Balance type, in a coded form.
	/// </summary>
	[Serializable]
	[XmlType("BalanceType12Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	public enum BalanceType12Code
	{
		/// <summary>
		/// Balance, composed of booked entries and pending items known at the time of calculation,
		/// which projects the end of day balance if everything is booked on the account and no other entry is posted.
		/// </summary>
		XPCD,

		/// <summary>
		/// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
		/// </summary>
		OPAV,

		/// <summary>
		/// Available balance calculated in the course of the account servicer's business day,
		/// at the time specified, and subject to further changes during the business day.
		/// The interim balance is calculated on the basis of
		/// booked credit and debit items during the calculation time/period specified.
		/// </summary>
		ITAV,

		/// <summary>
		/// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
		/// </summary>
		CLAV,

		/// <summary>
		/// Forward available balance of money that is at the disposal of the account owner on the date specified.
		/// </summary>
		FWAV,

		/// <summary>
		/// Balance of the account at the end of the pre-agreed account reporting period.
		/// It is the sum of the opening booked balance at the beginning of the period and all entries booked
		/// to the account during the pre-agreed account reporting period.
		/// </summary>
		CLBD,

		/// <summary>
		/// Balance calculated in the course of the account servicer's business day, at the time specified,
		/// and subject to further changes during the business day.
		/// The interim balance is calculated on the basis of
		/// booked credit and debit items during the calculation time/period specified.
		/// </summary>
		ITBD,

		/// <summary>
		/// Book balance of the account at the beginning of the account reporting period.
		/// It always equals the closing book balance from the previous report.
		/// </summary>
		OPBD,

		/// <summary>
		/// Balance of the account at the previously closed account reporting period.
		/// The opening booked balance for the new period has to be equal to this balance.
		/// </summary>
		/// <remarks>
		/// The previously booked closing balance should equal (inclusive date) the booked closing balance
		/// of the date it references and equal the actual booked opening balance of the current date.
		/// </remarks>
		PRCD,

		/// <summary>
		/// Balance for informational purposes.
		/// </summary>
		INFO,
	}
}
