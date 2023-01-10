/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// SweepCounterparty
    /// </summary>
    [DataContract(Name = "SweepCounterparty")]
    public partial class SweepCounterparty : IEquatable<SweepCounterparty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepCounterparty" /> class.
        /// </summary>
        /// <param name="balanceAccountId">The unique identifier of the destination or source [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id).   You can only use this for periodic sweep schedules such as &#x60;schedule.type&#x60; **daily** or **monthly**..</param>
        /// <param name="merchantAccount">The merchant account that will be the source of funds, if you are processing payments with Adyen. You can only use this with sweeps of &#x60;type&#x60; **pull** and &#x60;schedule.type&#x60; **balance**..</param>
        /// <param name="transferInstrumentId">The unique identifier of the destination or source [transfer instrument](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/transferInstruments__resParam_id).  You can also use this in combination with a &#x60;merchantAccount&#x60; and a &#x60;type&#x60; **pull** to start a direct debit request from the source transfer instrument. To use this feature, reach out to your Adyen contact..</param>
        public SweepCounterparty(string balanceAccountId = default(string), string merchantAccount = default(string), string transferInstrumentId = default(string))
        {
            this.BalanceAccountId = balanceAccountId;
            this.MerchantAccount = merchantAccount;
            this.TransferInstrumentId = transferInstrumentId;
        }

        /// <summary>
        /// The unique identifier of the destination or source [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id).   You can only use this for periodic sweep schedules such as &#x60;schedule.type&#x60; **daily** or **monthly**.
        /// </summary>
        /// <value>The unique identifier of the destination or source [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id).   You can only use this for periodic sweep schedules such as &#x60;schedule.type&#x60; **daily** or **monthly**.</value>
        [DataMember(Name = "balanceAccountId", EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// The merchant account that will be the source of funds, if you are processing payments with Adyen. You can only use this with sweeps of &#x60;type&#x60; **pull** and &#x60;schedule.type&#x60; **balance**.
        /// </summary>
        /// <value>The merchant account that will be the source of funds, if you are processing payments with Adyen. You can only use this with sweeps of &#x60;type&#x60; **pull** and &#x60;schedule.type&#x60; **balance**.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The unique identifier of the destination or source [transfer instrument](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/transferInstruments__resParam_id).  You can also use this in combination with a &#x60;merchantAccount&#x60; and a &#x60;type&#x60; **pull** to start a direct debit request from the source transfer instrument. To use this feature, reach out to your Adyen contact.
        /// </summary>
        /// <value>The unique identifier of the destination or source [transfer instrument](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/transferInstruments__resParam_id).  You can also use this in combination with a &#x60;merchantAccount&#x60; and a &#x60;type&#x60; **pull** to start a direct debit request from the source transfer instrument. To use this feature, reach out to your Adyen contact.</value>
        [DataMember(Name = "transferInstrumentId", EmitDefaultValue = false)]
        public string TransferInstrumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SweepCounterparty {\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  TransferInstrumentId: ").Append(TransferInstrumentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SweepCounterparty);
        }

        /// <summary>
        /// Returns true if SweepCounterparty instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepCounterparty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepCounterparty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalanceAccountId == input.BalanceAccountId ||
                    (this.BalanceAccountId != null &&
                    this.BalanceAccountId.Equals(input.BalanceAccountId))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.TransferInstrumentId == input.TransferInstrumentId ||
                    (this.TransferInstrumentId != null &&
                    this.TransferInstrumentId.Equals(input.TransferInstrumentId))
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
                int hashCode = 41;
                if (this.BalanceAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAccountId.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.TransferInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferInstrumentId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
