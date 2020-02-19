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
    /// Opportunity
    /// </summary>
    [DataContract]
    public partial class Opportunity : Entity,  IEquatable<Opportunity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Opportunity" /> class.
        /// </summary>
        /// <param name="activities">activities.</param>
        /// <param name="address">address.</param>
        /// <param name="amount">amount.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="branch">branch.</param>
        /// <param name="businessAccount">businessAccount.</param>
        /// <param name="classID">classID.</param>
        /// <param name="contactDisplayName">contactDisplayName.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="contactInformation">contactInformation.</param>
        /// <param name="convertedLeadDisplayName">convertedLeadDisplayName.</param>
        /// <param name="convertedLeadID">convertedLeadID.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="currencyViewState">currencyViewState.</param>
        /// <param name="details">details.</param>
        /// <param name="discount">discount.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="estimation">estimation.</param>
        /// <param name="location">location.</param>
        /// <param name="manualAmount">manualAmount.</param>
        /// <param name="opportunityID">opportunityID.</param>
        /// <param name="_override">_override.</param>
        /// <param name="owner">owner.</param>
        /// <param name="ownerEmployeeName">ownerEmployeeName.</param>
        /// <param name="parentAccount">parentAccount.</param>
        /// <param name="products">products.</param>
        /// <param name="project">project.</param>
        /// <param name="reason">reason.</param>
        /// <param name="relations">relations.</param>
        /// <param name="source">source.</param>
        /// <param name="sourceCampaign">sourceCampaign.</param>
        /// <param name="stage">stage.</param>
        /// <param name="status">status.</param>
        /// <param name="subject">subject.</param>
        /// <param name="taxDetails">taxDetails.</param>
        /// <param name="taxZone">taxZone.</param>
        /// <param name="total">total.</param>
        /// <param name="weightTotal">weightTotal.</param>
        /// <param name="workgroupDescription">workgroupDescription.</param>
        /// <param name="workgroupID">workgroupID.</param>
        public Opportunity(List<ActivityDetail> activities = default(List<ActivityDetail>), Address address = default(Address), DecimalValue amount = default(DecimalValue), List<AttributeDetail> attributes = default(List<AttributeDetail>), StringValue branch = default(StringValue), StringValue businessAccount = default(StringValue), StringValue classID = default(StringValue), StringValue contactDisplayName = default(StringValue), IntValue contactID = default(IntValue), OpportunityContact contactInformation = default(OpportunityContact), StringValue convertedLeadDisplayName = default(StringValue), IntValue convertedLeadID = default(IntValue), StringValue currencyID = default(StringValue), BooleanValue currencyViewState = default(BooleanValue), StringValue details = default(StringValue), DecimalValue discount = default(DecimalValue), List<OpportunityDiscount> discounts = default(List<OpportunityDiscount>), DateTimeValue estimation = default(DateTimeValue), StringValue location = default(StringValue), BooleanValue manualAmount = default(BooleanValue), StringValue opportunityID = default(StringValue), BooleanValue _override = default(BooleanValue), StringValue owner = default(StringValue), StringValue ownerEmployeeName = default(StringValue), StringValue parentAccount = default(StringValue), List<OpportunityProduct> products = default(List<OpportunityProduct>), StringValue project = default(StringValue), StringValue reason = default(StringValue), List<RelationDetail> relations = default(List<RelationDetail>), StringValue source = default(StringValue), StringValue sourceCampaign = default(StringValue), StringValue stage = default(StringValue), StringValue status = default(StringValue), StringValue subject = default(StringValue), List<OpportunityTaxDetail> taxDetails = default(List<OpportunityTaxDetail>), StringValue taxZone = default(StringValue), DecimalValue total = default(DecimalValue), DecimalValue weightTotal = default(DecimalValue), StringValue workgroupDescription = default(StringValue), StringValue workgroupID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Activities = activities;
            this.Address = address;
            this.Amount = amount;
            this.Attributes = attributes;
            this.Branch = branch;
            this.BusinessAccount = businessAccount;
            this.ClassID = classID;
            this.ContactDisplayName = contactDisplayName;
            this.ContactID = contactID;
            this.ContactInformation = contactInformation;
            this.ConvertedLeadDisplayName = convertedLeadDisplayName;
            this.ConvertedLeadID = convertedLeadID;
            this.CurrencyID = currencyID;
            this.CurrencyViewState = currencyViewState;
            this.Details = details;
            this.Discount = discount;
            this.Discounts = discounts;
            this.Estimation = estimation;
            this.Location = location;
            this.ManualAmount = manualAmount;
            this.OpportunityID = opportunityID;
            this.Override = _override;
            this.Owner = owner;
            this.OwnerEmployeeName = ownerEmployeeName;
            this.ParentAccount = parentAccount;
            this.Products = products;
            this.Project = project;
            this.Reason = reason;
            this.Relations = relations;
            this.Source = source;
            this.SourceCampaign = sourceCampaign;
            this.Stage = stage;
            this.Status = status;
            this.Subject = subject;
            this.TaxDetails = taxDetails;
            this.TaxZone = taxZone;
            this.Total = total;
            this.WeightTotal = weightTotal;
            this.WorkgroupDescription = workgroupDescription;
            this.WorkgroupID = workgroupID;
        }
        
        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name="Activities", EmitDefaultValue=false)]
        public List<ActivityDetail> Activities { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="Attributes", EmitDefaultValue=false)]
        public List<AttributeDetail> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAccount
        /// </summary>
        [DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
        public StringValue BusinessAccount { get; set; }

        /// <summary>
        /// Gets or Sets ClassID
        /// </summary>
        [DataMember(Name="ClassID", EmitDefaultValue=false)]
        public StringValue ClassID { get; set; }

        /// <summary>
        /// Gets or Sets ContactDisplayName
        /// </summary>
        [DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
        public StringValue ContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public IntValue ContactID { get; set; }

        /// <summary>
        /// Gets or Sets ContactInformation
        /// </summary>
        [DataMember(Name="ContactInformation", EmitDefaultValue=false)]
        public OpportunityContact ContactInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConvertedLeadDisplayName
        /// </summary>
        [DataMember(Name="ConvertedLeadDisplayName", EmitDefaultValue=false)]
        public StringValue ConvertedLeadDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ConvertedLeadID
        /// </summary>
        [DataMember(Name="ConvertedLeadID", EmitDefaultValue=false)]
        public IntValue ConvertedLeadID { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyViewState
        /// </summary>
        [DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
        public BooleanValue CurrencyViewState { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public StringValue Details { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="Discount", EmitDefaultValue=false)]
        public DecimalValue Discount { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name="Discounts", EmitDefaultValue=false)]
        public List<OpportunityDiscount> Discounts { get; set; }

        /// <summary>
        /// Gets or Sets Estimation
        /// </summary>
        [DataMember(Name="Estimation", EmitDefaultValue=false)]
        public DateTimeValue Estimation { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets ManualAmount
        /// </summary>
        [DataMember(Name="ManualAmount", EmitDefaultValue=false)]
        public BooleanValue ManualAmount { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityID
        /// </summary>
        [DataMember(Name="OpportunityID", EmitDefaultValue=false)]
        public StringValue OpportunityID { get; set; }

        /// <summary>
        /// Gets or Sets Override
        /// </summary>
        [DataMember(Name="Override", EmitDefaultValue=false)]
        public BooleanValue Override { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="Owner", EmitDefaultValue=false)]
        public StringValue Owner { get; set; }

        /// <summary>
        /// Gets or Sets OwnerEmployeeName
        /// </summary>
        [DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
        public StringValue OwnerEmployeeName { get; set; }

        /// <summary>
        /// Gets or Sets ParentAccount
        /// </summary>
        [DataMember(Name="ParentAccount", EmitDefaultValue=false)]
        public StringValue ParentAccount { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<OpportunityProduct> Products { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public StringValue Reason { get; set; }

        /// <summary>
        /// Gets or Sets Relations
        /// </summary>
        [DataMember(Name="Relations", EmitDefaultValue=false)]
        public List<RelationDetail> Relations { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="Source", EmitDefaultValue=false)]
        public StringValue Source { get; set; }

        /// <summary>
        /// Gets or Sets SourceCampaign
        /// </summary>
        [DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
        public StringValue SourceCampaign { get; set; }

        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="Stage", EmitDefaultValue=false)]
        public StringValue Stage { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public StringValue Subject { get; set; }

        /// <summary>
        /// Gets or Sets TaxDetails
        /// </summary>
        [DataMember(Name="TaxDetails", EmitDefaultValue=false)]
        public List<OpportunityTaxDetail> TaxDetails { get; set; }

        /// <summary>
        /// Gets or Sets TaxZone
        /// </summary>
        [DataMember(Name="TaxZone", EmitDefaultValue=false)]
        public StringValue TaxZone { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public DecimalValue Total { get; set; }

        /// <summary>
        /// Gets or Sets WeightTotal
        /// </summary>
        [DataMember(Name="WeightTotal", EmitDefaultValue=false)]
        public DecimalValue WeightTotal { get; set; }

        /// <summary>
        /// Gets or Sets WorkgroupDescription
        /// </summary>
        [DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
        public StringValue WorkgroupDescription { get; set; }

        /// <summary>
        /// Gets or Sets WorkgroupID
        /// </summary>
        [DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
        public StringValue WorkgroupID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Opportunity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  BusinessAccount: ").Append(BusinessAccount).Append("\n");
            sb.Append("  ClassID: ").Append(ClassID).Append("\n");
            sb.Append("  ContactDisplayName: ").Append(ContactDisplayName).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  ContactInformation: ").Append(ContactInformation).Append("\n");
            sb.Append("  ConvertedLeadDisplayName: ").Append(ConvertedLeadDisplayName).Append("\n");
            sb.Append("  ConvertedLeadID: ").Append(ConvertedLeadID).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  CurrencyViewState: ").Append(CurrencyViewState).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Estimation: ").Append(Estimation).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ManualAmount: ").Append(ManualAmount).Append("\n");
            sb.Append("  OpportunityID: ").Append(OpportunityID).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  OwnerEmployeeName: ").Append(OwnerEmployeeName).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceCampaign: ").Append(SourceCampaign).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
            sb.Append("  TaxZone: ").Append(TaxZone).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  WeightTotal: ").Append(WeightTotal).Append("\n");
            sb.Append("  WorkgroupDescription: ").Append(WorkgroupDescription).Append("\n");
            sb.Append("  WorkgroupID: ").Append(WorkgroupID).Append("\n");
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
            return this.Equals(input as Opportunity);
        }

        /// <summary>
        /// Returns true if Opportunity instances are equal
        /// </summary>
        /// <param name="input">Instance of Opportunity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Opportunity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Activities == input.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(input.Activities)
                ) && base.Equals(input) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.BusinessAccount == input.BusinessAccount ||
                    (this.BusinessAccount != null &&
                    this.BusinessAccount.Equals(input.BusinessAccount))
                ) && base.Equals(input) && 
                (
                    this.ClassID == input.ClassID ||
                    (this.ClassID != null &&
                    this.ClassID.Equals(input.ClassID))
                ) && base.Equals(input) && 
                (
                    this.ContactDisplayName == input.ContactDisplayName ||
                    (this.ContactDisplayName != null &&
                    this.ContactDisplayName.Equals(input.ContactDisplayName))
                ) && base.Equals(input) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && base.Equals(input) && 
                (
                    this.ContactInformation == input.ContactInformation ||
                    (this.ContactInformation != null &&
                    this.ContactInformation.Equals(input.ContactInformation))
                ) && base.Equals(input) && 
                (
                    this.ConvertedLeadDisplayName == input.ConvertedLeadDisplayName ||
                    (this.ConvertedLeadDisplayName != null &&
                    this.ConvertedLeadDisplayName.Equals(input.ConvertedLeadDisplayName))
                ) && base.Equals(input) && 
                (
                    this.ConvertedLeadID == input.ConvertedLeadID ||
                    (this.ConvertedLeadID != null &&
                    this.ConvertedLeadID.Equals(input.ConvertedLeadID))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.CurrencyViewState == input.CurrencyViewState ||
                    (this.CurrencyViewState != null &&
                    this.CurrencyViewState.Equals(input.CurrencyViewState))
                ) && base.Equals(input) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && base.Equals(input) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && base.Equals(input) && 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
                ) && base.Equals(input) && 
                (
                    this.Estimation == input.Estimation ||
                    (this.Estimation != null &&
                    this.Estimation.Equals(input.Estimation))
                ) && base.Equals(input) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) && 
                (
                    this.ManualAmount == input.ManualAmount ||
                    (this.ManualAmount != null &&
                    this.ManualAmount.Equals(input.ManualAmount))
                ) && base.Equals(input) && 
                (
                    this.OpportunityID == input.OpportunityID ||
                    (this.OpportunityID != null &&
                    this.OpportunityID.Equals(input.OpportunityID))
                ) && base.Equals(input) && 
                (
                    this.Override == input.Override ||
                    (this.Override != null &&
                    this.Override.Equals(input.Override))
                ) && base.Equals(input) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && base.Equals(input) && 
                (
                    this.OwnerEmployeeName == input.OwnerEmployeeName ||
                    (this.OwnerEmployeeName != null &&
                    this.OwnerEmployeeName.Equals(input.OwnerEmployeeName))
                ) && base.Equals(input) && 
                (
                    this.ParentAccount == input.ParentAccount ||
                    (this.ParentAccount != null &&
                    this.ParentAccount.Equals(input.ParentAccount))
                ) && base.Equals(input) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && base.Equals(input) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && base.Equals(input) && 
                (
                    this.Relations == input.Relations ||
                    this.Relations != null &&
                    this.Relations.SequenceEqual(input.Relations)
                ) && base.Equals(input) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && base.Equals(input) && 
                (
                    this.SourceCampaign == input.SourceCampaign ||
                    (this.SourceCampaign != null &&
                    this.SourceCampaign.Equals(input.SourceCampaign))
                ) && base.Equals(input) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && base.Equals(input) && 
                (
                    this.TaxDetails == input.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.SequenceEqual(input.TaxDetails)
                ) && base.Equals(input) && 
                (
                    this.TaxZone == input.TaxZone ||
                    (this.TaxZone != null &&
                    this.TaxZone.Equals(input.TaxZone))
                ) && base.Equals(input) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && base.Equals(input) && 
                (
                    this.WeightTotal == input.WeightTotal ||
                    (this.WeightTotal != null &&
                    this.WeightTotal.Equals(input.WeightTotal))
                ) && base.Equals(input) && 
                (
                    this.WorkgroupDescription == input.WorkgroupDescription ||
                    (this.WorkgroupDescription != null &&
                    this.WorkgroupDescription.Equals(input.WorkgroupDescription))
                ) && base.Equals(input) && 
                (
                    this.WorkgroupID == input.WorkgroupID ||
                    (this.WorkgroupID != null &&
                    this.WorkgroupID.Equals(input.WorkgroupID))
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
                if (this.Activities != null)
                    hashCode = hashCode * 59 + this.Activities.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.BusinessAccount != null)
                    hashCode = hashCode * 59 + this.BusinessAccount.GetHashCode();
                if (this.ClassID != null)
                    hashCode = hashCode * 59 + this.ClassID.GetHashCode();
                if (this.ContactDisplayName != null)
                    hashCode = hashCode * 59 + this.ContactDisplayName.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.ContactInformation != null)
                    hashCode = hashCode * 59 + this.ContactInformation.GetHashCode();
                if (this.ConvertedLeadDisplayName != null)
                    hashCode = hashCode * 59 + this.ConvertedLeadDisplayName.GetHashCode();
                if (this.ConvertedLeadID != null)
                    hashCode = hashCode * 59 + this.ConvertedLeadID.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.CurrencyViewState != null)
                    hashCode = hashCode * 59 + this.CurrencyViewState.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Discounts != null)
                    hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.Estimation != null)
                    hashCode = hashCode * 59 + this.Estimation.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ManualAmount != null)
                    hashCode = hashCode * 59 + this.ManualAmount.GetHashCode();
                if (this.OpportunityID != null)
                    hashCode = hashCode * 59 + this.OpportunityID.GetHashCode();
                if (this.Override != null)
                    hashCode = hashCode * 59 + this.Override.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.OwnerEmployeeName != null)
                    hashCode = hashCode * 59 + this.OwnerEmployeeName.GetHashCode();
                if (this.ParentAccount != null)
                    hashCode = hashCode * 59 + this.ParentAccount.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Relations != null)
                    hashCode = hashCode * 59 + this.Relations.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceCampaign != null)
                    hashCode = hashCode * 59 + this.SourceCampaign.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TaxDetails != null)
                    hashCode = hashCode * 59 + this.TaxDetails.GetHashCode();
                if (this.TaxZone != null)
                    hashCode = hashCode * 59 + this.TaxZone.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.WeightTotal != null)
                    hashCode = hashCode * 59 + this.WeightTotal.GetHashCode();
                if (this.WorkgroupDescription != null)
                    hashCode = hashCode * 59 + this.WorkgroupDescription.GetHashCode();
                if (this.WorkgroupID != null)
                    hashCode = hashCode * 59 + this.WorkgroupID.GetHashCode();
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
