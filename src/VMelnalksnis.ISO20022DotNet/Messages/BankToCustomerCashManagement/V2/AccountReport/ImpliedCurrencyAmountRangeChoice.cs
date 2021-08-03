using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("ImpliedCurrencyAmountRangeChoice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ImpliedCurrencyAmountRangeChoice
	{
		[XmlElement("FrAmt")]
		public AmountRangeBoundary1 FrAmt { get; init; }

		[XmlElement("ToAmt")]
		public AmountRangeBoundary1 ToAmt { get; init; }

		[XmlElement("FrToAmt")]
		public FromToAmountRange FrToAmt { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("EQAmt")]
		public decimal EQAmtValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the EQAmt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool EQAmtValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? EQAmt
		{
			get
			{
				if (EQAmtValueSpecified)
				{
					return EQAmtValue;
				}

				return null;
			}
			init
			{
				EQAmtValue = value.GetValueOrDefault();
				EQAmtValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("NEQAmt")]
		public decimal NEQAmtValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the NEQAmt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool NEQAmtValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? NEQAmt
		{
			get
			{
				if (NEQAmtValueSpecified)
				{
					return NEQAmtValue;
				}

				return null;
			}
			init
			{
				NEQAmtValue = value.GetValueOrDefault();
				NEQAmtValueSpecified = value.HasValue;
			}
		}
	}
}
