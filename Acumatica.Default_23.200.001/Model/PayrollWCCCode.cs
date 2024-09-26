using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR209800 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayrollWCCCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.PR.PRWorkCodeMaint+PRWorkCodeFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="WCCCodes", EmitDefaultValue=false)]
		public List<WCCCode>? WCCCodes { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}