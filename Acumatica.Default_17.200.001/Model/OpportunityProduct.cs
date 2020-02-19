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
    /// OpportunityProduct
    /// </summary>
    [DataContract]
    public partial class OpportunityProduct : Entity,  IEquatable<OpportunityProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityProduct" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="discount">discount.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="discountCode">discountCode.</param>
        /// <param name="discountSequence">discountSequence.</param>
        /// <param name="externalPrice">externalPrice.</param>
        /// <param name="freeItem">freeItem.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="manualDiscount">manualDiscount.</param>
        /// <param name="opportunityProductID">opportunityProductID.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="qty">qty.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="transactionDescription">transactionDescription.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouse">warehouse.</param>
        public OpportunityProduct(DecimalValue amount = default(DecimalValue), DecimalValue discount = default(DecimalValue), DecimalValue discountAmount = default(DecimalValue), StringValue discountCode = default(StringValue), StringValue discountSequence = default(StringValue), DecimalValue externalPrice = default(DecimalValue), BooleanValue freeItem = default(BooleanValue), StringValue inventoryID = default(StringValue), BooleanValue manualDiscount = default(BooleanValue), IntValue opportunityProductID = default(IntValue), StringValue projectTask = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue subitem = default(StringValue), StringValue taxCategory = default(StringValue), StringValue transactionDescription = default(StringValue), DecimalValue unitPrice = default(DecimalValue), StringValue uOM = default(StringValue), StringValue warehouse = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Amount = amount;
            this.Discount = discount;
            this.DiscountAmount = discountAmount;
            this.DiscountCode = discountCode;
            this.DiscountSequence = discountSequence;
            this.ExternalPrice = externalPrice;
            this.FreeItem = freeItem;
            this.InventoryID = inventoryID;
            this.ManualDiscount = manualDiscount;
            this.OpportunityProductID = opportunityProductID;
            this.ProjectTask = projectTask;
            this.Qty = qty;
            this.Subitem = subitem;
            this.TaxCategory = taxCategory;
            this.TransactionDescription = transactionDescription;
            this.UnitPrice = unitPrice;
            this.UOM = uOM;
            this.Warehouse = warehouse;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="Discount", EmitDefaultValue=false)]
        public DecimalValue Discount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public DecimalValue DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountCode
        /// </summary>
        [DataMember(Name="DiscountCode", EmitDefaultValue=false)]
        public StringValue DiscountCode { get; set; }

        /// <summary>
        /// Gets or Sets DiscountSequence
        /// </summary>
        [DataMember(Name="DiscountSequence", EmitDefaultValue=false)]
        public StringValue DiscountSequence { get; set; }

        /// <summary>
        /// Gets or Sets ExternalPrice
        /// </summary>
        [DataMember(Name="ExternalPrice", EmitDefaultValue=false)]
        public DecimalValue ExternalPrice { get; set; }

        /// <summary>
        /// Gets or Sets FreeItem
        /// </summary>
        [DataMember(Name="FreeItem", EmitDefaultValue=false)]
        public BooleanValue FreeItem { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets ManualDiscount
        /// </summary>
        [DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
        public BooleanValue ManualDiscount { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityProductID
        /// </summary>
        [DataMember(Name="OpportunityProductID", EmitDefaultValue=false)]
        public IntValue OpportunityProductID { get; set; }

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
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

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
        /// Gets or Sets Warehouse
        /// </summary>
        [DataMember(Name="Warehouse", EmitDefaultValue=false)]
        public StringValue Warehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpportunityProduct {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountCode: ").Append(DiscountCode).Append("\n");
            sb.Append("  DiscountSequence: ").Append(DiscountSequence).Append("\n");
            sb.Append("  ExternalPrice: ").Append(ExternalPrice).Append("\n");
            sb.Append("  FreeItem: ").Append(FreeItem).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  ManualDiscount: ").Append(ManualDiscount).Append("\n");
            sb.Append("  OpportunityProductID: ").Append(OpportunityProductID).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
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
            return this.Equals(input as OpportunityProduct);
        }

        /// <summary>
        /// Returns true if OpportunityProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of OpportunityProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpportunityProduct input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && base.Equals(input) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && base.Equals(input) && 
                (
                    this.DiscountCode == input.DiscountCode ||
                    (this.DiscountCode != null &&
                    this.DiscountCode.Equals(input.DiscountCode))
                ) && base.Equals(input) && 
                (
                    this.DiscountSequence == input.DiscountSequence ||
                    (this.DiscountSequence != null &&
                    this.DiscountSequence.Equals(input.DiscountSequence))
                ) && base.Equals(input) && 
                (
                    this.ExternalPrice == input.ExternalPrice ||
                    (this.ExternalPrice != null &&
                    this.ExternalPrice.Equals(input.ExternalPrice))
                ) && base.Equals(input) && 
                (
                    this.FreeItem == input.FreeItem ||
                    (this.FreeItem != null &&
                    this.FreeItem.Equals(input.FreeItem))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.ManualDiscount == input.ManualDiscount ||
                    (this.ManualDiscount != null &&
                    this.ManualDiscount.Equals(input.ManualDiscount))
                ) && base.Equals(input) && 
                (
                    this.OpportunityProductID == input.OpportunityProductID ||
                    (this.OpportunityProductID != null &&
                    this.OpportunityProductID.Equals(input.OpportunityProductID))
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
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
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
                ) && base.Equals(input) && 
                (
                    this.Warehouse == input.Warehouse ||
                    (this.Warehouse != null &&
                    this.Warehouse.Equals(input.Warehouse))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountCode != null)
                    hashCode = hashCode * 59 + this.DiscountCode.GetHashCode();
                if (this.DiscountSequence != null)
                    hashCode = hashCode * 59 + this.DiscountSequence.GetHashCode();
                if (this.ExternalPrice != null)
                    hashCode = hashCode * 59 + this.ExternalPrice.GetHashCode();
                if (this.FreeItem != null)
                    hashCode = hashCode * 59 + this.FreeItem.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.ManualDiscount != null)
                    hashCode = hashCode * 59 + this.ManualDiscount.GetHashCode();
                if (this.OpportunityProductID != null)
                    hashCode = hashCode * 59 + this.OpportunityProductID.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.Warehouse != null)
                    hashCode = hashCode * 59 + this.Warehouse.GetHashCode();
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
