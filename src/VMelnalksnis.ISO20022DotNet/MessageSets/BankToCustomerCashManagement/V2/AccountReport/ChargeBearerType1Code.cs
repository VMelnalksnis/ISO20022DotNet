using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("ChargeBearerType1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	public enum ChargeBearerType1Code
	{
		DEBT,

		CRED,

		SHAR,

		SLEV,
	}
}
