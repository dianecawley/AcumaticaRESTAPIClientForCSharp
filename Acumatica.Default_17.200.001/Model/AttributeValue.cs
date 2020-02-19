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
    /// AttributeValue
    /// </summary>
    [DataContract]
    public partial class AttributeValue : Entity,  IEquatable<AttributeValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeValue" /> class.
        /// </summary>
        /// <param name="attributeID">attributeID.</param>
        /// <param name="required">required.</param>
        /// <param name="value">value.</param>
        public AttributeValue(StringValue attributeID = default(StringValue), BooleanValue required = default(BooleanValue), StringValue value = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AttributeID = attributeID;
            this.Required = required;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets AttributeID
        /// </summary>
        [DataMember(Name="AttributeID", EmitDefaultValue=false)]
        public StringValue AttributeID { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="Required", EmitDefaultValue=false)]
        public BooleanValue Required { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public StringValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeValue {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AttributeID: ").Append(AttributeID).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as AttributeValue);
        }

        /// <summary>
        /// Returns true if AttributeValue instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributeValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeValue input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AttributeID == input.AttributeID ||
                    (this.AttributeID != null &&
                    this.AttributeID.Equals(input.AttributeID))
                ) && base.Equals(input) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.AttributeID != null)
                    hashCode = hashCode * 59 + this.AttributeID.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
