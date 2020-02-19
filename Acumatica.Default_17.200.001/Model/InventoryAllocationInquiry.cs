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
    /// InventoryAllocationInquiry
    /// </summary>
    [DataContract]
    public partial class InventoryAllocationInquiry : Entity,  IEquatable<InventoryAllocationInquiry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAllocationInquiry" /> class.
        /// </summary>
        /// <param name="available">available.</param>
        /// <param name="availableForIssue">availableForIssue.</param>
        /// <param name="availableForShipping">availableForShipping.</param>
        /// <param name="baseUnit">baseUnit.</param>
        /// <param name="inTransit">inTransit.</param>
        /// <param name="inTransitToSO">inTransitToSO.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="inventoryIssues">inventoryIssues.</param>
        /// <param name="inventoryReceipts">inventoryReceipts.</param>
        /// <param name="kitAssemblyDemand">kitAssemblyDemand.</param>
        /// <param name="kitAssemblySupply">kitAssemblySupply.</param>
        /// <param name="location">location.</param>
        /// <param name="onHand">onHand.</param>
        /// <param name="onLocationNotAvailable">onLocationNotAvailable.</param>
        /// <param name="purchaseForSO">purchaseForSO.</param>
        /// <param name="purchaseForSOPrepared">purchaseForSOPrepared.</param>
        /// <param name="purchaseOrders">purchaseOrders.</param>
        /// <param name="purchasePrepared">purchasePrepared.</param>
        /// <param name="purchaseReceipts">purchaseReceipts.</param>
        /// <param name="receiptsForSO">receiptsForSO.</param>
        /// <param name="results">results.</param>
        /// <param name="sOAllocated">sOAllocated.</param>
        /// <param name="sOBackOrdered">sOBackOrdered.</param>
        /// <param name="sOBooked">sOBooked.</param>
        /// <param name="sOPrepared">sOPrepared.</param>
        /// <param name="sOShipped">sOShipped.</param>
        /// <param name="sOToPurchase">sOToPurchase.</param>
        /// <param name="totalAddition">totalAddition.</param>
        /// <param name="totalDeduction">totalDeduction.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public InventoryAllocationInquiry(DecimalValue available = default(DecimalValue), DecimalValue availableForIssue = default(DecimalValue), DecimalValue availableForShipping = default(DecimalValue), StringValue baseUnit = default(StringValue), DecimalValue inTransit = default(DecimalValue), DecimalValue inTransitToSO = default(DecimalValue), StringValue inventoryID = default(StringValue), DecimalValue inventoryIssues = default(DecimalValue), DecimalValue inventoryReceipts = default(DecimalValue), DecimalValue kitAssemblyDemand = default(DecimalValue), DecimalValue kitAssemblySupply = default(DecimalValue), StringValue location = default(StringValue), DecimalValue onHand = default(DecimalValue), DecimalValue onLocationNotAvailable = default(DecimalValue), DecimalValue purchaseForSO = default(DecimalValue), DecimalValue purchaseForSOPrepared = default(DecimalValue), DecimalValue purchaseOrders = default(DecimalValue), DecimalValue purchasePrepared = default(DecimalValue), DecimalValue purchaseReceipts = default(DecimalValue), DecimalValue receiptsForSO = default(DecimalValue), List<InventoryAllocationRow> results = default(List<InventoryAllocationRow>), DecimalValue sOAllocated = default(DecimalValue), DecimalValue sOBackOrdered = default(DecimalValue), DecimalValue sOBooked = default(DecimalValue), DecimalValue sOPrepared = default(DecimalValue), DecimalValue sOShipped = default(DecimalValue), DecimalValue sOToPurchase = default(DecimalValue), DecimalValue totalAddition = default(DecimalValue), DecimalValue totalDeduction = default(DecimalValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Available = available;
            this.AvailableForIssue = availableForIssue;
            this.AvailableForShipping = availableForShipping;
            this.BaseUnit = baseUnit;
            this.InTransit = inTransit;
            this.InTransitToSO = inTransitToSO;
            this.InventoryID = inventoryID;
            this.InventoryIssues = inventoryIssues;
            this.InventoryReceipts = inventoryReceipts;
            this.KitAssemblyDemand = kitAssemblyDemand;
            this.KitAssemblySupply = kitAssemblySupply;
            this.Location = location;
            this.OnHand = onHand;
            this.OnLocationNotAvailable = onLocationNotAvailable;
            this.PurchaseForSO = purchaseForSO;
            this.PurchaseForSOPrepared = purchaseForSOPrepared;
            this.PurchaseOrders = purchaseOrders;
            this.PurchasePrepared = purchasePrepared;
            this.PurchaseReceipts = purchaseReceipts;
            this.ReceiptsForSO = receiptsForSO;
            this.Results = results;
            this.SOAllocated = sOAllocated;
            this.SOBackOrdered = sOBackOrdered;
            this.SOBooked = sOBooked;
            this.SOPrepared = sOPrepared;
            this.SOShipped = sOShipped;
            this.SOToPurchase = sOToPurchase;
            this.TotalAddition = totalAddition;
            this.TotalDeduction = totalDeduction;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name="Available", EmitDefaultValue=false)]
        public DecimalValue Available { get; set; }

        /// <summary>
        /// Gets or Sets AvailableForIssue
        /// </summary>
        [DataMember(Name="AvailableForIssue", EmitDefaultValue=false)]
        public DecimalValue AvailableForIssue { get; set; }

        /// <summary>
        /// Gets or Sets AvailableForShipping
        /// </summary>
        [DataMember(Name="AvailableForShipping", EmitDefaultValue=false)]
        public DecimalValue AvailableForShipping { get; set; }

        /// <summary>
        /// Gets or Sets BaseUnit
        /// </summary>
        [DataMember(Name="BaseUnit", EmitDefaultValue=false)]
        public StringValue BaseUnit { get; set; }

        /// <summary>
        /// Gets or Sets InTransit
        /// </summary>
        [DataMember(Name="InTransit", EmitDefaultValue=false)]
        public DecimalValue InTransit { get; set; }

        /// <summary>
        /// Gets or Sets InTransitToSO
        /// </summary>
        [DataMember(Name="InTransitToSO", EmitDefaultValue=false)]
        public DecimalValue InTransitToSO { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets InventoryIssues
        /// </summary>
        [DataMember(Name="InventoryIssues", EmitDefaultValue=false)]
        public DecimalValue InventoryIssues { get; set; }

        /// <summary>
        /// Gets or Sets InventoryReceipts
        /// </summary>
        [DataMember(Name="InventoryReceipts", EmitDefaultValue=false)]
        public DecimalValue InventoryReceipts { get; set; }

        /// <summary>
        /// Gets or Sets KitAssemblyDemand
        /// </summary>
        [DataMember(Name="KitAssemblyDemand", EmitDefaultValue=false)]
        public DecimalValue KitAssemblyDemand { get; set; }

        /// <summary>
        /// Gets or Sets KitAssemblySupply
        /// </summary>
        [DataMember(Name="KitAssemblySupply", EmitDefaultValue=false)]
        public DecimalValue KitAssemblySupply { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets OnHand
        /// </summary>
        [DataMember(Name="OnHand", EmitDefaultValue=false)]
        public DecimalValue OnHand { get; set; }

        /// <summary>
        /// Gets or Sets OnLocationNotAvailable
        /// </summary>
        [DataMember(Name="OnLocationNotAvailable", EmitDefaultValue=false)]
        public DecimalValue OnLocationNotAvailable { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseForSO
        /// </summary>
        [DataMember(Name="PurchaseForSO", EmitDefaultValue=false)]
        public DecimalValue PurchaseForSO { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseForSOPrepared
        /// </summary>
        [DataMember(Name="PurchaseForSOPrepared", EmitDefaultValue=false)]
        public DecimalValue PurchaseForSOPrepared { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrders
        /// </summary>
        [DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
        public DecimalValue PurchaseOrders { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrepared
        /// </summary>
        [DataMember(Name="PurchasePrepared", EmitDefaultValue=false)]
        public DecimalValue PurchasePrepared { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseReceipts
        /// </summary>
        [DataMember(Name="PurchaseReceipts", EmitDefaultValue=false)]
        public DecimalValue PurchaseReceipts { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptsForSO
        /// </summary>
        [DataMember(Name="ReceiptsForSO", EmitDefaultValue=false)]
        public DecimalValue ReceiptsForSO { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="Results", EmitDefaultValue=false)]
        public List<InventoryAllocationRow> Results { get; set; }

        /// <summary>
        /// Gets or Sets SOAllocated
        /// </summary>
        [DataMember(Name="SOAllocated", EmitDefaultValue=false)]
        public DecimalValue SOAllocated { get; set; }

        /// <summary>
        /// Gets or Sets SOBackOrdered
        /// </summary>
        [DataMember(Name="SOBackOrdered", EmitDefaultValue=false)]
        public DecimalValue SOBackOrdered { get; set; }

        /// <summary>
        /// Gets or Sets SOBooked
        /// </summary>
        [DataMember(Name="SOBooked", EmitDefaultValue=false)]
        public DecimalValue SOBooked { get; set; }

        /// <summary>
        /// Gets or Sets SOPrepared
        /// </summary>
        [DataMember(Name="SOPrepared", EmitDefaultValue=false)]
        public DecimalValue SOPrepared { get; set; }

        /// <summary>
        /// Gets or Sets SOShipped
        /// </summary>
        [DataMember(Name="SOShipped", EmitDefaultValue=false)]
        public DecimalValue SOShipped { get; set; }

        /// <summary>
        /// Gets or Sets SOToPurchase
        /// </summary>
        [DataMember(Name="SOToPurchase", EmitDefaultValue=false)]
        public DecimalValue SOToPurchase { get; set; }

        /// <summary>
        /// Gets or Sets TotalAddition
        /// </summary>
        [DataMember(Name="TotalAddition", EmitDefaultValue=false)]
        public DecimalValue TotalAddition { get; set; }

        /// <summary>
        /// Gets or Sets TotalDeduction
        /// </summary>
        [DataMember(Name="TotalDeduction", EmitDefaultValue=false)]
        public DecimalValue TotalDeduction { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryAllocationInquiry {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  AvailableForIssue: ").Append(AvailableForIssue).Append("\n");
            sb.Append("  AvailableForShipping: ").Append(AvailableForShipping).Append("\n");
            sb.Append("  BaseUnit: ").Append(BaseUnit).Append("\n");
            sb.Append("  InTransit: ").Append(InTransit).Append("\n");
            sb.Append("  InTransitToSO: ").Append(InTransitToSO).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  InventoryIssues: ").Append(InventoryIssues).Append("\n");
            sb.Append("  InventoryReceipts: ").Append(InventoryReceipts).Append("\n");
            sb.Append("  KitAssemblyDemand: ").Append(KitAssemblyDemand).Append("\n");
            sb.Append("  KitAssemblySupply: ").Append(KitAssemblySupply).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  OnHand: ").Append(OnHand).Append("\n");
            sb.Append("  OnLocationNotAvailable: ").Append(OnLocationNotAvailable).Append("\n");
            sb.Append("  PurchaseForSO: ").Append(PurchaseForSO).Append("\n");
            sb.Append("  PurchaseForSOPrepared: ").Append(PurchaseForSOPrepared).Append("\n");
            sb.Append("  PurchaseOrders: ").Append(PurchaseOrders).Append("\n");
            sb.Append("  PurchasePrepared: ").Append(PurchasePrepared).Append("\n");
            sb.Append("  PurchaseReceipts: ").Append(PurchaseReceipts).Append("\n");
            sb.Append("  ReceiptsForSO: ").Append(ReceiptsForSO).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  SOAllocated: ").Append(SOAllocated).Append("\n");
            sb.Append("  SOBackOrdered: ").Append(SOBackOrdered).Append("\n");
            sb.Append("  SOBooked: ").Append(SOBooked).Append("\n");
            sb.Append("  SOPrepared: ").Append(SOPrepared).Append("\n");
            sb.Append("  SOShipped: ").Append(SOShipped).Append("\n");
            sb.Append("  SOToPurchase: ").Append(SOToPurchase).Append("\n");
            sb.Append("  TotalAddition: ").Append(TotalAddition).Append("\n");
            sb.Append("  TotalDeduction: ").Append(TotalDeduction).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
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
            return this.Equals(input as InventoryAllocationInquiry);
        }

        /// <summary>
        /// Returns true if InventoryAllocationInquiry instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryAllocationInquiry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryAllocationInquiry input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && base.Equals(input) && 
                (
                    this.AvailableForIssue == input.AvailableForIssue ||
                    (this.AvailableForIssue != null &&
                    this.AvailableForIssue.Equals(input.AvailableForIssue))
                ) && base.Equals(input) && 
                (
                    this.AvailableForShipping == input.AvailableForShipping ||
                    (this.AvailableForShipping != null &&
                    this.AvailableForShipping.Equals(input.AvailableForShipping))
                ) && base.Equals(input) && 
                (
                    this.BaseUnit == input.BaseUnit ||
                    (this.BaseUnit != null &&
                    this.BaseUnit.Equals(input.BaseUnit))
                ) && base.Equals(input) && 
                (
                    this.InTransit == input.InTransit ||
                    (this.InTransit != null &&
                    this.InTransit.Equals(input.InTransit))
                ) && base.Equals(input) && 
                (
                    this.InTransitToSO == input.InTransitToSO ||
                    (this.InTransitToSO != null &&
                    this.InTransitToSO.Equals(input.InTransitToSO))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.InventoryIssues == input.InventoryIssues ||
                    (this.InventoryIssues != null &&
                    this.InventoryIssues.Equals(input.InventoryIssues))
                ) && base.Equals(input) && 
                (
                    this.InventoryReceipts == input.InventoryReceipts ||
                    (this.InventoryReceipts != null &&
                    this.InventoryReceipts.Equals(input.InventoryReceipts))
                ) && base.Equals(input) && 
                (
                    this.KitAssemblyDemand == input.KitAssemblyDemand ||
                    (this.KitAssemblyDemand != null &&
                    this.KitAssemblyDemand.Equals(input.KitAssemblyDemand))
                ) && base.Equals(input) && 
                (
                    this.KitAssemblySupply == input.KitAssemblySupply ||
                    (this.KitAssemblySupply != null &&
                    this.KitAssemblySupply.Equals(input.KitAssemblySupply))
                ) && base.Equals(input) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) && 
                (
                    this.OnHand == input.OnHand ||
                    (this.OnHand != null &&
                    this.OnHand.Equals(input.OnHand))
                ) && base.Equals(input) && 
                (
                    this.OnLocationNotAvailable == input.OnLocationNotAvailable ||
                    (this.OnLocationNotAvailable != null &&
                    this.OnLocationNotAvailable.Equals(input.OnLocationNotAvailable))
                ) && base.Equals(input) && 
                (
                    this.PurchaseForSO == input.PurchaseForSO ||
                    (this.PurchaseForSO != null &&
                    this.PurchaseForSO.Equals(input.PurchaseForSO))
                ) && base.Equals(input) && 
                (
                    this.PurchaseForSOPrepared == input.PurchaseForSOPrepared ||
                    (this.PurchaseForSOPrepared != null &&
                    this.PurchaseForSOPrepared.Equals(input.PurchaseForSOPrepared))
                ) && base.Equals(input) && 
                (
                    this.PurchaseOrders == input.PurchaseOrders ||
                    (this.PurchaseOrders != null &&
                    this.PurchaseOrders.Equals(input.PurchaseOrders))
                ) && base.Equals(input) && 
                (
                    this.PurchasePrepared == input.PurchasePrepared ||
                    (this.PurchasePrepared != null &&
                    this.PurchasePrepared.Equals(input.PurchasePrepared))
                ) && base.Equals(input) && 
                (
                    this.PurchaseReceipts == input.PurchaseReceipts ||
                    (this.PurchaseReceipts != null &&
                    this.PurchaseReceipts.Equals(input.PurchaseReceipts))
                ) && base.Equals(input) && 
                (
                    this.ReceiptsForSO == input.ReceiptsForSO ||
                    (this.ReceiptsForSO != null &&
                    this.ReceiptsForSO.Equals(input.ReceiptsForSO))
                ) && base.Equals(input) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && base.Equals(input) && 
                (
                    this.SOAllocated == input.SOAllocated ||
                    (this.SOAllocated != null &&
                    this.SOAllocated.Equals(input.SOAllocated))
                ) && base.Equals(input) && 
                (
                    this.SOBackOrdered == input.SOBackOrdered ||
                    (this.SOBackOrdered != null &&
                    this.SOBackOrdered.Equals(input.SOBackOrdered))
                ) && base.Equals(input) && 
                (
                    this.SOBooked == input.SOBooked ||
                    (this.SOBooked != null &&
                    this.SOBooked.Equals(input.SOBooked))
                ) && base.Equals(input) && 
                (
                    this.SOPrepared == input.SOPrepared ||
                    (this.SOPrepared != null &&
                    this.SOPrepared.Equals(input.SOPrepared))
                ) && base.Equals(input) && 
                (
                    this.SOShipped == input.SOShipped ||
                    (this.SOShipped != null &&
                    this.SOShipped.Equals(input.SOShipped))
                ) && base.Equals(input) && 
                (
                    this.SOToPurchase == input.SOToPurchase ||
                    (this.SOToPurchase != null &&
                    this.SOToPurchase.Equals(input.SOToPurchase))
                ) && base.Equals(input) && 
                (
                    this.TotalAddition == input.TotalAddition ||
                    (this.TotalAddition != null &&
                    this.TotalAddition.Equals(input.TotalAddition))
                ) && base.Equals(input) && 
                (
                    this.TotalDeduction == input.TotalDeduction ||
                    (this.TotalDeduction != null &&
                    this.TotalDeduction.Equals(input.TotalDeduction))
                ) && base.Equals(input) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
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
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.AvailableForIssue != null)
                    hashCode = hashCode * 59 + this.AvailableForIssue.GetHashCode();
                if (this.AvailableForShipping != null)
                    hashCode = hashCode * 59 + this.AvailableForShipping.GetHashCode();
                if (this.BaseUnit != null)
                    hashCode = hashCode * 59 + this.BaseUnit.GetHashCode();
                if (this.InTransit != null)
                    hashCode = hashCode * 59 + this.InTransit.GetHashCode();
                if (this.InTransitToSO != null)
                    hashCode = hashCode * 59 + this.InTransitToSO.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.InventoryIssues != null)
                    hashCode = hashCode * 59 + this.InventoryIssues.GetHashCode();
                if (this.InventoryReceipts != null)
                    hashCode = hashCode * 59 + this.InventoryReceipts.GetHashCode();
                if (this.KitAssemblyDemand != null)
                    hashCode = hashCode * 59 + this.KitAssemblyDemand.GetHashCode();
                if (this.KitAssemblySupply != null)
                    hashCode = hashCode * 59 + this.KitAssemblySupply.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.OnHand != null)
                    hashCode = hashCode * 59 + this.OnHand.GetHashCode();
                if (this.OnLocationNotAvailable != null)
                    hashCode = hashCode * 59 + this.OnLocationNotAvailable.GetHashCode();
                if (this.PurchaseForSO != null)
                    hashCode = hashCode * 59 + this.PurchaseForSO.GetHashCode();
                if (this.PurchaseForSOPrepared != null)
                    hashCode = hashCode * 59 + this.PurchaseForSOPrepared.GetHashCode();
                if (this.PurchaseOrders != null)
                    hashCode = hashCode * 59 + this.PurchaseOrders.GetHashCode();
                if (this.PurchasePrepared != null)
                    hashCode = hashCode * 59 + this.PurchasePrepared.GetHashCode();
                if (this.PurchaseReceipts != null)
                    hashCode = hashCode * 59 + this.PurchaseReceipts.GetHashCode();
                if (this.ReceiptsForSO != null)
                    hashCode = hashCode * 59 + this.ReceiptsForSO.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.SOAllocated != null)
                    hashCode = hashCode * 59 + this.SOAllocated.GetHashCode();
                if (this.SOBackOrdered != null)
                    hashCode = hashCode * 59 + this.SOBackOrdered.GetHashCode();
                if (this.SOBooked != null)
                    hashCode = hashCode * 59 + this.SOBooked.GetHashCode();
                if (this.SOPrepared != null)
                    hashCode = hashCode * 59 + this.SOPrepared.GetHashCode();
                if (this.SOShipped != null)
                    hashCode = hashCode * 59 + this.SOShipped.GetHashCode();
                if (this.SOToPurchase != null)
                    hashCode = hashCode * 59 + this.SOToPurchase.GetHashCode();
                if (this.TotalAddition != null)
                    hashCode = hashCode * 59 + this.TotalAddition.GetHashCode();
                if (this.TotalDeduction != null)
                    hashCode = hashCode * 59 + this.TotalDeduction.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
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
