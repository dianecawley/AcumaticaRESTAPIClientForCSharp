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
    /// The parameters of the action.
    /// </summary>
    [DataContract]
    public partial class SelectRelatedEntityEmailParameters :  IEquatable<SelectRelatedEntityEmailParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectRelatedEntityEmailParameters" /> class.
        /// </summary>
        /// <param name="relatedEntity">relatedEntity.</param>
        /// <param name="type">type.</param>
        public SelectRelatedEntityEmailParameters(StringValue relatedEntity = default(StringValue), StringValue type = default(StringValue))
        {
            this.RelatedEntity = relatedEntity;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets RelatedEntity
        /// </summary>
        [DataMember(Name="RelatedEntity", EmitDefaultValue=false)]
        public StringValue RelatedEntity { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectRelatedEntityEmailParameters {\n");
            sb.Append("  RelatedEntity: ").Append(RelatedEntity).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SelectRelatedEntityEmailParameters);
        }

        /// <summary>
        /// Returns true if SelectRelatedEntityEmailParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectRelatedEntityEmailParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectRelatedEntityEmailParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RelatedEntity == input.RelatedEntity ||
                    (this.RelatedEntity != null &&
                    this.RelatedEntity.Equals(input.RelatedEntity))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = 41;
                if (this.RelatedEntity != null)
                    hashCode = hashCode * 59 + this.RelatedEntity.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            yield break;
        }
    }

}
