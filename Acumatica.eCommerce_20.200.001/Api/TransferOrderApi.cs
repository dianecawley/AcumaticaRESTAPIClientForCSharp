using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class TransferOrderApi : BaseEndpointApi<TransferOrder>
	{
		public TransferOrderApi(ApiClient client) : base(client)
		{ }
	}
}