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
	[XmlType("OrganisationIdentification4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record OrganisationIdentification4
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
		[XmlElement("BICOrBEI")]
		public string BICOrBEI { get; init; }

		[XmlIgnore]
		private System.Collections.ObjectModel.Collection<GenericOrganisationIdentification1> _othr;

		[XmlElement("Othr")]
		public System.Collections.ObjectModel.Collection<GenericOrganisationIdentification1> Othr
		{
			get => _othr;
			private set => _othr = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Othr collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool OthrSpecified => Othr.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="OrganisationIdentification4" /> class.</para>
		/// </summary>
		public OrganisationIdentification4()
		{
			_othr = new();
		}
	}
}
