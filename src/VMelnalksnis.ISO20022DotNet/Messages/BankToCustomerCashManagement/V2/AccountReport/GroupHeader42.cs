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
	[XmlType("GroupHeader42", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record GroupHeader42
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[Required]
		[XmlElement("MsgId")]
		public string MsgId { get; set; }

		[Required]
		[XmlElement("CreDtTm", DataType = "dateTime")]
		public DateTime CreDtTm { get; set; }

		[XmlElement("MsgRcpt")]
		public PartyIdentification32 MsgRcpt { get; set; }

		[XmlElement("MsgPgntn")]
		public Pagination MsgPgntn { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 500.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlInf")]
		public string AddtlInf { get; set; }
	}
}
