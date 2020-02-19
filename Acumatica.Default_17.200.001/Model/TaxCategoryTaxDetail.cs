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
    /// TaxCategoryTaxDetail
    /// </summary>
    [DataContract]
    public partial class TaxCategoryTaxDetail : Entity,  IEquatable<TaxCategoryTaxDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCategoryTaxDetail" /> class.
        /// </summary>
        /// <param name="calculateOn">calculateOn.</param>
        /// <param name="cashDiscount">cashDiscount.</param>
        /// <param name="description">description.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="taxID">taxID.</param>
        /// <param name="taxType">taxType.</param>
        public TaxCategoryTaxDetail(StringValue calculateOn = default(StringValue), StringValue cashDiscount = default(StringValue), StringValue description = default(StringValue), StringValue taxCategory = default(StringValue), StringValue taxID = default(StringValue), StringValue taxType = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CalculateOn = calculateOn;
            this.CashDiscount = cashDiscount;
            this.Description = description;
            this.TaxCategory = taxCategory;
            this.TaxID = taxID;
            this.TaxType = taxType;
        }
        
        /// <summary>
        /// Gets or Sets CalculateOn
        /// </summary>
        [DataMember(Name="CalculateOn", EmitDefaultValue=false)]
        public StringValue CalculateOn { get; set; }

        /// <summary>
        /// Gets or Sets CashDiscount
        /// </summary>
        [DataMember(Name="CashDiscount", EmitDefaultValue=false)]
        public StringValue CashDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets TaxID
        /// </summary>
        [DataMember(Name="TaxID", EmitDefaultValue=false)]
        public StringValue TaxID { get; set; }

        /// <summary>
        /// Gets or Sets TaxType
        /// </summary>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public StringValue TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxCategoryTaxDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CalculateOn: ").Append(CalculateOn).Append("\n");
            sb.Append("  CashDiscount: ").Append(CashDiscount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TaxID: ").Append(TaxID).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as TaxCategoryTaxDetail);
        }

        /// <summary>
        /// Returns true if TaxCategoryTaxDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxCategoryTaxDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCategoryTaxDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CalculateOn == input.CalculateOn ||
                    (this.CalculateOn != null &&
                    this.CalculateOn.Equals(input.CalculateOn))
                ) && base.Equals(input) && 
                (
                    this.CashDiscount == input.CashDiscount ||
                    (this.CashDiscount != null &&
                    this.CashDiscount.Equals(input.CashDiscount))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.TaxID == input.TaxID ||
                    (this.TaxID != null &&
                    this.TaxID.Equals(input.TaxID))
                ) && base.Equals(input) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.CalculateOn != null)
                    hashCode = hashCode * 59 + this.CalculateOn.GetHashCode();
                if (this.CashDiscount != null)
                    hashCode = hashCode * 59 + this.CashDiscount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TaxID != null)
                    hashCode = hashCode * 59 + this.TaxID.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
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
