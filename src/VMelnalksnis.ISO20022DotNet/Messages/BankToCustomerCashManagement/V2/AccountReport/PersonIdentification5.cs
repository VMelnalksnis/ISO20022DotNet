using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("PersonIdentification5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record PersonIdentification5
	{
		[XmlElement("DtAndPlcOfBirth")]
		public DateAndPlaceOfBirth DtAndPlcOfBirth { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<GenericPersonIdentification1> _othr;

		[XmlElement("Othr")]
		public System.Collections.ObjectModel.Collection<GenericPersonIdentification1> Othr
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
		/// <para xml:lang="en">Initializes a new instance of the <see cref="PersonIdentification5" /> class.</para>
		/// </summary>
		public PersonIdentification5()
		{
			_othr = new();
		}
	}
}
