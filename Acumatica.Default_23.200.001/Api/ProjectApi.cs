using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_23_200_001.Model;

namespace Acumatica.Default_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ProjectApi : BaseEndpointApi<Project>
	{
		public ProjectApi(ApiClient client) : base(client)
		{ }
	}
}