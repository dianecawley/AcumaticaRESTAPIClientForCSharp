using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Api
{
	public abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>
		where EntityType : Entity, ITopLevelEntity, new()
	{
		public BaseEndpointApi(ApiClient client) : base(client)
		{ }
		public override string GetEndpointPath()
		{
			return "entity/ISVCB/21.200.001";
		}
	}
}