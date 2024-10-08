using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS208500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class FOBPoint : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The description of the FOB Point.
		/// DAC: PX.Objects.CS.FOBPoint 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The unique identifier of the FOB Point.
		/// DAC: PX.Objects.CS.FOBPoint 
		/// Display Name: FOB Point ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FOBPointID", EmitDefaultValue=false)]
		public StringValue? FOBPointID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}