using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Address information used in billing details.
    /// </summary>
    [DataContract]
    public class AddressFieldDefinitions
    {
        /// <summary>
        /// City, district, suburb, town, or village.
        /// </summary>
        /// <value>City, district, suburb, town, or village.</value>
        [DataMember(Name = "city")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city")]
        public string? City { get; set; }

        /// <summary>
        /// The country of the contact's address.
        /// </summary>
        /// <value>The country of the contact's address.</value>
        [DataMember(Name = "country")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "country")]
        public string? Country { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Address line 1 (e.g., street, PO Box, or company name).
        /// </summary>
        /// <value>Address line 1 (e.g., street, PO Box, or company name).</value>
        [DataMember(Name = "line1")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "line1")]
        public string? Line1 { get; set; }

        /// <summary>
        /// Address line 2 (e.g., apartment, suite, unit, or building).
        /// </summary>
        /// <value>Address line 2 (e.g., apartment, suite, unit, or building).</value>
        [DataMember(Name = "line2")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "line2")]
        public string? Line2 { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        /// <value>ZIP or postal code.</value>
        [DataMember(Name = "postal_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// The state, county, province, or region.
        /// </summary>
        /// <value>The state, county, province, or region.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string? State { get; set; }

       
    }
}