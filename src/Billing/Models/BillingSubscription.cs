// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// A billing Subscription resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingSubscription : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingSubscription class.
        /// </summary>
        public BillingSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingSubscription class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">display name.</param>
        /// <param name="subscriptionId">Subscription Id.</param>
        /// <param name="subscriptionBillingStatus">Subscription billing
        /// status. Possible values include: 'Active', 'Inactive', 'Abandoned',
        /// 'Deleted', 'Warning'</param>
        /// <param name="lastMonthCharges">Last month charges.</param>
        /// <param name="monthToDateCharges">Month to date charges.</param>
        /// <param name="billingProfileId">Billing Profile id to which this
        /// product belongs.</param>
        /// <param name="billingProfileDisplayName">Billing Profile display
        /// name to which this product belongs.</param>
        /// <param name="customerId">Customer id to which this product
        /// belongs.</param>
        /// <param name="customerDisplayName">Display name of customer to which
        /// this product belongs.</param>
        /// <param name="invoiceSectionId">Invoice section id to which this
        /// product belongs.</param>
        /// <param name="invoiceSectionDisplayName">Invoice section display
        /// name to which this product belongs.</param>
        /// <param name="reseller">Reseller for this subscription.</param>
        /// <param name="skuId">The sku id.</param>
        /// <param name="skuDescription">The sku description.</param>
        public BillingSubscription(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), System.Guid? subscriptionId = default(System.Guid?), string subscriptionBillingStatus = default(string), Amount lastMonthCharges = default(Amount), Amount monthToDateCharges = default(Amount), string billingProfileId = default(string), string billingProfileDisplayName = default(string), string customerId = default(string), string customerDisplayName = default(string), string invoiceSectionId = default(string), string invoiceSectionDisplayName = default(string), Reseller reseller = default(Reseller), string skuId = default(string), string skuDescription = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            SubscriptionId = subscriptionId;
            SubscriptionBillingStatus = subscriptionBillingStatus;
            LastMonthCharges = lastMonthCharges;
            MonthToDateCharges = monthToDateCharges;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            CustomerId = customerId;
            CustomerDisplayName = customerDisplayName;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            Reseller = reseller;
            SkuId = skuId;
            SkuDescription = skuDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets subscription Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public System.Guid? SubscriptionId { get; private set; }

        /// <summary>
        /// Gets or sets subscription billing status. Possible values include:
        /// 'Active', 'Inactive', 'Abandoned', 'Deleted', 'Warning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionBillingStatus")]
        public string SubscriptionBillingStatus { get; set; }

        /// <summary>
        /// Gets last month charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastMonthCharges")]
        public Amount LastMonthCharges { get; private set; }

        /// <summary>
        /// Gets month to date charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monthToDateCharges")]
        public Amount MonthToDateCharges { get; private set; }

        /// <summary>
        /// Gets billing Profile id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing Profile display name to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; private set; }

        /// <summary>
        /// Gets customer id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets display name of customer to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerDisplayName")]
        public string CustomerDisplayName { get; private set; }

        /// <summary>
        /// Gets invoice section id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets invoice section display name to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionDisplayName")]
        public string InvoiceSectionDisplayName { get; private set; }

        /// <summary>
        /// Gets reseller for this subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reseller")]
        public Reseller Reseller { get; private set; }

        /// <summary>
        /// Gets or sets the sku id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuId")]
        public string SkuId { get; set; }

        /// <summary>
        /// Gets the sku description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuDescription")]
        public string SkuDescription { get; private set; }

    }
}
