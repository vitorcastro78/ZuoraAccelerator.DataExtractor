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
    public class ValidityPeriod
    {
        /// <summary>
        /// End date of the fund effective period.
        /// </summary>
        /// <value>End date of the fund effective period.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets OverageRatedAmount
        /// </summary>
        [DataMember(Name = "overage_rated_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overage_rated_amount")]
        public decimal? OverageRatedAmount { get; set; }

        /// <summary>
        /// Gets or Sets OverageRatedQuantity
        /// </summary>
        [DataMember(Name = "overage_rated_quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overage_rated_quantity")]
        public decimal? OverageRatedQuantity { get; set; }

        /// <summary>
        /// Unit of measure for the prepaid balance.
        /// </summary>
        /// <value>Unit of measure for the prepaid balance.</value>
        [DataMember(Name = "prepaid_uom")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepaid_uom")]
        public Guid? PrepaidUOM { get; set; }

        /// <summary>
        /// Remaining balance on the fund, which is the remaining units of the fund.
        /// </summary>
        /// <value>Remaining balance on the fund, which is the remaining units of the fund. </value>
        [DataMember(Name = "remaining_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_balance")]
        public decimal? RemainingBalance { get; set; }

        /// <summary>
        /// Start date of the fund effective period.
        /// </summary>
        /// <value>Start date of the fund effective period.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The funded balance, which is the total units of the fund.
        /// </summary>
        /// <value>The funded balance, which is the total units of the fund. </value>
        [DataMember(Name = "total_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_balance")]
        public decimal? TotalBalance { get; set; }

        /// <summary>
        /// An array of prepaid balance transactions for a specific validity period
        /// </summary>
        /// <value>An array of prepaid balance transactions for a specific validity period</value>
        [DataMember(Name = "transactions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transactions")]
        public List<PrepaidBalanceTransaction> Transactions { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string? ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidityPeriod {\n");
            sb.Append("  PrepaidUOM: ").Append(PrepaidUOM).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalBalance: ").Append(TotalBalance).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  OverageRatedAmount: ").Append(OverageRatedAmount).Append("\n");
            sb.Append("  OverageRatedQuantity: ").Append(OverageRatedQuantity).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}