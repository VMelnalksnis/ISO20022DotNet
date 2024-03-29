﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.MessageSets.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("DatePeriodDetails", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record DatePeriodDetails
	{
		[Required]
		[XmlElement("FrDt", DataType = "date")]
		public DateTime FrDt { get; init; }

		[Required]
		[XmlElement("ToDt", DataType = "date")]
		public DateTime ToDt { get; init; }
	}
}
