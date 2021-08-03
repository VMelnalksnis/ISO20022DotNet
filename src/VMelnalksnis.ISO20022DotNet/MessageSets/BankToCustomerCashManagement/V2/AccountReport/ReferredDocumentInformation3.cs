using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("ReferredDocumentInformation3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ReferredDocumentInformation3
	{
		[XmlElement("Tp")]
		public ReferredDocumentType2 Tp { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Nb")]
		public string Nb { get; init; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("RltdDt", DataType = "date")]
		public DateTime RltdDtValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the RltdDt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RltdDtValueSpecified { get; init; }

		[XmlIgnore]
		public DateTime? RltdDt
		{
			get
			{
				if (RltdDtValueSpecified)
				{
					return RltdDtValue;
				}

				return null;
			}
			init
			{
				RltdDtValue = value.GetValueOrDefault();
				RltdDtValueSpecified = value.HasValue;
			}
		}
	}
}
