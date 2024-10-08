using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProFormaFinancialDetails : Entity
	{

		[DataMember(Name="ARDocType", EmitDefaultValue=false)]
		public StringValue? ARDocType { get; set; }

		[DataMember(Name="ARRefNbr", EmitDefaultValue=false)]
		public StringValue? ARRefNbr { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue? CashDiscountDate { get; set; }

		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		[DataMember(Name="CustomerUsageType", EmitDefaultValue=false)]
		public StringValue? CustomerUsageType { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

	}
}