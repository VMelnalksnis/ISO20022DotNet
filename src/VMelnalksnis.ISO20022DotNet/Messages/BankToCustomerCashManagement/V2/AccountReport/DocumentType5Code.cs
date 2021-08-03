using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("DocumentType5Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	public enum DocumentType5Code
	{
		MSIN,

		CNFA,

		DNFA,

		CINV,

		CREN,

		DEBN,

		HIRI,

		SBIN,

		CMCN,

		SOAC,

		DISP,

		BOLD,

		VCHR,

		AROI,

		TSUT,
	}
}
