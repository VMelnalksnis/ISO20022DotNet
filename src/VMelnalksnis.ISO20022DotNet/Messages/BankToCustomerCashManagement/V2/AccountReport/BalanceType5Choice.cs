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
	[XmlType("BalanceType5Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BalanceType5Choice
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Cd")]
		public BalanceType12Code CdValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CdValueSpecified { get; set; }

		[XmlIgnore]
		public BalanceType12Code? Cd
		{
			get
			{
				if (CdValueSpecified)
				{
					return CdValue;
				}

				return null;
			}
			set
			{
				CdValue = value.GetValueOrDefault();
				CdValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Prtry")]
		public string Prtry { get; set; }
	}
}
