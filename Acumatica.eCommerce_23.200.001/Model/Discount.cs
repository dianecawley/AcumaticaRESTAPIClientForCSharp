using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class Discount : Acumatica.Default_23_200_001.Model.Discount, ITopLevelEntity
	{

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}