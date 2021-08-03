using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("TransactionAgents2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record TransactionAgents2
	{
		[XmlElement("DbtrAgt")]
		public BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

		[XmlElement("CdtrAgt")]
		public BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

		[XmlElement("IntrmyAgt1")]
		public BranchAndFinancialInstitutionIdentification4 IntrmyAgt1 { get; set; }

		[XmlElement("IntrmyAgt2")]
		public BranchAndFinancialInstitutionIdentification4 IntrmyAgt2 { get; set; }

		[XmlElement("IntrmyAgt3")]
		public BranchAndFinancialInstitutionIdentification4 IntrmyAgt3 { get; set; }

		[XmlElement("RcvgAgt")]
		public BranchAndFinancialInstitutionIdentification4 RcvgAgt { get; set; }

		[XmlElement("DlvrgAgt")]
		public BranchAndFinancialInstitutionIdentification4 DlvrgAgt { get; set; }

		[XmlElement("IssgAgt")]
		public BranchAndFinancialInstitutionIdentification4 IssgAgt { get; set; }

		[XmlElement("SttlmPlc")]
		public BranchAndFinancialInstitutionIdentification4 SttlmPlc { get; set; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<ProprietaryAgent2> _prtry;

		[XmlElement("Prtry")]
		public System.Collections.ObjectModel.Collection<ProprietaryAgent2> Prtry
		{
			get => _prtry;
			private set => _prtry = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Prtry collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool PrtrySpecified => Prtry.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionAgents2" /> class.</para>
		/// </summary>
		public TransactionAgents2()
		{
			_prtry = new();
		}
	}
}
