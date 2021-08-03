using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("AccountInterest2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AccountInterest2
	{
		[XmlElement("Tp")]
		public InterestType1Choice Tp { get; set; }

		[XmlIgnore]
		private Collection<Rate3> _rate = new();

		[XmlElement("Rate")]
		public Collection<Rate3> Rate
		{
			get => _rate;
			private set => _rate = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Rate collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool RateSpecified => Rate.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="AccountInterest2" /> class.</para>
		/// </summary>
		public AccountInterest2()
		{
			_rate = new();
		}

		[XmlElement("FrToDt")]
		public DateTimePeriodDetails FrToDt { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Rsn")]
		public string Rsn { get; set; }
	}
}
