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
	[XmlType("CashBalance3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CashBalance3
	{
		[Required]
		[XmlElement("Tp")]
		public BalanceType12 Tp { get; set; }

		[XmlElement("CdtLine")]
		public CreditLine2 CdtLine { get; set; }

		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

		[Required]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CdtDbtInd { get; set; }

		[Required]
		[XmlElement("Dt")]
		public DateAndDateTimeChoice Dt { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<CashBalanceAvailability2> _avlbty;

		[XmlElement("Avlbty")]
		public System.Collections.ObjectModel.Collection<CashBalanceAvailability2> Avlbty
		{
			get => _avlbty;
			private set => _avlbty = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Avlbty collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool AvlbtySpecified => Avlbty.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="CashBalance3" /> class.</para>
		/// </summary>
		public CashBalance3()
		{
			_avlbty = new();
		}
	}
}
