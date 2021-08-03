using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TaxPeriod1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TaxPeriod1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Yr", DataType = "date")]
		public DateTime YrValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Yr property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool YrValueSpecified { get; init; }

		[XmlIgnore]
		public DateTime? Yr
		{
			get
			{
				if (YrValueSpecified)
				{
					return YrValue;
				}

				return null;
			}
			init
			{
				YrValue = value.GetValueOrDefault();
				YrValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Tp")]
		public TaxRecordPeriod1Code TpValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Tp property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TpValueSpecified { get; init; }

		[XmlIgnore]
		public TaxRecordPeriod1Code? Tp
		{
			get
			{
				if (TpValueSpecified)
				{
					return TpValue;
				}

				return null;
			}
			init
			{
				TpValue = value.GetValueOrDefault();
				TpValueSpecified = value.HasValue;
			}
		}

		[XmlElement("FrToDt")]
		public DatePeriodDetails FrToDt { get; init; }
	}
}
