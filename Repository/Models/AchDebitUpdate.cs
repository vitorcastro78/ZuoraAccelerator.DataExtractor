using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AchDebitUpdate
    {
        /// <summary>
        /// The nine-digit routing number or ABA number used by banks.
        /// </summary>
        /// <value>The nine-digit routing number or ABA number used by banks.</value>
        [DataMember(Name = "bank_aba_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_aba_code")]
        public string? BankAbaCode { get; set; }

        /// <summary>
        /// The name of the account holder, which can be either a person or a company.
        /// </summary>
        /// <value>The name of the account holder, which can be either a person or a company.</value>
        [DataMember(Name = "bank_account_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_name")]
        public string? BankAccountName { get; set; }

        /// <summary>
        /// The type of bank account associated with the payment method.
        /// </summary>
        /// <value>The type of bank account associated with the payment method.</value>
        [DataMember(Name = "bank_account_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_type")]
        public string? BankAccountType { get; set; }

        /// <summary>
        /// Name of the bank associated with this bank account.
        /// </summary>
        /// <value>Name of the bank associated with this bank account.</value>
        [DataMember(Name = "bank_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_name")]
        public string? BankName { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public Mandate Mandate { get; set; }

        
    }
}