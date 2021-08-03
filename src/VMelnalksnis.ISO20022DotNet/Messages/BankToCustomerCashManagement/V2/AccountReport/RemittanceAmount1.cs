using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("RemittanceAmount1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record RemittanceAmount1
	{
		[XmlElement("DuePyblAmt")]
		public ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; init; }

		[XmlElement("DscntApldAmt")]
		public ActiveOrHistoricCurrencyAndAmount DscntApldAmt { get; init; }

		[XmlElement("CdtNoteAmt")]
		public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; init; }

		[XmlElement("TaxAmt")]
		public ActiveOrHistoricCurrencyAndAmount TaxAmt { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<DocumentAdjustment1> _adjstmntAmtAndRsn;

		[XmlElement("AdjstmntAmtAndRsn")]
		public System.Collections.ObjectModel.Collection<DocumentAdjustment1> AdjstmntAmtAndRsn
		{
			get => _adjstmntAmtAndRsn;
			private set => _adjstmntAmtAndRsn = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the AdjstmntAmtAndRsn collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool AdjstmntAmtAndRsnSpecified => AdjstmntAmtAndRsn.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="RemittanceAmount1" /> class.</para>
		/// </summary>
		public RemittanceAmount1()
		{
			_adjstmntAmtAndRsn = new();
		}

		[XmlElement("RmtdAmt")]
		public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; init; }
	}
}
