using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_24_200_001.Model;

namespace Acumatica.Default_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class SalesPriceWorksheetApi : BaseEndpointApi<SalesPriceWorksheet>
	{
		public SalesPriceWorksheetApi(ApiClient client) : base(client)
		{ }
	}
}