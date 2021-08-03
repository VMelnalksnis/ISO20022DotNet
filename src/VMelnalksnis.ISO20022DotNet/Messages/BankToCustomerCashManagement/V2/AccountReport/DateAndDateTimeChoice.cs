using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("DateAndDateTimeChoice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record DateAndDateTimeChoice
	{
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("DtTm", DataType = "dateTime")]
		public DateTime DtTmValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the DtTm property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool DtTmValueSpecified { get; init; }

		[XmlIgnore]
		public DateTime? DtTm
		{
			get
			{
				if (DtTmValueSpecified)
				{
					return DtTmValue;
				}

				return null;
			}
			init
			{
				DtTmValue = value.GetValueOrDefault();
				DtTmValueSpecified = value.HasValue;
			}
		}
	}
}
