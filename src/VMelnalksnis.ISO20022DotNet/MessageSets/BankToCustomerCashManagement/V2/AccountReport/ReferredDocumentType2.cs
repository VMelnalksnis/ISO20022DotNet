using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("ReferredDocumentType2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ReferredDocumentType2
	{
		[Required]
		[XmlElement("CdOrPrtry")]
		public ReferredDocumentType1Choice CdOrPrtry { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Issr")]
		public string Issr { get; init; }
	}
}
