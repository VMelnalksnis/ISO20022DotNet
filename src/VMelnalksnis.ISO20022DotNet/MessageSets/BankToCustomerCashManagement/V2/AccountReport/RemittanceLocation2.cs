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
	[XmlType("RemittanceLocation2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record RemittanceLocation2
	{
		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("RmtId")]
		public string RmtId { get; init; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("RmtLctnMtd")]
		public RemittanceLocationMethod2Code RmtLctnMtdValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the RmtLctnMtd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RmtLctnMtdValueSpecified { get; init; }

		[XmlIgnore]
		public RemittanceLocationMethod2Code? RmtLctnMtd
		{
			get
			{
				if (RmtLctnMtdValueSpecified)
				{
					return RmtLctnMtdValue;
				}

				return null;
			}
			init
			{
				RmtLctnMtdValue = value.GetValueOrDefault();
				RmtLctnMtdValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 2048.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(2048)]
		[XmlElement("RmtLctnElctrncAdr")]
		public string RmtLctnElctrncAdr { get; init; }

		[XmlElement("RmtLctnPstlAdr")]
		public NameAndAddress10 RmtLctnPstlAdr { get; init; }
	}
}
