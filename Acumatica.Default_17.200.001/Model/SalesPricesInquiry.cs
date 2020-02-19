/* 
 * Default/17.200.001
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Acumatica.RESTClient.Model;
using System.ComponentModel.DataAnnotations;


namespace Acumatica.Default_17_200_001.Model
{
    /// <summary>
    /// SalesPricesInquiry
    /// </summary>
    [DataContract]
    public partial class SalesPricesInquiry : Entity,  IEquatable<SalesPricesInquiry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPricesInquiry" /> class.
        /// </summary>
        /// <param name="effectiveAsOf">effectiveAsOf.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="itemClassID">itemClassID.</param>
        /// <param name="priceClass">priceClass.</param>
        /// <param name="priceCode">priceCode.</param>
        /// <param name="priceManager">priceManager.</param>
        /// <param name="priceManagerIsMe">priceManagerIsMe.</param>
        /// <param name="priceType">priceType.</param>
        /// <param name="priceWorkgroup">priceWorkgroup.</param>
        /// <param name="priceWorkgroupIsMine">priceWorkgroupIsMine.</param>
        /// <param name="salesPriceDetails">salesPriceDetails.</param>
        public SalesPricesInquiry(DateTimeValue effectiveAsOf = default(DateTimeValue), StringValue inventoryID = default(StringValue), StringValue itemClassID = default(StringValue), StringValue priceClass = default(StringValue), StringValue priceCode = default(StringValue), StringValue priceManager = default(StringValue), BooleanValue priceManagerIsMe = default(BooleanValue), StringValue priceType = default(StringValue), StringValue priceWorkgroup = default(StringValue), BooleanValue priceWorkgroupIsMine = default(BooleanValue), List<SalesPriceDetail> salesPriceDetails = default(List<SalesPriceDetail>), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.EffectiveAsOf = effectiveAsOf;
            this.InventoryID = inventoryID;
            this.ItemClassID = itemClassID;
            this.PriceClass = priceClass;
            this.PriceCode = priceCode;
            this.PriceManager = priceManager;
            this.PriceManagerIsMe = priceManagerIsMe;
            this.PriceType = priceType;
            this.PriceWorkgroup = priceWorkgroup;
            this.PriceWorkgroupIsMine = priceWorkgroupIsMine;
            this.SalesPriceDetails = salesPriceDetails;
        }
        
        /// <summary>
        /// Gets or Sets EffectiveAsOf
        /// </summary>
        [DataMember(Name="EffectiveAsOf", EmitDefaultValue=false)]
        public DateTimeValue EffectiveAsOf { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets ItemClassID
        /// </summary>
        [DataMember(Name="ItemClassID", EmitDefaultValue=false)]
        public StringValue ItemClassID { get; set; }

        /// <summary>
        /// Gets or Sets PriceClass
        /// </summary>
        [DataMember(Name="PriceClass", EmitDefaultValue=false)]
        public StringValue PriceClass { get; set; }

        /// <summary>
        /// Gets or Sets PriceCode
        /// </summary>
        [DataMember(Name="PriceCode", EmitDefaultValue=false)]
        public StringValue PriceCode { get; set; }

        /// <summary>
        /// Gets or Sets PriceManager
        /// </summary>
        [DataMember(Name="PriceManager", EmitDefaultValue=false)]
        public StringValue PriceManager { get; set; }

        /// <summary>
        /// Gets or Sets PriceManagerIsMe
        /// </summary>
        [DataMember(Name="PriceManagerIsMe", EmitDefaultValue=false)]
        public BooleanValue PriceManagerIsMe { get; set; }

        /// <summary>
        /// Gets or Sets PriceType
        /// </summary>
        [DataMember(Name="PriceType", EmitDefaultValue=false)]
        public StringValue PriceType { get; set; }

        /// <summary>
        /// Gets or Sets PriceWorkgroup
        /// </summary>
        [DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
        public StringValue PriceWorkgroup { get; set; }

        /// <summary>
        /// Gets or Sets PriceWorkgroupIsMine
        /// </summary>
        [DataMember(Name="PriceWorkgroupIsMine", EmitDefaultValue=false)]
        public BooleanValue PriceWorkgroupIsMine { get; set; }

        /// <summary>
        /// Gets or Sets SalesPriceDetails
        /// </summary>
        [DataMember(Name="SalesPriceDetails", EmitDefaultValue=false)]
        public List<SalesPriceDetail> SalesPriceDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesPricesInquiry {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EffectiveAsOf: ").Append(EffectiveAsOf).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  ItemClassID: ").Append(ItemClassID).Append("\n");
            sb.Append("  PriceClass: ").Append(PriceClass).Append("\n");
            sb.Append("  PriceCode: ").Append(PriceCode).Append("\n");
            sb.Append("  PriceManager: ").Append(PriceManager).Append("\n");
            sb.Append("  PriceManagerIsMe: ").Append(PriceManagerIsMe).Append("\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  PriceWorkgroup: ").Append(PriceWorkgroup).Append("\n");
            sb.Append("  PriceWorkgroupIsMine: ").Append(PriceWorkgroupIsMine).Append("\n");
            sb.Append("  SalesPriceDetails: ").Append(SalesPriceDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SalesPricesInquiry);
        }

        /// <summary>
        /// Returns true if SalesPricesInquiry instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesPricesInquiry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesPricesInquiry input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.EffectiveAsOf == input.EffectiveAsOf ||
                    (this.EffectiveAsOf != null &&
                    this.EffectiveAsOf.Equals(input.EffectiveAsOf))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.ItemClassID == input.ItemClassID ||
                    (this.ItemClassID != null &&
                    this.ItemClassID.Equals(input.ItemClassID))
                ) && base.Equals(input) && 
                (
                    this.PriceClass == input.PriceClass ||
                    (this.PriceClass != null &&
                    this.PriceClass.Equals(input.PriceClass))
                ) && base.Equals(input) && 
                (
                    this.PriceCode == input.PriceCode ||
                    (this.PriceCode != null &&
                    this.PriceCode.Equals(input.PriceCode))
                ) && base.Equals(input) && 
                (
                    this.PriceManager == input.PriceManager ||
                    (this.PriceManager != null &&
                    this.PriceManager.Equals(input.PriceManager))
                ) && base.Equals(input) && 
                (
                    this.PriceManagerIsMe == input.PriceManagerIsMe ||
                    (this.PriceManagerIsMe != null &&
                    this.PriceManagerIsMe.Equals(input.PriceManagerIsMe))
                ) && base.Equals(input) && 
                (
                    this.PriceType == input.PriceType ||
                    (this.PriceType != null &&
                    this.PriceType.Equals(input.PriceType))
                ) && base.Equals(input) && 
                (
                    this.PriceWorkgroup == input.PriceWorkgroup ||
                    (this.PriceWorkgroup != null &&
                    this.PriceWorkgroup.Equals(input.PriceWorkgroup))
                ) && base.Equals(input) && 
                (
                    this.PriceWorkgroupIsMine == input.PriceWorkgroupIsMine ||
                    (this.PriceWorkgroupIsMine != null &&
                    this.PriceWorkgroupIsMine.Equals(input.PriceWorkgroupIsMine))
                ) && base.Equals(input) && 
                (
                    this.SalesPriceDetails == input.SalesPriceDetails ||
                    this.SalesPriceDetails != null &&
                    this.SalesPriceDetails.SequenceEqual(input.SalesPriceDetails)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.EffectiveAsOf != null)
                    hashCode = hashCode * 59 + this.EffectiveAsOf.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.ItemClassID != null)
                    hashCode = hashCode * 59 + this.ItemClassID.GetHashCode();
                if (this.PriceClass != null)
                    hashCode = hashCode * 59 + this.PriceClass.GetHashCode();
                if (this.PriceCode != null)
                    hashCode = hashCode * 59 + this.PriceCode.GetHashCode();
                if (this.PriceManager != null)
                    hashCode = hashCode * 59 + this.PriceManager.GetHashCode();
                if (this.PriceManagerIsMe != null)
                    hashCode = hashCode * 59 + this.PriceManagerIsMe.GetHashCode();
                if (this.PriceType != null)
                    hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                if (this.PriceWorkgroup != null)
                    hashCode = hashCode * 59 + this.PriceWorkgroup.GetHashCode();
                if (this.PriceWorkgroupIsMine != null)
                    hashCode = hashCode * 59 + this.PriceWorkgroupIsMine.GetHashCode();
                if (this.SalesPriceDetails != null)
                    hashCode = hashCode * 59 + this.SalesPriceDetails.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
