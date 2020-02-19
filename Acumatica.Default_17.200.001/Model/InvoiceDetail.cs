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
    /// InvoiceDetail
    /// </summary>
    [DataContract]
    public partial class InvoiceDetail : Entity,  IEquatable<InvoiceDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="amount">amount.</param>
        /// <param name="branch">branch.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="extendedPrice">extendedPrice.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="qty">qty.</param>
        /// <param name="subaccount">subaccount.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="transactionDescription">transactionDescription.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="uOM">uOM.</param>
        public InvoiceDetail(StringValue account = default(StringValue), DecimalValue amount = default(DecimalValue), StringValue branch = default(StringValue), DecimalValue discountAmount = default(DecimalValue), DecimalValue extendedPrice = default(DecimalValue), StringValue inventoryID = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), IntValue lineNbr = default(IntValue), StringValue projectTask = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue subaccount = default(StringValue), StringValue subitem = default(StringValue), StringValue transactionDescription = default(StringValue), DecimalValue unitPrice = default(DecimalValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.Amount = amount;
            this.Branch = branch;
            this.DiscountAmount = discountAmount;
            this.ExtendedPrice = extendedPrice;
            this.InventoryID = inventoryID;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.LineNbr = lineNbr;
            this.ProjectTask = projectTask;
            this.Qty = qty;
            this.Subaccount = subaccount;
            this.Subitem = subitem;
            this.TransactionDescription = transactionDescription;
            this.UnitPrice = unitPrice;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public DecimalValue DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedPrice
        /// </summary>
        [DataMember(Name="ExtendedPrice", EmitDefaultValue=false)]
        public DecimalValue ExtendedPrice { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDescription
        /// </summary>
        [DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
        public StringValue TransactionDescription { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="UnitPrice", EmitDefaultValue=false)]
        public DecimalValue UnitPrice { get; set; }

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
            sb.Append("class InvoiceDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  ExtendedPrice: ").Append(ExtendedPrice).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return this.Equals(input as InvoiceDetail);
        }

        /// <summary>
        /// Returns true if InvoiceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && base.Equals(input) && 
                (
                    this.ExtendedPrice == input.ExtendedPrice ||
                    (this.ExtendedPrice != null &&
                    this.ExtendedPrice.Equals(input.ExtendedPrice))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) && base.Equals(input) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.ExtendedPrice != null)
                    hashCode = hashCode * 59 + this.ExtendedPrice.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
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
