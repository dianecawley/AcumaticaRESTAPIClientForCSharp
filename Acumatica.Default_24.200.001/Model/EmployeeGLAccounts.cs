using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class EmployeeGLAccounts : Entity
	{

		/// <summary>
		/// DAC Field Name: BenefitExpenseAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Benefit Expense Account 
		/// </summary>
		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// DAC Field Name: BenefitExpenseSubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Benefit Expense Sub. 
		/// </summary>
		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// DAC Field Name: BenefitLiabilityAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Benefit Liability Account 
		/// </summary>
		[DataMember(Name="BenefitLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilityAccount { get; set; }

		/// <summary>
		/// DAC Field Name: BenefitLiabilitySubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Benefit Liability Sub. 
		/// </summary>
		[DataMember(Name="BenefitLiabilitySub", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilitySub { get; set; }

		/// <summary>
		/// DAC Field Name: DedLiabilityAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Deduction Liability Account 
		/// </summary>
		[DataMember(Name="DeductionLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilityAccount { get; set; }

		/// <summary>
		/// DAC Field Name: DedLiabilitySubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Deduction Liability Sub. 
		/// </summary>
		[DataMember(Name="DeductionLiabilitySub", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilitySub { get; set; }

		/// <summary>
		/// DAC Field Name: EarningsAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Earnings Account 
		/// </summary>
		[DataMember(Name="EarningsAccount", EmitDefaultValue=false)]
		public StringValue? EarningsAccount { get; set; }

		/// <summary>
		/// DAC Field Name: EarningsSubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Earnings Sub. 
		/// </summary>
		[DataMember(Name="EarningsSub", EmitDefaultValue=false)]
		public StringValue? EarningsSub { get; set; }

		/// <summary>
		/// DAC Field Name: PTOAssetAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: PTO Asset Account 
		/// </summary>
		[DataMember(Name="PTOAssetAccount", EmitDefaultValue=false)]
		public StringValue? PTOAssetAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PTOAssetSubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: PTO Asset Sub. 
		/// </summary>
		[DataMember(Name="PTOAssetSub", EmitDefaultValue=false)]
		public StringValue? PTOAssetSub { get; set; }

		/// <summary>
		/// DAC Field Name: PTOExpenseAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: PTO Expense Account 
		/// </summary>
		[DataMember(Name="PTOExpenseAccount", EmitDefaultValue=false)]
		public StringValue? PTOExpenseAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PTOExpenseSubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: PTO Expense Sub. 
		/// </summary>
		[DataMember(Name="PTOExpenseSub", EmitDefaultValue=false)]
		public StringValue? PTOExpenseSub { get; set; }

		/// <summary>
		/// DAC Field Name: PTOLiabilityAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: PTO Liability Account 
		/// </summary>
		[DataMember(Name="PTOLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? PTOLiabilityAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PTOLiabilitySubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: PTO Liability Sub. 
		/// </summary>
		[DataMember(Name="PTOLiabilitySub", EmitDefaultValue=false)]
		public StringValue? PTOLiabilitySub { get; set; }

		/// <summary>
		/// DAC Field Name: PayrollTaxExpenseAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Tax Expense Account 
		/// </summary>
		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PayrollTaxExpenseSubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Tax Expense Sub. 
		/// </summary>
		[DataMember(Name="TaxExpenseSub", EmitDefaultValue=false)]
		public StringValue? TaxExpenseSub { get; set; }

		/// <summary>
		/// DAC Field Name: PayrollTaxLiabilityAcctID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Tax Liability Account 
		/// </summary>
		[DataMember(Name="TaxLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? TaxLiabilityAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PayrollTaxLiabilitySubID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Tax Liability Sub. 
		/// </summary>
		[DataMember(Name="TaxLiabilitySub", EmitDefaultValue=false)]
		public StringValue? TaxLiabilitySub { get; set; }

	}
}