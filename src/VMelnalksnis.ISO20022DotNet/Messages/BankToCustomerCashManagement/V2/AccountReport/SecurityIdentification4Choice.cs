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
	[XmlType("SecurityIdentification4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record SecurityIdentification4Choice
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z0-9]{12,12}.</para>
		/// </summary>
		[RegularExpression("[A-Z0-9]{12,12}")]
		[XmlElement("ISIN")]
		public string ISIN { get; set; }

		[XmlElement("Prtry")]
		public AlternateSecurityIdentification2 Prtry { get; set; }
	}
}
