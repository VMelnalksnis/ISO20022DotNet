using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TotalTransactions2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TotalTransactions2
	{
		[XmlElement("TtlNtries")]
		public NumberAndSumOfTransactions2 TtlNtries { get; init; }

		[XmlElement("TtlCdtNtries")]
		public NumberAndSumOfTransactions1 TtlCdtNtries { get; init; }

		[XmlElement("TtlDbtNtries")]
		public NumberAndSumOfTransactions1 TtlDbtNtries { get; init; }

		[XmlIgnore]
		private System.Collections.ObjectModel.Collection<TotalsPerBankTransactionCode2> _ttlNtriesPerBkTxCd;

		[XmlElement("TtlNtriesPerBkTxCd")]
		public System.Collections.ObjectModel.Collection<TotalsPerBankTransactionCode2> TtlNtriesPerBkTxCd
		{
			get => _ttlNtriesPerBkTxCd;
			private set => _ttlNtriesPerBkTxCd = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the TtlNtriesPerBkTxCd collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool TtlNtriesPerBkTxCdSpecified => TtlNtriesPerBkTxCd.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TotalTransactions2" /> class.</para>
		/// </summary>
		public TotalTransactions2()
		{
			_ttlNtriesPerBkTxCd = new();
		}
	}
}
