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
	[XmlType("RemittanceInformation5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record RemittanceInformation5
	{
		[XmlIgnore] private System.Collections.ObjectModel.Collection<string> _ustrd;

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("Ustrd")]
		public System.Collections.ObjectModel.Collection<string> Ustrd
		{
			get => _ustrd;
			private set => _ustrd = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Ustrd collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool UstrdSpecified => Ustrd.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="RemittanceInformation5" /> class.</para>
		/// </summary>
		public RemittanceInformation5()
		{
			_ustrd = new();
			_strd = new();
		}

		[XmlIgnore] private System.Collections.ObjectModel.Collection<StructuredRemittanceInformation7> _strd;

		[XmlElement("Strd")]
		public System.Collections.ObjectModel.Collection<StructuredRemittanceInformation7> Strd
		{
			get => _strd;
			private set => _strd = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the Strd collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool StrdSpecified => Strd.Count != 0;
	}
}
