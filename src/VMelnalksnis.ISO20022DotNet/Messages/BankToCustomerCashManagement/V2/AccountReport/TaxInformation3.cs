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
	[XmlType("TaxInformation3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TaxInformation3
	{
		[XmlElement("Cdtr")]
		public TaxParty1 Cdtr { get; init; }

		[XmlElement("Dbtr")]
		public TaxParty2 Dbtr { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("AdmstnZn")]
		public string AdmstnZn { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("RefNb")]
		public string RefNb { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Mtd")]
		public string Mtd { get; init; }

		[XmlElement("TtlTaxblBaseAmt")]
		public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; init; }

		[XmlElement("TtlTaxAmt")]
		public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; init; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Dt", DataType = "date")]
		public DateTime DtValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Dt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool DtValueSpecified { get; init; }

		[XmlIgnore]
		public DateTime? Dt
		{
			get
			{
				if (DtValueSpecified)
				{
					return DtValue;
				}

				return null;
			}
			init
			{
				DtValue = value.GetValueOrDefault();
				DtValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("SeqNb")]
		public decimal SeqNbValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the SeqNb property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool SeqNbValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? SeqNb
		{
			get
			{
				if (SeqNbValueSpecified)
				{
					return SeqNbValue;
				}

				return null;
			}
			init
			{
				SeqNbValue = value.GetValueOrDefault();
				SeqNbValueSpecified = value.HasValue;
			}
		}

		[XmlIgnore] private System.Collections.ObjectModel.Collection<TaxRecord1> _rcrd;

		[XmlElement("Rcrd")]
		public System.Collections.ObjectModel.Collection<TaxRecord1> Rcrd
		{
			get => _rcrd;
			private set => _rcrd = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Rcrd collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool RcrdSpecified => Rcrd.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TaxInformation3" /> class.</para>
		/// </summary>
		public TaxInformation3()
		{
			_rcrd = new();
		}
	}
}
