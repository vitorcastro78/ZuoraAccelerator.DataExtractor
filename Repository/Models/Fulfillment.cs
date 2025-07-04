using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;
using System;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Fulfillment
    {
        /// <summary>
        /// The name of the shipping carrier for this fulfillment.
        /// </summary>
        /// <value>The name of the shipping carrier for this fulfillment.</value>
        [DataMember(Name = "carrier")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "carrier")]
        public string? Carrier { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public Guid? CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields? CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject? CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        /// An external identifier for the fulfillment.
        /// </summary>
        /// <value>An external identifier for the fulfillment.</value>
        [DataMember(Name = "external_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "external_id")]
        public Guid? ExternalId { get; set; }

        /// <summary>
        /// The date of the fulfillment.
        /// </summary>
        /// <value>The date of the fulfillment.</value>
        [DataMember(Name = "fulfillment_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fulfillment_date")]
        public DateTime? FulfillmentDate { get; set; }

        /// <summary>
        /// Human-readable identifier for the object. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier for the object. It can be user-supplied.</value>
        [DataMember(Name = "fulfillment_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fulfillment_number")]
        public string? FulfillmentNumber { get; set; }

        /// <summary>
        /// The fulfillment system for the fulfillment.
        /// </summary>
        /// <value>The fulfillment system for the fulfillment.</value>
        [DataMember(Name = "fulfillment_system")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fulfillment_system")]
        public string? FulfillmentSystem { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        ///// <summary>
        ///// The fulfillment location of the fulfillment.
        ///// </summary>
        ///// <value>The fulfillment location of the fulfillment.</value>
        //[DataMember(Name = "location")]
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location")]
        //public Location Location { get; set; }

        /// <summary>
        /// The unique identifier of the associated order line item.
        /// </summary>
        /// <value>The unique identifier of the associated order line item.</value>
        [DataMember(Name = "order_line_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order_line_item_id")]
        public Guid? OrderLineItemId { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name = "revenue")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue")]
        public Revenue? Revenue { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        /// <value>The status of the invoice.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string? State { get; set; }

        /// <summary>
        /// All order line items associated with this fulfillment that were unbilled on or before this date are included in future bill runs.
        /// </summary>
        /// <value>All order line items associated with this fulfillment that were unbilled on or before this date are included in future bill runs.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// The tracking number of the fulfillment.
        /// </summary>
        /// <value>The tracking number of the fulfillment.</value>
        [DataMember(Name = "tracking_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tracking_number")]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// The type of fulfillment.
        /// </summary>
        /// <value>The type of fulfillment.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string? Type { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public Guid? UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

       
    }
}