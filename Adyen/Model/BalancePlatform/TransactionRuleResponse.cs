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
    /// TransactionRuleResponse
    /// </summary>
    [DataContract(Name = "TransactionRuleResponse")]
    public partial class TransactionRuleResponse : IEquatable<TransactionRuleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRuleResponse" /> class.
        /// </summary>
        /// <param name="transactionRule">transactionRule.</param>
        public TransactionRuleResponse(TransactionRule transactionRule = default(TransactionRule))
        {
            this.TransactionRule = transactionRule;
        }

        /// <summary>
        /// Gets or Sets TransactionRule
        /// </summary>
        [DataMember(Name = "transactionRule", EmitDefaultValue = false)]
        public TransactionRule TransactionRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRuleResponse {\n");
            sb.Append("  TransactionRule: ").Append(TransactionRule).Append("\n");
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
            return this.Equals(input as TransactionRuleResponse);
        }

        /// <summary>
        /// Returns true if TransactionRuleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRuleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionRule == input.TransactionRule ||
                    (this.TransactionRule != null &&
                    this.TransactionRule.Equals(input.TransactionRule))
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
                if (this.TransactionRule != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionRule.GetHashCode();
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
