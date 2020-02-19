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
    /// BusinessAccountMainContact
    /// </summary>
    [DataContract]
    public partial class BusinessAccountMainContact : Entity,  IEquatable<BusinessAccountMainContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountMainContact" /> class.
        /// </summary>
        /// <param name="companyName">companyName.</param>
        /// <param name="email">email.</param>
        /// <param name="fax">fax.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="attention">attention.</param>
        /// <param name="languageOrLocale">languageOrLocale.</param>
        /// <param name="phone1">phone1.</param>
        /// <param name="phone2">phone2.</param>
        /// <param name="web">web.</param>
        public BusinessAccountMainContact(StringValue companyName = default(StringValue), StringValue email = default(StringValue), StringValue fax = default(StringValue), StringValue jobTitle = default(StringValue), StringValue attention = default(StringValue), StringValue languageOrLocale = default(StringValue), StringValue phone1 = default(StringValue), StringValue phone2 = default(StringValue), StringValue web = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CompanyName = companyName;
            this.Email = email;
            this.Fax = fax;
            this.JobTitle = jobTitle;
            this.Attention = attention;
            this.LanguageOrLocale = languageOrLocale;
            this.Phone1 = phone1;
            this.Phone2 = phone2;
            this.Web = web;
        }
        
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="CompanyName", EmitDefaultValue=false)]
        public StringValue CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="Fax", EmitDefaultValue=false)]
        public StringValue Fax { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="JobTitle", EmitDefaultValue=false)]
        public StringValue JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="Attention", EmitDefaultValue=false)]
        public StringValue Attention { get; set; }

        /// <summary>
        /// Gets or Sets LanguageOrLocale
        /// </summary>
        [DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
        public StringValue LanguageOrLocale { get; set; }

        /// <summary>
        /// Gets or Sets Phone1
        /// </summary>
        [DataMember(Name="Phone1", EmitDefaultValue=false)]
        public StringValue Phone1 { get; set; }

        /// <summary>
        /// Gets or Sets Phone2
        /// </summary>
        [DataMember(Name="Phone2", EmitDefaultValue=false)]
        public StringValue Phone2 { get; set; }

        /// <summary>
        /// Gets or Sets Web
        /// </summary>
        [DataMember(Name="Web", EmitDefaultValue=false)]
        public StringValue Web { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountMainContact {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  LanguageOrLocale: ").Append(LanguageOrLocale).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Phone2: ").Append(Phone2).Append("\n");
            sb.Append("  Web: ").Append(Web).Append("\n");
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
            return this.Equals(input as BusinessAccountMainContact);
        }

        /// <summary>
        /// Returns true if BusinessAccountMainContact instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountMainContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountMainContact input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && base.Equals(input) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && base.Equals(input) && 
                (
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
                ) && base.Equals(input) && 
                (
                    this.LanguageOrLocale == input.LanguageOrLocale ||
                    (this.LanguageOrLocale != null &&
                    this.LanguageOrLocale.Equals(input.LanguageOrLocale))
                ) && base.Equals(input) && 
                (
                    this.Phone1 == input.Phone1 ||
                    (this.Phone1 != null &&
                    this.Phone1.Equals(input.Phone1))
                ) && base.Equals(input) && 
                (
                    this.Phone2 == input.Phone2 ||
                    (this.Phone2 != null &&
                    this.Phone2.Equals(input.Phone2))
                ) && base.Equals(input) && 
                (
                    this.Web == input.Web ||
                    (this.Web != null &&
                    this.Web.Equals(input.Web))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Attention != null)
                    hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.LanguageOrLocale != null)
                    hashCode = hashCode * 59 + this.LanguageOrLocale.GetHashCode();
                if (this.Phone1 != null)
                    hashCode = hashCode * 59 + this.Phone1.GetHashCode();
                if (this.Phone2 != null)
                    hashCode = hashCode * 59 + this.Phone2.GetHashCode();
                if (this.Web != null)
                    hashCode = hashCode * 59 + this.Web.GetHashCode();
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
