using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("CashAccountType4Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	public enum CashAccountType4Code
	{
		CASH,

		CHAR,

		COMM,

		TAXE,

		CISH,

		TRAS,

		SACC,

		CACC,

		SVGS,

		ONDP,

		MGLD,

		NREX,

		MOMA,

		LOAN,

		SLRY,

		ODFT,
	}
}
