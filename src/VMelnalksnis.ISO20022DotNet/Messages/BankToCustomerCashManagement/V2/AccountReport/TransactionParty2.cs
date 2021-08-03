using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TransactionParty2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionParty2
	{
		[XmlElement("InitgPty")]
		public PartyIdentification32 InitgPty { get; set; }

		[XmlElement("Dbtr")]
		public PartyIdentification32 Dbtr { get; set; }

		[XmlElement("DbtrAcct")]
		public CashAccount16 DbtrAcct { get; set; }

		[XmlElement("UltmtDbtr")]
		public PartyIdentification32 UltmtDbtr { get; set; }

		[XmlElement("Cdtr")]
		public PartyIdentification32 Cdtr { get; set; }

		[XmlElement("CdtrAcct")]
		public CashAccount16 CdtrAcct { get; set; }

		[XmlElement("UltmtCdtr")]
		public PartyIdentification32 UltmtCdtr { get; set; }

		[XmlElement("TradgPty")]
		public PartyIdentification32 TradgPty { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<ProprietaryParty2> _prtry;

		[XmlElement("Prtry")]
		public System.Collections.ObjectModel.Collection<ProprietaryParty2> Prtry
		{
			get => _prtry;
			private set => _prtry = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Prtry collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool PrtrySpecified => Prtry.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionParty2" /> class.</para>
		/// </summary>
		public TransactionParty2()
		{
			_prtry = new();
		}
	}
}
