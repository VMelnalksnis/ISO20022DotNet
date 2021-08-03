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
	[XmlType("PostalAddress6", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record PostalAddress6
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("AdrTp")]
		public AddressType2Code AdrTpValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the AdrTp property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AdrTpValueSpecified { get; init; }

		[XmlIgnore]
		public AddressType2Code? AdrTp
		{
			get
			{
				if (AdrTpValueSpecified)
				{
					return AdrTpValue;
				}

				return null;
			}
			init
			{
				AdrTpValue = value.GetValueOrDefault();
				AdrTpValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 70.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("Dept")]
		public string Dept { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 70.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("SubDept")]
		public string SubDept { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 70.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("StrtNm")]
		public string StrtNm { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 16.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(16)]
		[XmlElement("BldgNb")]
		public string BldgNb { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 16.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(16)]
		[XmlElement("PstCd")]
		public string PstCd { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("TwnNm")]
		public string TwnNm { get; init; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("CtrySubDvsn")]
		public string CtrySubDvsn { get; init; }

		/// <summary>
		/// <para xml:lang="en">Pattern: [A-Z]{2,2}.</para>
		/// </summary>
		[RegularExpression("[A-Z]{2,2}")]
		[XmlElement("Ctry")]
		public string Ctry { get; init; }

		[XmlIgnore] private System.Collections.ObjectModel.Collection<string> _adrLine;

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 70.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(70)]
		[XmlElement("AdrLine")]
		public System.Collections.ObjectModel.Collection<string> AdrLine
		{
			get => _adrLine;
			private set => _adrLine = value;
		}

		/// <summary>
		/// <para xml:lang="en">Gets a value indicating whether the AdrLine collection is empty.</para>
		/// </summary>
		[XmlIgnore]
		public bool AdrLineSpecified => AdrLine.Count != 0;

		/// <summary>
		/// <para xml:lang="en">Initializes a new instance of the <see cref="PostalAddress6" /> class.</para>
		/// </summary>
		public PostalAddress6()
		{
			_adrLine = new();
		}
	}
}
