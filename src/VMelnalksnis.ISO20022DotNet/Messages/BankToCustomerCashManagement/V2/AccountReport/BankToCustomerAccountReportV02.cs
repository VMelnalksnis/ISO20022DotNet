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
	[XmlType("BankToCustomerAccountReportV02", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record BankToCustomerAccountReportV02
	{
		[Required]
		[XmlElement("GrpHdr")]
		public GroupHeader42 GrpHdr { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<AccountReport11> _rpt;

		[Required]
		[XmlElement("Rpt")]
		public System.Collections.ObjectModel.Collection<AccountReport11> Rpt
		{
			get => _rpt;
			private set => _rpt = value;
		}

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="BankToCustomerAccountReportV02" /> class.</para>
		/// </summary>
		public BankToCustomerAccountReportV02()
		{
			_rpt = new();
		}
	}
}
