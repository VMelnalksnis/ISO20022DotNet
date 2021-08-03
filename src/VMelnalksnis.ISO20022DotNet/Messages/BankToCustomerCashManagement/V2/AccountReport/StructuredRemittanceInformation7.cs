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
	[XmlType("StructuredRemittanceInformation7", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record StructuredRemittanceInformation7
	{
		[XmlIgnore]
		private System.Collections.ObjectModel.Collection<ReferredDocumentInformation3> _rfrdDocInf;

		[XmlElement("RfrdDocInf")]
		public System.Collections.ObjectModel.Collection<ReferredDocumentInformation3> RfrdDocInf
		{
			get => _rfrdDocInf;
			private set => _rfrdDocInf = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the RfrdDocInf collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool RfrdDocInfSpecified => RfrdDocInf.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="StructuredRemittanceInformation7" /> class.</para>
		/// </summary>
		public StructuredRemittanceInformation7()
		{
			_rfrdDocInf = new();
			_addtlRmtInf = new();
		}

		[XmlElement("RfrdDocAmt")]
		public RemittanceAmount1 RfrdDocAmt { get; set; }

		[XmlElement("CdtrRefInf")]
		public CreditorReferenceInformation2 CdtrRefInf { get; set; }

		[XmlElement("Invcr")]
		public PartyIdentification32 Invcr { get; set; }

		[XmlElement("Invcee")]
		public PartyIdentification32 Invcee { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<string> _addtlRmtInf;

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("AddtlRmtInf")]
		public System.Collections.ObjectModel.Collection<string> AddtlRmtInf
		{
			get => _addtlRmtInf;
			private set => _addtlRmtInf = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the AddtlRmtInf collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool AddtlRmtInfSpecified => AddtlRmtInf.Count != 0;
	}
}
