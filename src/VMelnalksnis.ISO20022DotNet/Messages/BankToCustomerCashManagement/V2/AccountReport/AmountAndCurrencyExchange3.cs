using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("AmountAndCurrencyExchange3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AmountAndCurrencyExchange3
	{
		[XmlElement("InstdAmt")]
		public AmountAndCurrencyExchangeDetails3 InstdAmt { get; set; }

		[XmlElement("TxAmt")]
		public AmountAndCurrencyExchangeDetails3 TxAmt { get; set; }

		[XmlElement("CntrValAmt")]
		public AmountAndCurrencyExchangeDetails3 CntrValAmt { get; set; }

		[XmlElement("AnncdPstngAmt")]
		public AmountAndCurrencyExchangeDetails3 AnncdPstngAmt { get; set; }

		[XmlIgnore]
		private System.Collections.ObjectModel.Collection<AmountAndCurrencyExchangeDetails4> _prtryAmt;

		[XmlElement("PrtryAmt")]
		public System.Collections.ObjectModel.Collection<AmountAndCurrencyExchangeDetails4> PrtryAmt
		{
			get => _prtryAmt;
			private set => _prtryAmt = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the PrtryAmt collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool PrtryAmtSpecified => PrtryAmt.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="AmountAndCurrencyExchange3" /> class.</para>
		/// </summary>
		public AmountAndCurrencyExchange3()
		{
			_prtryAmt = new();
		}
	}
}
