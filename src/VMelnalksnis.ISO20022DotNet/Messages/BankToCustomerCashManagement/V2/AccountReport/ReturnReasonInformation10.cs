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
	[XmlType("ReturnReasonInformation10", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ReturnReasonInformation10
	{
		[XmlElement("OrgnlBkTxCd")]
		public BankTransactionCodeStructure4 OrgnlBkTxCd { get; set; }

		[XmlElement("Orgtr")]
		public PartyIdentification32 Orgtr { get; set; }

		[XmlElement("Rsn")]
		public ReturnReason5Choice Rsn { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<string> _addtlInf;

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 105.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(105)]
		[XmlElement("AddtlInf")]
		public System.Collections.ObjectModel.Collection<string> AddtlInf
		{
			get => _addtlInf;
			private set => _addtlInf = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the AddtlInf collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool AddtlInfSpecified => AddtlInf.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="ReturnReasonInformation10" /> class.</para>
		/// </summary>
		public ReturnReasonInformation10()
		{
			_addtlInf = new();
		}
	}
}
