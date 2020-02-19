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
    /// Carrier
    /// </summary>
    [DataContract]
    public partial class Carrier : Entity,  IEquatable<Carrier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier" /> class.
        /// </summary>
        /// <param name="carrierID">carrierID.</param>
        /// <param name="carrierUnitOfWeight">carrierUnitOfWeight.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="customerAccounts">customerAccounts.</param>
        /// <param name="description">description.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="plugInParameters">plugInParameters.</param>
        /// <param name="plugInType">plugInType.</param>
        /// <param name="uOM">uOM.</param>
        public Carrier(StringValue carrierID = default(StringValue), StringValue carrierUnitOfWeight = default(StringValue), DateTimeValue createdDateTime = default(DateTimeValue), List<CarrierCustomerAccount> customerAccounts = default(List<CarrierCustomerAccount>), StringValue description = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), List<CarrierPluginParameter> plugInParameters = default(List<CarrierPluginParameter>), StringValue plugInType = default(StringValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CarrierID = carrierID;
            this.CarrierUnitOfWeight = carrierUnitOfWeight;
            this.CreatedDateTime = createdDateTime;
            this.CustomerAccounts = customerAccounts;
            this.Description = description;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.PlugInParameters = plugInParameters;
            this.PlugInType = plugInType;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets CarrierID
        /// </summary>
        [DataMember(Name="CarrierID", EmitDefaultValue=false)]
        public StringValue CarrierID { get; set; }

        /// <summary>
        /// Gets or Sets CarrierUnitOfWeight
        /// </summary>
        [DataMember(Name="CarrierUnitOfWeight", EmitDefaultValue=false)]
        public StringValue CarrierUnitOfWeight { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CustomerAccounts
        /// </summary>
        [DataMember(Name="CustomerAccounts", EmitDefaultValue=false)]
        public List<CarrierCustomerAccount> CustomerAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets PlugInParameters
        /// </summary>
        [DataMember(Name="PlugInParameters", EmitDefaultValue=false)]
        public List<CarrierPluginParameter> PlugInParameters { get; set; }

        /// <summary>
        /// Gets or Sets PlugInType
        /// </summary>
        [DataMember(Name="PlugInType", EmitDefaultValue=false)]
        public StringValue PlugInType { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Carrier {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CarrierID: ").Append(CarrierID).Append("\n");
            sb.Append("  CarrierUnitOfWeight: ").Append(CarrierUnitOfWeight).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CustomerAccounts: ").Append(CustomerAccounts).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  PlugInParameters: ").Append(PlugInParameters).Append("\n");
            sb.Append("  PlugInType: ").Append(PlugInType).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as Carrier);
        }

        /// <summary>
        /// Returns true if Carrier instances are equal
        /// </summary>
        /// <param name="input">Instance of Carrier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Carrier input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CarrierID == input.CarrierID ||
                    (this.CarrierID != null &&
                    this.CarrierID.Equals(input.CarrierID))
                ) && base.Equals(input) && 
                (
                    this.CarrierUnitOfWeight == input.CarrierUnitOfWeight ||
                    (this.CarrierUnitOfWeight != null &&
                    this.CarrierUnitOfWeight.Equals(input.CarrierUnitOfWeight))
                ) && base.Equals(input) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && base.Equals(input) && 
                (
                    this.CustomerAccounts == input.CustomerAccounts ||
                    this.CustomerAccounts != null &&
                    this.CustomerAccounts.SequenceEqual(input.CustomerAccounts)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.PlugInParameters == input.PlugInParameters ||
                    this.PlugInParameters != null &&
                    this.PlugInParameters.SequenceEqual(input.PlugInParameters)
                ) && base.Equals(input) && 
                (
                    this.PlugInType == input.PlugInType ||
                    (this.PlugInType != null &&
                    this.PlugInType.Equals(input.PlugInType))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.CarrierID != null)
                    hashCode = hashCode * 59 + this.CarrierID.GetHashCode();
                if (this.CarrierUnitOfWeight != null)
                    hashCode = hashCode * 59 + this.CarrierUnitOfWeight.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CustomerAccounts != null)
                    hashCode = hashCode * 59 + this.CustomerAccounts.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.PlugInParameters != null)
                    hashCode = hashCode * 59 + this.PlugInParameters.GetHashCode();
                if (this.PlugInType != null)
                    hashCode = hashCode * 59 + this.PlugInType.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
