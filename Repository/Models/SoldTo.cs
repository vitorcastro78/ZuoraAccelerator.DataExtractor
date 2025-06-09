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
    public class SoldTo
    {
        /// <summary>
        /// Identifier of a customer account with which this contact is associated.
        /// </summary>
        /// <value>Identifier of a customer account with which this contact is associated.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address")]
        public Address Address { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public Guid CreatedById { get; set; }

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
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        /// <value>Customer email address.</value>
        [DataMember(Name = "email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The contact's fax number.
        /// </summary>
        /// <value>The contact's fax number.</value>
        [DataMember(Name = "fax")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Customer first name.
        /// </summary>
        /// <value>Customer first name.</value>
        [DataMember(Name = "first_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer home phone (including extension).
        /// </summary>
        /// <value>Customer home phone (including extension).</value>
        [DataMember(Name = "home_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "home_phone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Customer last name.
        /// </summary>
        /// <value>Customer last name.</value>
        [DataMember(Name = "last_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Customer phone (including extension).
        /// </summary>
        /// <value>Customer phone (including extension).</value>
        [DataMember(Name = "mobile_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Nickname for this contact.
        /// </summary>
        /// <value>Nickname for this contact.</value>
        [DataMember(Name = "nickname")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Other customer phone (including extension).
        /// </summary>
        /// <value>Other customer phone (including extension).</value>
        [DataMember(Name = "other_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "other_phone")]
        public string OtherPhone { get; set; }

        /// <summary>
        /// The type of the additional phone number.
        /// </summary>
        /// <value>The type of the additional phone number.</value>
        [DataMember(Name = "other_phone_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "other_phone_type")]
        public string OtherPhoneType { get; set; }

        /// <summary>
        /// A region defined in your Zuora Tax rules.
        /// </summary>
        /// <value>A region defined in your Zuora Tax rules.</value>
        [DataMember(Name = "tax_region")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_region")]
        public string TaxRegion { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public Guid UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Customer work email.
        /// </summary>
        /// <value>Customer work email.</value>
        [DataMember(Name = "work_email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "work_email")]
        public string WorkEmail { get; set; }

        /// <summary>
        /// Customer work phone.
        /// </summary>
        /// <value>Customer work phone.</value>
        [DataMember(Name = "work_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "work_phone")]
        public string WorkPhone { get; set; }

        
    }
}