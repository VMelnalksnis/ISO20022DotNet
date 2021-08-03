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
	[XmlType("AmountRangeBoundary1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record AmountRangeBoundary1
	{
		/// <summary>
		/// <para xml:lang="en">Minimum inclusive value: 0.</para>
		/// <para xml:lang="en">Total number of digits in fraction: 5.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[Required]
		[XmlElement("BdryAmt")]
		public decimal BdryAmt { get; init; }

		[Required]
		[XmlElement("Incl")]
		public bool Incl { get; init; }
	}
}
