using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	[Obsolete("For backward compatibility")]
	public class RoughCutPlanningApi : BaseEndpointApi<RoughCutPlanning>
	{
		public RoughCutPlanningApi(ApiClient client) : base(client)
		{ }
	}
}