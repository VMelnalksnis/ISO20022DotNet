using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TransactionDates2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionDates2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("AccptncDtTm", DataType = "dateTime")]
		public DateTime AccptncDtTmValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the AccptncDtTm property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AccptncDtTmValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? AccptncDtTm
		{
			get
			{
				if (AccptncDtTmValueSpecified)
				{
					return AccptncDtTmValue;
				}

				return null;
			}
			set
			{
				AccptncDtTmValue = value.GetValueOrDefault();
				AccptncDtTmValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("TradActvtyCtrctlSttlmDt", DataType = "date")]
		public DateTime TradActvtyCtrctlSttlmDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the TradActvtyCtrctlSttlmDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TradActvtyCtrctlSttlmDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? TradActvtyCtrctlSttlmDt
		{
			get
			{
				if (TradActvtyCtrctlSttlmDtValueSpecified)
				{
					return TradActvtyCtrctlSttlmDtValue;
				}

				return null;
			}
			set
			{
				TradActvtyCtrctlSttlmDtValue = value.GetValueOrDefault();
				TradActvtyCtrctlSttlmDtValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("TradDt", DataType = "date")]
		public DateTime TradDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the TradDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TradDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? TradDt
		{
			get
			{
				if (TradDtValueSpecified)
				{
					return TradDtValue;
				}

				return null;
			}
			set
			{
				TradDtValue = value.GetValueOrDefault();
				TradDtValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("IntrBkSttlmDt", DataType = "date")]
		public DateTime IntrBkSttlmDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the IntrBkSttlmDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool IntrBkSttlmDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? IntrBkSttlmDt
		{
			get
			{
				if (IntrBkSttlmDtValueSpecified)
				{
					return IntrBkSttlmDtValue;
				}

				return null;
			}
			set
			{
				IntrBkSttlmDtValue = value.GetValueOrDefault();
				IntrBkSttlmDtValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("StartDt", DataType = "date")]
		public DateTime StartDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the StartDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool StartDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? StartDt
		{
			get
			{
				if (StartDtValueSpecified)
				{
					return StartDtValue;
				}

				return null;
			}
			set
			{
				StartDtValue = value.GetValueOrDefault();
				StartDtValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("EndDt", DataType = "date")]
		public DateTime EndDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the EndDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool EndDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? EndDt
		{
			get
			{
				if (EndDtValueSpecified)
				{
					return EndDtValue;
				}

				return null;
			}
			set
			{
				EndDtValue = value.GetValueOrDefault();
				EndDtValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("TxDtTm", DataType = "dateTime")]
		public DateTime TxDtTmValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the TxDtTm property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TxDtTmValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? TxDtTm
		{
			get
			{
				if (TxDtTmValueSpecified)
				{
					return TxDtTmValue;
				}

				return null;
			}
			set
			{
				TxDtTmValue = value.GetValueOrDefault();
				TxDtTmValueSpecified = value.HasValue;
			}
		}

		[XmlIgnore] private System.Collections.ObjectModel.Collection<ProprietaryDate2> _prtry;

		[XmlElement("Prtry")]
		public System.Collections.ObjectModel.Collection<ProprietaryDate2> Prtry
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
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionDates2" /> class.</para>
		/// </summary>
		public TransactionDates2()
		{
			_prtry = new();
		}
	}
}
