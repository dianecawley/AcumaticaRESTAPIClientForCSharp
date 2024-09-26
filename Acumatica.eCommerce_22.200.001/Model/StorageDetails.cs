using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen BC408010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StorageDetails : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BindingID 
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue? BindingID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<StorageDetailsResult>? Results { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SplitByLocation 
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SplitByLocation", EmitDefaultValue=false)]
		public BooleanValue? SplitByLocation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Warehouse 
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}