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
	[XmlType("BankTransactionCodeStructure5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BankTransactionCodeStructure5
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 4.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(4)]
		[Required]
		[XmlElement("Cd")]
		public string Cd { get; init; }

		[Required]
		[XmlElement("Fmly")]
		public BankTransactionCodeStructure6 Fmly { get; init; }
	}
}
