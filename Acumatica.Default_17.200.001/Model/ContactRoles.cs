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
    /// ContactRoles
    /// </summary>
    [DataContract]
    public partial class ContactRoles : Entity,  IEquatable<ContactRoles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRoles" /> class.
        /// </summary>
        /// <param name="roleDescription">roleDescription.</param>
        /// <param name="roleName">roleName.</param>
        /// <param name="selected">selected.</param>
        /// <param name="userType">userType.</param>
        public ContactRoles(StringValue roleDescription = default(StringValue), StringValue roleName = default(StringValue), BooleanValue selected = default(BooleanValue), IntValue userType = default(IntValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.RoleDescription = roleDescription;
            this.RoleName = roleName;
            this.Selected = selected;
            this.UserType = userType;
        }
        
        /// <summary>
        /// Gets or Sets RoleDescription
        /// </summary>
        [DataMember(Name="RoleDescription", EmitDefaultValue=false)]
        public StringValue RoleDescription { get; set; }

        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name="RoleName", EmitDefaultValue=false)]
        public StringValue RoleName { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="Selected", EmitDefaultValue=false)]
        public BooleanValue Selected { get; set; }

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name="UserType", EmitDefaultValue=false)]
        public IntValue UserType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRoles {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RoleDescription: ").Append(RoleDescription).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
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
            return this.Equals(input as ContactRoles);
        }

        /// <summary>
        /// Returns true if ContactRoles instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactRoles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRoles input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.RoleDescription == input.RoleDescription ||
                    (this.RoleDescription != null &&
                    this.RoleDescription.Equals(input.RoleDescription))
                ) && base.Equals(input) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && base.Equals(input) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && base.Equals(input) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
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
                if (this.RoleDescription != null)
                    hashCode = hashCode * 59 + this.RoleDescription.GetHashCode();
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.UserType != null)
                    hashCode = hashCode * 59 + this.UserType.GetHashCode();
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
