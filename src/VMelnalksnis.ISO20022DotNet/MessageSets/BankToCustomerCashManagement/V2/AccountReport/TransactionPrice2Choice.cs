using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TransactionPrice2Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionPrice2Choice
	{
		[XmlElement("DealPric")]
		public ActiveOrHistoricCurrencyAndAmount DealPric { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<ProprietaryPrice2> _prtry;

		[XmlElement("Prtry")]
		public System.Collections.ObjectModel.Collection<ProprietaryPrice2> Prtry
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
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionPrice2Choice" /> class.</para>
		/// </summary>
		public TransactionPrice2Choice()
		{
			_prtry = new();
		}
	}
}
