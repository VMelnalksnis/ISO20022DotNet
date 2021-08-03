using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TaxAmount1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TaxAmount1
	{
		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Rate")]
		public decimal RateValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RateValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 10.</para>
		/// <para xml:lang="en">Total number of digits: 11.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? Rate
		{
			get
			{
				if (RateValueSpecified)
				{
					return RateValue;
				}

				return null;
			}
			init
			{
				RateValue = value.GetValueOrDefault();
				RateValueSpecified = value.HasValue;
			}
		}

		[XmlElement("TaxblBaseAmt")]
		public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; init; }

		[XmlElement("TtlAmt")]
		public ActiveOrHistoricCurrencyAndAmount TtlAmt { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<TaxRecordDetails1> _dtls;

		[XmlElement("Dtls")]
		public System.Collections.ObjectModel.Collection<TaxRecordDetails1> Dtls
		{
			get => _dtls;
			private set => _dtls = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Dtls collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool DtlsSpecified => Dtls.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TaxAmount1" /> class.</para>
		/// </summary>
		public TaxAmount1()
		{
			_dtls = new();
		}
	}
}
