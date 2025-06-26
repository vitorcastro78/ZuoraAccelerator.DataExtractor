using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Term information of the subscription.
    /// </summary>
    [DataContract]
    public class SubscriptionTerm
    {
        /// <summary>
        /// If true, the subscription automatically renews at the end of the current term.
        /// </summary>
        /// <value>If true, the subscription automatically renews at the end of the current term.</value>
        [DataMember(Name = "auto_renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_renew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Current term information for the subscription.
        /// </summary>
        /// <value>Current term information for the subscription.</value>
        [DataMember(Name = "current_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "current_term")]
        public Term CurrentTerm { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Renewal term information for the subscription.
        /// </summary>
        /// <value>Renewal term information for the subscription.</value>
        [DataMember(Name = "renewal_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewal_term")]
        public Term RenewalTerm { get; set; }

       
    }
}