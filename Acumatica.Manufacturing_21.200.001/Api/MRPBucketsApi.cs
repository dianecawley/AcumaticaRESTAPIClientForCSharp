using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class MRPBucketsApi : BaseEndpointApi<MRPBuckets>
	{
		public MRPBucketsApi(ApiClient client) : base(client)
		{ }
	}
}