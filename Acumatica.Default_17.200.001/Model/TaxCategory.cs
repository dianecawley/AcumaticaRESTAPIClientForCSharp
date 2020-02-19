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
    /// TaxCategory
    /// </summary>
    [DataContract]
    public partial class TaxCategory : Entity,  IEquatable<TaxCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCategory" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        /// <param name="excludeListedTaxes">excludeListedTaxes.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="taxCategoryID">taxCategoryID.</param>
        public TaxCategory(BooleanValue active = default(BooleanValue), DateTimeValue createdDateTime = default(DateTimeValue), StringValue description = default(StringValue), List<TaxCategoryTaxDetail> details = default(List<TaxCategoryTaxDetail>), BooleanValue excludeListedTaxes = default(BooleanValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue taxCategoryID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.CreatedDateTime = createdDateTime;
            this.Description = description;
            this.Details = details;
            this.ExcludeListedTaxes = excludeListedTaxes;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.TaxCategoryID = taxCategoryID;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<TaxCategoryTaxDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeListedTaxes
        /// </summary>
        [DataMember(Name="ExcludeListedTaxes", EmitDefaultValue=false)]
        public BooleanValue ExcludeListedTaxes { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategoryID
        /// </summary>
        [DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
        public StringValue TaxCategoryID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxCategory {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ExcludeListedTaxes: ").Append(ExcludeListedTaxes).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  TaxCategoryID: ").Append(TaxCategoryID).Append("\n");
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
            return this.Equals(input as TaxCategory);
        }

        /// <summary>
        /// Returns true if TaxCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCategory input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) && 
                (
                    this.ExcludeListedTaxes == input.ExcludeListedTaxes ||
                    (this.ExcludeListedTaxes != null &&
                    this.ExcludeListedTaxes.Equals(input.ExcludeListedTaxes))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.TaxCategoryID == input.TaxCategoryID ||
                    (this.TaxCategoryID != null &&
                    this.TaxCategoryID.Equals(input.TaxCategoryID))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.ExcludeListedTaxes != null)
                    hashCode = hashCode * 59 + this.ExcludeListedTaxes.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.TaxCategoryID != null)
                    hashCode = hashCode * 59 + this.TaxCategoryID.GetHashCode();
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
