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
	[XmlType("CashBalanceAvailabilityDate1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record CashBalanceAvailabilityDate1
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [+]{0,1}[0-9]{1,15}.</para>
		/// </summary>
		[RegularExpression("[+]{0,1}[0-9]{1,15}")]
		[XmlElement("NbOfDays")]
		public string NbOfDays { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("ActlDt", DataType = "date")]
		public DateTime ActlDtValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the ActlDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ActlDtValueSpecified { get; set; }

		[XmlIgnore]
		public DateTime? ActlDt
		{
			get
			{
				if (ActlDtValueSpecified)
				{
					return ActlDtValue;
				}

				return null;
			}
			set
			{
				ActlDtValue = value.GetValueOrDefault();
				ActlDtValueSpecified = value.HasValue;
			}
		}
	}
}
