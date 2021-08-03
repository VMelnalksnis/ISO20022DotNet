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
	[XmlType("DocumentAdjustment1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record DocumentAdjustment1
	{
		[Required]
		[XmlElement("Amt")]
		public ActiveOrHistoricCurrencyAndAmount Amt { get; init; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CdtDbtIndValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CdtDbtIndValueSpecified { get; init; }

		[XmlIgnore]
		public CreditDebitCode? CdtDbtInd
		{
			get
			{
				if (CdtDbtIndValueSpecified)
				{
					return CdtDbtIndValue;
				}

				return null;
			}
			init
			{
				CdtDbtIndValue = value.GetValueOrDefault();
				CdtDbtIndValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 4.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(4)]
		[XmlElement("Rsn")]
		public string Rsn { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("AddtlInf")]
		public string AddtlInf { get; init; }
	}
}
