using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("FinancialInstrumentQuantityChoice",
		Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record FinancialInstrumentQuantityChoice
	{
		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Unit")]
		public decimal UnitValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Unit property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool UnitValueSpecified { get; set; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? Unit
		{
			get
			{
				if (UnitValueSpecified)
				{
					return UnitValue;
				}

				return null;
			}
			set
			{
				UnitValue = value.GetValueOrDefault();
				UnitValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("FaceAmt")]
		public decimal FaceAmtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the FaceAmt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool FaceAmtValueSpecified { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? FaceAmt
		{
			get
			{
				if (FaceAmtValueSpecified)
				{
					return FaceAmtValue;
				}

				return null;
			}
			set
			{
				FaceAmtValue = value.GetValueOrDefault();
				FaceAmtValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("AmtsdVal")]
		public decimal AmtsdValValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the AmtsdVal property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AmtsdValValueSpecified { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? AmtsdVal
		{
			get
			{
				if (AmtsdValValueSpecified)
				{
					return AmtsdValValue;
				}

				return null;
			}
			set
			{
				AmtsdValValue = value.GetValueOrDefault();
				AmtsdValValueSpecified = value.HasValue;
			}
		}
	}
}
