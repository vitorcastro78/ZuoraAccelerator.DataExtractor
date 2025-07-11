using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// An object that contains the VAT Identification number.
    /// </summary>
    [DataContract]
    public class TaxIdentifier
    {
        /// <summary>
        /// Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters.
        /// </summary>
        /// <value>Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        
    }
}