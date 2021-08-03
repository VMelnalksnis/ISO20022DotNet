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
	[XmlType("AccountReport11", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AccountReport11
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[Required]
		[XmlElement("Id")]
		public string Id { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("ElctrncSeqNb")]
		public decimal ElctrncSeqNbValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the ElctrncSeqNb property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ElctrncSeqNbValueSpecified { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? ElctrncSeqNb
		{
			get
			{
				if (ElctrncSeqNbValueSpecified)
				{
					return ElctrncSeqNbValue;
				}

				return null;
			}
			set
			{
				ElctrncSeqNbValue = value.GetValueOrDefault();
				ElctrncSeqNbValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("LglSeqNb")]
		public decimal LglSeqNbValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the LglSeqNb property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool LglSeqNbValueSpecified { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 0.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? LglSeqNb
		{
			get
			{
				if (LglSeqNbValueSpecified)
				{
					return LglSeqNbValue;
				}

				return null;
			}
			set
			{
				LglSeqNbValue = value.GetValueOrDefault();
				LglSeqNbValueSpecified = value.HasValue;
			}
		}

		[Required]
		[XmlElement("CreDtTm", DataType = "dateTime")]
		public DateTime CreDtTm { get; set; }

		[XmlElement("FrToDt")]
		public DateTimePeriodDetails FrToDt { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("CpyDplctInd")]
		public CopyDuplicate1Code CpyDplctIndValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the CpyDplctInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CpyDplctIndValueSpecified { get; set; }

		[XmlIgnore]
		public CopyDuplicate1Code? CpyDplctInd
		{
			get
			{
				if (CpyDplctIndValueSpecified)
				{
					return CpyDplctIndValue;
				}

				return null;
			}
			set
			{
				CpyDplctIndValue = value.GetValueOrDefault();
				CpyDplctIndValueSpecified = value.HasValue;
			}
		}

		[XmlElement("RptgSrc")]
		public ReportingSource1Choice RptgSrc { get; set; }

		[Required]
		[XmlElement("Acct")]
		public CashAccount20 Acct { get; set; }

		[XmlElement("RltdAcct")]
		public CashAccount16 RltdAcct { get; set; }

		[XmlIgnore] private Collection<AccountInterest2> _intrst;

		[XmlElement("Intrst")]
		public Collection<AccountInterest2> Intrst
		{
			get => _intrst;
			private set => _intrst = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Intrst collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool IntrstSpecified => Intrst.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="AccountReport11" /> class.</para>
		/// </summary>
		public AccountReport11()
		{
			_intrst = new();
			_bal = new();
			_ntry = new();
		}

		[XmlIgnore] private Collection<CashBalance3> _bal;

		[XmlElement("Bal")]
		public Collection<CashBalance3> Bal
		{
			get => _bal;
			private set => _bal = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Bal collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool BalSpecified => Bal.Count != 0;

		[XmlElement("TxsSummry")]
		public TotalTransactions2 TxsSummry { get; set; }

		[XmlIgnore] private Collection<ReportEntry2> _ntry;

		[XmlElement("Ntry")]
		public Collection<ReportEntry2> Ntry
		{
			get => _ntry;
			private set => _ntry = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Ntry collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool NtrySpecified => Ntry.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 500.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(500)]
		[XmlElement("AddtlRptInf")]
		public string AddtlRptInf { get; set; }
	}
}
