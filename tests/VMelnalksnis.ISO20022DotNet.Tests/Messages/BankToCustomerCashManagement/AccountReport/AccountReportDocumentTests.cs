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
using System.IO;
using System.Xml.Serialization;

using FluentAssertions;
using FluentAssertions.Execution;

using NUnit.Framework;

using VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.AccountReport;

namespace VMelnalksnis.ISO20022DotNet.Tests.Messages.BankToCustomerCashManagement.AccountReport
{
	public class AccountReportDocumentTests
	{
		[Test]
		public void ReadDocument()
		{
			var serializer = new XmlSerializer(typeof(Document));
			const string xmlContent = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Document xmlns=""urn:iso:std:iso:20022:tech:xsd:camt.052.001.09"">
	<BkToCstmrAcctRpt>
		<GrpHdr>
			<MsgId>R/NL41INGB8611765885/00012345678</MsgId>
			<CreDtTm>2021-08-02T17:14:12</CreDtTm>
		</GrpHdr>
	</BkToCstmrAcctRpt>
</Document>";

			using var xmlStream = CreateStreamFromString(xmlContent);
			var document = (Document)serializer.Deserialize(xmlStream)!;
			document.Should().NotBeNull();
			document.AccountReport.Should().NotBeNull();

			var groupHeader = document.AccountReport.GroupHeader;
			using (new AssertionScope())
			{
				groupHeader.MessageIdentification.Should().Be("R/NL41INGB8611765885/00012345678");
				groupHeader.CreationDateTimeRaw.Should().Be("2021-08-02T17:14:12");
				groupHeader.CreationDateTime.Should().Be(new(2021, 08, 02, 17, 14, 12, DateTimeOffset.Now.Offset));
				groupHeader.AdditionalInformation.Should().BeNull();
			}
		}

		private static Stream CreateStreamFromString(string value)
		{
			var memoryStream = new MemoryStream();
			var streamWriter = new StreamWriter(memoryStream);

			streamWriter.Write(value);
			streamWriter.Flush();
			memoryStream.Position = 0;

			return memoryStream;
		}
	}
}
