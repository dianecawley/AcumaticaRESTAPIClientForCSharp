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
    /// VoucherEntryCode
    /// </summary>
    [DataContract]
    public partial class VoucherEntryCode : Entity,  IEquatable<VoucherEntryCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherEntryCode" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="description">description.</param>
        /// <param name="module">module.</param>
        /// <param name="moduleTransactionType">moduleTransactionType.</param>
        /// <param name="uniqueTransactionCode">uniqueTransactionCode.</param>
        public VoucherEntryCode(BooleanValue active = default(BooleanValue), StringValue description = default(StringValue), StringValue module = default(StringValue), StringValue moduleTransactionType = default(StringValue), StringValue uniqueTransactionCode = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.Description = description;
            this.Module = module;
            this.ModuleTransactionType = moduleTransactionType;
            this.UniqueTransactionCode = uniqueTransactionCode;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="Module", EmitDefaultValue=false)]
        public StringValue Module { get; set; }

        /// <summary>
        /// Gets or Sets ModuleTransactionType
        /// </summary>
        [DataMember(Name="ModuleTransactionType", EmitDefaultValue=false)]
        public StringValue ModuleTransactionType { get; set; }

        /// <summary>
        /// Gets or Sets UniqueTransactionCode
        /// </summary>
        [DataMember(Name="UniqueTransactionCode", EmitDefaultValue=false)]
        public StringValue UniqueTransactionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoucherEntryCode {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  ModuleTransactionType: ").Append(ModuleTransactionType).Append("\n");
            sb.Append("  UniqueTransactionCode: ").Append(UniqueTransactionCode).Append("\n");
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
            return this.Equals(input as VoucherEntryCode);
        }

        /// <summary>
        /// Returns true if VoucherEntryCode instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherEntryCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherEntryCode input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && base.Equals(input) && 
                (
                    this.ModuleTransactionType == input.ModuleTransactionType ||
                    (this.ModuleTransactionType != null &&
                    this.ModuleTransactionType.Equals(input.ModuleTransactionType))
                ) && base.Equals(input) && 
                (
                    this.UniqueTransactionCode == input.UniqueTransactionCode ||
                    (this.UniqueTransactionCode != null &&
                    this.UniqueTransactionCode.Equals(input.UniqueTransactionCode))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.ModuleTransactionType != null)
                    hashCode = hashCode * 59 + this.ModuleTransactionType.GetHashCode();
                if (this.UniqueTransactionCode != null)
                    hashCode = hashCode * 59 + this.UniqueTransactionCode.GetHashCode();
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
