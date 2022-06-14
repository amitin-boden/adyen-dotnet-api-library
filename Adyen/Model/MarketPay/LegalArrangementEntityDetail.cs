#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2022 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// LegalArrangementEntityDetail
    /// </summary>
    [DataContract]
        public partial class LegalArrangementEntityDetail :  IEquatable<LegalArrangementEntityDetail>, IValidatableObject
    {
        /// <summary>
        /// Defines LegalArrangementMembers
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LegalArrangementMembersEnum
        {
            /// <summary>
            /// Enum Beneficiary for value: Beneficiary
            /// </summary>
            [EnumMember(Value = "Beneficiary")]
            Beneficiary = 1,
            /// <summary>
            /// Enum ControllingPerson for value: ControllingPerson
            /// </summary>
            [EnumMember(Value = "ControllingPerson")]
            ControllingPerson = 2,
            /// <summary>
            /// Enum Partner for value: Partner
            /// </summary>
            [EnumMember(Value = "Partner")]
            Partner = 3,
            /// <summary>
            /// Enum Protector for value: Protector
            /// </summary>
            [EnumMember(Value = "Protector")]
            Protector = 4,
            /// <summary>
            /// Enum Settlor for value: Settlor
            /// </summary>
            [EnumMember(Value = "Settlor")]
            Settlor = 5,
            /// <summary>
            /// Enum Shareholder for value: Shareholder
            /// </summary>
            [EnumMember(Value = "Shareholder")]
            Shareholder = 6,
            /// <summary>
            /// Enum Trustee for value: Trustee
            /// </summary>
            [EnumMember(Value = "Trustee")]
            Trustee = 7        }
        /// <summary>
        /// An array containing the roles of the entity in the legal arrangement.  The possible values depend on the legal arrangement &#x60;type&#x60;.  - For &#x60;type&#x60; **Association**: **ControllingPerson** and **Shareholder**.  - For &#x60;type&#x60; **Partnership**: **Partner** and **Shareholder**.  - For &#x60;type&#x60; **Trust**: **Trustee**, **Settlor**, **Protector**, **Beneficiary**,  and **Shareholder**.  
        /// </summary>
        /// <value>An array containing the roles of the entity in the legal arrangement.  The possible values depend on the legal arrangement &#x60;type&#x60;.  - For &#x60;type&#x60; **Association**: **ControllingPerson** and **Shareholder**.  - For &#x60;type&#x60; **Partnership**: **Partner** and **Shareholder**.  - For &#x60;type&#x60; **Trust**: **Trustee**, **Settlor**, **Protector**, **Beneficiary**,  and **Shareholder**.  </value>
        [DataMember(Name="legalArrangementMembers", EmitDefaultValue=false)]
        public List<LegalArrangementMembersEnum> LegalArrangementMembers { get; set; }
        /// <summary>
        /// The legal entity type.  Possible values: **Business**, **Individual**, **NonProfit**, **PublicCompany**, or **Partnership**. 
        /// </summary>
        /// <value>The legal entity type.  Possible values: **Business**, **Individual**, **NonProfit**, **PublicCompany**, or **Partnership**. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LegalEntityTypeEnum
        {
            /// <summary>
            /// Enum Business for value: Business
            /// </summary>
            [EnumMember(Value = "Business")]
            Business = 1,
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 2,
            /// <summary>
            /// Enum NonProfit for value: NonProfit
            /// </summary>
            [EnumMember(Value = "NonProfit")]
            NonProfit = 3,
            /// <summary>
            /// Enum Partnership for value: Partnership
            /// </summary>
            [EnumMember(Value = "Partnership")]
            Partnership = 4,
            /// <summary>
            /// Enum PublicCompany for value: PublicCompany
            /// </summary>
            [EnumMember(Value = "PublicCompany")]
            PublicCompany = 5        }
        /// <summary>
        /// The legal entity type.  Possible values: **Business**, **Individual**, **NonProfit**, **PublicCompany**, or **Partnership**. 
        /// </summary>
        /// <value>The legal entity type.  Possible values: **Business**, **Individual**, **NonProfit**, **PublicCompany**, or **Partnership**. </value>
        [DataMember(Name="legalEntityType", EmitDefaultValue=false)]
        public LegalEntityTypeEnum LegalEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalArrangementEntityDetail" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="businessDetails">businessDetails.</param>
        /// <param name="email">The e-mail address of the entity..</param>
        /// <param name="fullPhoneNumber">The phone number of the contact provided as a single string.  It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;.</param>
        /// <param name="individualDetails">individualDetails.</param>
        /// <param name="legalArrangementEntityCode">Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement entity. Required when updating an existing legal arrangement entity entry in an &#x60;/updateAccountHolder&#x60; request..</param>
        /// <param name="legalArrangementEntityReference">Your reference for the legal arrangement entity..</param>
        /// <param name="legalArrangementMembers">An array containing the roles of the entity in the legal arrangement.  The possible values depend on the legal arrangement &#x60;type&#x60;.  - For &#x60;type&#x60; **Association**: **ControllingPerson** and **Shareholder**.  - For &#x60;type&#x60; **Partnership**: **Partner** and **Shareholder**.  - For &#x60;type&#x60; **Trust**: **Trustee**, **Settlor**, **Protector**, **Beneficiary**,  and **Shareholder**.  .</param>
        /// <param name="legalEntityType">The legal entity type.  Possible values: **Business**, **Individual**, **NonProfit**, **PublicCompany**, or **Partnership**.  (required).</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="webAddress">The URL of the website of the contact..</param>
        public LegalArrangementEntityDetail(ViasAddress address = default(ViasAddress), BusinessDetails businessDetails = default(BusinessDetails), string email = default(string), string fullPhoneNumber = default(string), IndividualDetails individualDetails = default(IndividualDetails), string legalArrangementEntityCode = default(string), string legalArrangementEntityReference = default(string), List<LegalArrangementMembersEnum> legalArrangementMembers = default(List<LegalArrangementMembersEnum>), LegalEntityTypeEnum legalEntityType = default(LegalEntityTypeEnum), ViasPhoneNumber phoneNumber = default(ViasPhoneNumber), string webAddress = default(string))
        {
            // to ensure "legalEntityType" is required (not null)
            if (legalEntityType == null)
            {
                throw new InvalidDataException("legalEntityType is a required property for LegalArrangementEntityDetail and cannot be null");
            }
            else
            {
                this.LegalEntityType = legalEntityType;
            }
            this.Address = address;
            this.BusinessDetails = businessDetails;
            this.Email = email;
            this.FullPhoneNumber = fullPhoneNumber;
            this.IndividualDetails = individualDetails;
            this.LegalArrangementEntityCode = legalArrangementEntityCode;
            this.LegalArrangementEntityReference = legalArrangementEntityReference;
            this.LegalArrangementMembers = legalArrangementMembers;
            this.PhoneNumber = phoneNumber;
            this.WebAddress = webAddress;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets BusinessDetails
        /// </summary>
        [DataMember(Name="businessDetails", EmitDefaultValue=false)]
        public BusinessDetails BusinessDetails { get; set; }

        /// <summary>
        /// The e-mail address of the entity.
        /// </summary>
        /// <value>The e-mail address of the entity.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the contact provided as a single string.  It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;
        /// </summary>
        /// <value>The phone number of the contact provided as a single string.  It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;</value>
        [DataMember(Name="fullPhoneNumber", EmitDefaultValue=false)]
        public string FullPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets IndividualDetails
        /// </summary>
        [DataMember(Name="individualDetails", EmitDefaultValue=false)]
        public IndividualDetails IndividualDetails { get; set; }

        /// <summary>
        /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement entity. Required when updating an existing legal arrangement entity entry in an &#x60;/updateAccountHolder&#x60; request.
        /// </summary>
        /// <value>Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement entity. Required when updating an existing legal arrangement entity entry in an &#x60;/updateAccountHolder&#x60; request.</value>
        [DataMember(Name="legalArrangementEntityCode", EmitDefaultValue=false)]
        public string LegalArrangementEntityCode { get; set; }

        /// <summary>
        /// Your reference for the legal arrangement entity.
        /// </summary>
        /// <value>Your reference for the legal arrangement entity.</value>
        [DataMember(Name="legalArrangementEntityReference", EmitDefaultValue=false)]
        public string LegalArrangementEntityReference { get; set; }



        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public ViasPhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// The URL of the website of the contact.
        /// </summary>
        /// <value>The URL of the website of the contact.</value>
        [DataMember(Name="webAddress", EmitDefaultValue=false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalArrangementEntityDetail {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BusinessDetails: ").Append(BusinessDetails).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullPhoneNumber: ").Append(FullPhoneNumber).Append("\n");
            sb.Append("  IndividualDetails: ").Append(IndividualDetails).Append("\n");
            sb.Append("  LegalArrangementEntityCode: ").Append(LegalArrangementEntityCode).Append("\n");
            sb.Append("  LegalArrangementEntityReference: ").Append(LegalArrangementEntityReference).Append("\n");
            sb.Append("  LegalArrangementMembers: ").Append(LegalArrangementMembers).Append("\n");
            sb.Append("  LegalEntityType: ").Append(LegalEntityType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  WebAddress: ").Append(WebAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LegalArrangementEntityDetail);
        }

        /// <summary>
        /// Returns true if LegalArrangementEntityDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalArrangementEntityDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalArrangementEntityDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BusinessDetails == input.BusinessDetails ||
                    (this.BusinessDetails != null &&
                    this.BusinessDetails.Equals(input.BusinessDetails))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FullPhoneNumber == input.FullPhoneNumber ||
                    (this.FullPhoneNumber != null &&
                    this.FullPhoneNumber.Equals(input.FullPhoneNumber))
                ) && 
                (
                    this.IndividualDetails == input.IndividualDetails ||
                    (this.IndividualDetails != null &&
                    this.IndividualDetails.Equals(input.IndividualDetails))
                ) && 
                (
                    this.LegalArrangementEntityCode == input.LegalArrangementEntityCode ||
                    (this.LegalArrangementEntityCode != null &&
                    this.LegalArrangementEntityCode.Equals(input.LegalArrangementEntityCode))
                ) && 
                (
                    this.LegalArrangementEntityReference == input.LegalArrangementEntityReference ||
                    (this.LegalArrangementEntityReference != null &&
                    this.LegalArrangementEntityReference.Equals(input.LegalArrangementEntityReference))
                ) && 
                (
                    this.LegalArrangementMembers == input.LegalArrangementMembers ||
                    this.LegalArrangementMembers != null &&
                    input.LegalArrangementMembers != null &&
                    this.LegalArrangementMembers.SequenceEqual(input.LegalArrangementMembers)
                ) && 
                (
                    this.LegalEntityType == input.LegalEntityType ||
                    (this.LegalEntityType != null &&
                    this.LegalEntityType.Equals(input.LegalEntityType))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.WebAddress == input.WebAddress ||
                    (this.WebAddress != null &&
                    this.WebAddress.Equals(input.WebAddress))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.BusinessDetails != null)
                    hashCode = hashCode * 59 + this.BusinessDetails.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FullPhoneNumber != null)
                    hashCode = hashCode * 59 + this.FullPhoneNumber.GetHashCode();
                if (this.IndividualDetails != null)
                    hashCode = hashCode * 59 + this.IndividualDetails.GetHashCode();
                if (this.LegalArrangementEntityCode != null)
                    hashCode = hashCode * 59 + this.LegalArrangementEntityCode.GetHashCode();
                if (this.LegalArrangementEntityReference != null)
                    hashCode = hashCode * 59 + this.LegalArrangementEntityReference.GetHashCode();
                if (this.LegalArrangementMembers != null)
                    hashCode = hashCode * 59 + this.LegalArrangementMembers.GetHashCode();
                if (this.LegalEntityType != null)
                    hashCode = hashCode * 59 + this.LegalEntityType.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.WebAddress != null)
                    hashCode = hashCode * 59 + this.WebAddress.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}