using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_17_200_001.Model;

namespace Acumatica.Default_17_200_001.Api
{
    public partial class AdjustmentApi : EntityAPI<Adjustment>
    {
        public AdjustmentApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
