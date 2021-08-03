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
	[XmlType("ReferredDocumentType1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ReferredDocumentType1Choice
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Cd")]
		public DocumentType5Code CdValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CdValueSpecified { get; init; }

		[XmlIgnore]
		public DocumentType5Code? Cd
		{
			get
			{
				if (CdValueSpecified)
				{
					return CdValue;
				}

				return null;
			}
			init
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
		public string Prtry { get; init; }
	}
}
