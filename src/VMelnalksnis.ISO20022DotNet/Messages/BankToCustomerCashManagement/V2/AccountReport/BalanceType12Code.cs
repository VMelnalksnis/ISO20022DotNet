using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("BalanceType12Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	public enum BalanceType12Code
	{
		XPCD,

		OPAV,

		ITAV,

		CLAV,

		FWAV,

		CLBD,

		ITBD,

		OPBD,

		PRCD,

		INFO,
	}
}
