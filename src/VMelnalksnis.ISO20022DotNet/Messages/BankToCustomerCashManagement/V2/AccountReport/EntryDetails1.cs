using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("EntryDetails1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record EntryDetails1
	{
		[XmlElement("Btch")]
		public BatchInformation2 Btch { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<EntryTransaction2> _txDtls;

		[XmlElement("TxDtls")]
		public System.Collections.ObjectModel.Collection<EntryTransaction2> TxDtls
		{
			get => _txDtls;
			private set => _txDtls = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the TxDtls collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool TxDtlsSpecified => TxDtls.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="EntryDetails1" /> class.</para>
		/// </summary>
		public EntryDetails1()
		{
			_txDtls = new();
		}
	}
}
