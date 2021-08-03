using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("AccountIdentification4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AccountIdentification4Choice
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}")]
		[XmlElement("IBAN")]
		public string IBAN { get; set; }

		[XmlElement("Othr")]
		public GenericAccountIdentification1 Othr { get; set; }
	}
}
