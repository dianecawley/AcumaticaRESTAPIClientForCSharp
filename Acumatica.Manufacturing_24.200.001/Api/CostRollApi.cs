using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_24_200_001.Model;

namespace Acumatica.Manufacturing_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class CostRollApi : BaseEndpointApi<CostRoll>
	{
		public CostRollApi(ApiClient client) : base(client)
		{ }
	}
}