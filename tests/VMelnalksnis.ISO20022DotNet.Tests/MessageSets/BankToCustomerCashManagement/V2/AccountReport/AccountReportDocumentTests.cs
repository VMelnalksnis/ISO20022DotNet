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
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using FluentAssertions;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;

using NodaTime;

using NUnit.Framework;

using VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport;

namespace VMelnalksnis.ISO20022DotNet.Tests.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	public class AccountReportDocumentTests
	{
		[Test]
		public void ReadActualDocument()
		{
			var creationInstant = Instant.FromUtc(2001, 12, 17, 09, 30, 47);
			var date = new LocalDate(2001, 12, 17);

			var expectedDocument = new Document
			{
				BankToCustomerAccountReport = new()
				{
					GroupHeader = new()
					{
						MessageIdentification = "STMT20130710193521",
						CreationDateTime = creationInstant,
					},
					Reports =
					{
						new AccountReport11
						{
							Identification = "5074322222537",
							CreationDateTime = creationInstant,
							FromToDate = new()
							{
								FrDtTm = creationInstant,
								ToDtTm = creationInstant,
							},
							Account = new()
							{
								Identification = new() { Iban = "LV12TEST000000000001" },
								Currency = "USD",
								Servicer = new()
								{
									FinancialInstitutionIdentification = new() { Bic = "TESTLV22" },
								},
							},
							Balance =
							{
								new CashBalance3
								{
									Type = new()
									{
										CodeOrProprietary = new() { Code = BalanceType12Code.OPBD },
									},
									Amount = new() { Value = 500, Currency = "USD" },
									CreditDebitIndicator = CreditDebitCode.CRDT,
									Date = new() { Date = date },
								},
							},
							Entry =
							{
								new ReportEntry2
								{
									Amount = new() { Value = 3, Currency = "USD" },
									CreditDebitIndicator = CreditDebitCode.DBIT,
									Status = EntryStatus2Code.BOOK,
									BookingDate = new() { Date = date },
									AccountServicerReference = "123456789",
									BankTransactionCode = new()
									{
										Domain = new()
										{
											Code = "PMNT",
											Family = new() { Code = "CCRD", SubFamilyCode = "FEES" },
										},
									},
									EntryDetails =
									{
										new EntryDetails1
										{
											TransactionDetails =
											{
												new EntryTransaction2
												{
													RemittanceInformation = new()
													{
														Unstructured = { "Komisijas maksa" },
													},
												},
											},
										},
									},
								},
								new ReportEntry2
								{
									Amount = new() { Value = 128.2m, Currency = "USD" },
									CreditDebitIndicator = CreditDebitCode.DBIT,
									Status = EntryStatus2Code.BOOK,
									BookingDate = new() { Date = date },
									AccountServicerReference = "12334567234",
									BankTransactionCode = new()
									{
										Domain = new()
										{
											Code = "PMNT",
											Family = new() { Code = "ICDT", SubFamilyCode = "DMCT" },
										},
									},
									EntryDetails =
									{
										new EntryDetails1
										{
											TransactionDetails =
											{
												new EntryTransaction2
												{
													References = new() { EndToEndIdentification = "34" },
													AmountDetails = new()
													{
														InstructedAmount = new()
														{
															Amount = new() { Value = 100, Currency = "EUR" },
														},
														TransactionAmount = new()
														{
															Amount = new() { Value = 128.2m, Currency = "USD" },
															CurrencyExchange = new()
															{
																SourceCurrency = "USD",
																TargetCurrency = "EUR",
																UnitCurrency = "USD",
																ExchangeRate = 1.282m,
															},
														},
													},
													RelatedParties = new()
													{
														Creditor = new()
														{
															Name = "Gatis Egle",
															Identification = new()
															{
																PrivateIdentification = new()
																{
																	Other =
																	{
																		new GenericPersonIdentification1
																		{
																			Identification = "121212-12121",
																		},
																	},
																},
															},
														},
														CreditorAccount = new()
														{
															Identification = new() { Iban = "LV21TEST0000000000002" },
														},
													},
													RemittanceInformation = new()
													{
														Unstructured = { "Parvedums ar konvertaciju" },
													},
												},
											},
										},
									},
								},
							},
						},
					},
				},
			};

			var directory = Path.Combine(
				TestContext.CurrentContext.TestDirectory,
				"MessageSets/BankToCustomerCashManagement/V2/AccountReport/");

			var schemaFilePath = Path.Combine(directory, "camt.052.001.02.xsd");
			var schemas = new XmlSchemaSet();
			using var schemaStream = File.OpenRead(schemaFilePath);
			var schemaXmlReader = XmlReader.Create(schemaStream);
			schemas.Add("urn:iso:std:iso:20022:tech:xsd:camt.052.001.02", schemaXmlReader);

			var xmlSettings = new XmlReaderSettings
			{
				Schemas = schemas,
				ValidationType = ValidationType.Schema,
				ValidationFlags =
					XmlSchemaValidationFlags.ProcessIdentityConstraints |
					XmlSchemaValidationFlags.ReportValidationWarnings,
			};

			var exceptions = new List<Exception>();
			xmlSettings.ValidationEventHandler += (_, args) =>
			{
				if (args.Severity == XmlSeverityType.Warning)
				{
					Console.WriteLine(args.Message);
					return;
				}

				exceptions.Add(args.Exception);
				Console.WriteLine(args.Exception.ToString());
			};

			var dataFilePath = Path.Combine(directory, "BankToCustomerAccountReportV02.xml");
			using var stream = File.OpenRead(dataFilePath);
			using var xmlReader = XmlReader.Create(stream, xmlSettings);
			var serializer = new XmlSerializer(typeof(Document));
			var document = (Document)serializer.Deserialize(xmlReader)!;

			using (new AssertionScope())
			{
				exceptions.Should().BeEmpty();
				document.Should().BeEquivalentTo(expectedDocument, Config);
			}
		}

		private static EquivalencyAssertionOptions<Document> Config(EquivalencyAssertionOptions<Document> options)
		{
			return options
				.ComparingByMembers<Document>()
				.ComparingByMembers<BankToCustomerAccountReportV02>()
				.ComparingByMembers<GroupHeader42>()
				.ComparingByMembers<AccountReport11>()
				.ComparingByMembers<DateTimePeriodDetails>()
				.ComparingByMembers<CashAccount20>()
				.ComparingByMembers<AccountIdentification4Choice>()
				.ComparingByMembers<BranchAndFinancialInstitutionIdentification4>()
				.ComparingByMembers<FinancialInstitutionIdentification7>()
				.ComparingByMembers<CashBalance3>()
				.ComparingByMembers<BalanceType12>()
				.ComparingByMembers<BalanceType5Choice>()
				.ComparingByMembers<ActiveOrHistoricCurrencyAndAmount>()
				.ComparingByMembers<DateAndDateTimeChoice>()
				.ComparingByMembers<CashBalanceAvailability2>()
				.ComparingByMembers<ReportEntry2>()
				.ComparingByMembers<EntryDetails1>()
				.ComparingByMembers<EntryTransaction2>()
				.ComparingByMembers<RemittanceInformation5>()
				.ComparingByMembers<AmountAndCurrencyExchange3>()
				.ComparingByMembers<TransactionParty2>()
				.ComparingByMembers<PartyIdentification32>()
				.ComparingByMembers<PersonIdentification5>()
				.ComparingByMembers<Party6Choice>();
		}
	}
}
