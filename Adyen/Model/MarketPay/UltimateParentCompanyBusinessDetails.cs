﻿#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2020 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// UltimateParentCompanyBusinessDetails
    /// </summary>
    [DataContract(Name = "UltimateParentCompanyBusinessDetails")]
    public partial class UltimateParentCompanyBusinessDetails : IEquatable<UltimateParentCompanyBusinessDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UltimateParentCompanyBusinessDetails" /> class.
        /// </summary>
        /// <param name="legalBusinessName">The legal name of the company..</param>
        /// <param name="registrationNumber">The registration number of the company..</param>
        /// <param name="stockExchange">Market Identifier Code (MIC)..</param>
        /// <param name="stockNumber">International Securities Identification Number (ISIN)..</param>
        /// <param name="stockTicker">Stock Ticker symbol..</param>
        public UltimateParentCompanyBusinessDetails(string legalBusinessName = default(string), string registrationNumber = default(string), string stockExchange = default(string), string stockNumber = default(string), string stockTicker = default(string))
        {
            this.LegalBusinessName = legalBusinessName;
            this.RegistrationNumber = registrationNumber;
            this.StockExchange = stockExchange;
            this.StockNumber = stockNumber;
            this.StockTicker = stockTicker;
        }

        /// <summary>
        /// The legal name of the company.
        /// </summary>
        /// <value>The legal name of the company.</value>
        [DataMember(Name = "legalBusinessName", EmitDefaultValue = false)]
        public string LegalBusinessName { get; set; }

        /// <summary>
        /// The registration number of the company.
        /// </summary>
        /// <value>The registration number of the company.</value>
        [DataMember(Name = "registrationNumber", EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Market Identifier Code (MIC).
        /// </summary>
        /// <value>Market Identifier Code (MIC).</value>
        [DataMember(Name = "stockExchange", EmitDefaultValue = false)]
        public string StockExchange { get; set; }

        /// <summary>
        /// International Securities Identification Number (ISIN).
        /// </summary>
        /// <value>International Securities Identification Number (ISIN).</value>
        [DataMember(Name = "stockNumber", EmitDefaultValue = false)]
        public string StockNumber { get; set; }

        /// <summary>
        /// Stock Ticker symbol.
        /// </summary>
        /// <value>Stock Ticker symbol.</value>
        [DataMember(Name = "stockTicker", EmitDefaultValue = false)]
        public string StockTicker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UltimateParentCompanyBusinessDetails {\n");
            sb.Append("  LegalBusinessName: ").Append(LegalBusinessName).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
            sb.Append("  StockNumber: ").Append(StockNumber).Append("\n");
            sb.Append("  StockTicker: ").Append(StockTicker).Append("\n");
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
            return this.Equals(input as UltimateParentCompanyBusinessDetails);
        }

        /// <summary>
        /// Returns true if UltimateParentCompanyBusinessDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UltimateParentCompanyBusinessDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UltimateParentCompanyBusinessDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.LegalBusinessName == input.LegalBusinessName ||
                    (this.LegalBusinessName != null &&
                    this.LegalBusinessName.Equals(input.LegalBusinessName))
                ) &&
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) &&
                (
                    this.StockExchange == input.StockExchange ||
                    (this.StockExchange != null &&
                    this.StockExchange.Equals(input.StockExchange))
                ) &&
                (
                    this.StockNumber == input.StockNumber ||
                    (this.StockNumber != null &&
                    this.StockNumber.Equals(input.StockNumber))
                ) &&
                (
                    this.StockTicker == input.StockTicker ||
                    (this.StockTicker != null &&
                    this.StockTicker.Equals(input.StockTicker))
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
                if (this.LegalBusinessName != null)
                    hashCode = hashCode * 59 + this.LegalBusinessName.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.StockExchange != null)
                    hashCode = hashCode * 59 + this.StockExchange.GetHashCode();
                if (this.StockNumber != null)
                    hashCode = hashCode * 59 + this.StockNumber.GetHashCode();
                if (this.StockTicker != null)
                    hashCode = hashCode * 59 + this.StockTicker.GetHashCode();
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
