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
using System.Globalization;
using System.Xml.Serialization;

using static System.Globalization.DateTimeStyles;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.AccountReport
{
	/// <summary>
	/// Common information for the message.
	/// </summary>
	public sealed record GroupHeader
	{
		private readonly string _creationDateTimeRaw = string.Empty;

		/// <summary>
		/// Gets point to point reference, as assigned by the account servicing institution,
		/// and sent to the account owner or the party authorised to receive the message,
		/// to unambiguously identify the message.
		/// </summary>
		/// <remarks>
		/// The account servicing institution has to make sure that <see cref="MessageIdentification"/>
		/// is unique per account owner for a pre-agreed period.
		/// </remarks>
		[XmlElement("MsgId")]
		public string MessageIdentification { get; init; } = string.Empty;

		/// <summary>
		/// Gets date and time at which the message was created.
		/// </summary>
		/// <remarks>
		/// A particular point in the progression of time defined by a mandatory date and a mandatory
		/// time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with
		/// UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss).
		/// These representations are defined in "XML Schema Part 2: Datatypes Second Edition -
		/// W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br/>
		/// Note on the time format:
		/// <list type="number">
		/// <item>
		/// beginning / end of calendar day<br/>
		/// 00:00:00 = the beginning of a calendar day<br/>
		/// 24:00:00 = the end of a calendar day<br/>
		/// </item>
		/// <item>
		/// fractions of second in time format<br/>
		/// Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the
		/// maximum number of digits that are allowed.
		/// </item>
		/// </list>
		/// </remarks>
		[XmlElement("CreDtTm")]
		public string CreationDateTimeRaw
		{
			get => _creationDateTimeRaw;
			init
			{
				CreationDateTime = DateTimeOffset.Parse(value, DateTimeFormatInfo.InvariantInfo, AssumeLocal);
				_creationDateTimeRaw = value;
			}
		}

		/// <summary>
		/// Gets date and time at which the message was created.
		/// </summary>
		[XmlIgnore]
		public DateTimeOffset CreationDateTime { get; private init; }

		/// <summary>
		/// Gets further details of the message.
		/// </summary>
		[XmlElement("AddtlInf")]
		public string? AdditionalInformation { get; init; }
	}
}
