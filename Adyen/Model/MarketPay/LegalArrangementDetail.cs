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
    /// LegalArrangementDetail
    /// </summary>
    [DataContract]
        public partial class LegalArrangementDetail :  IEquatable<LegalArrangementDetail>, IValidatableObject
    {
        /// <summary>
        /// The form of legal arrangement. Required if &#x60;type&#x60; is **Trust** or **Partnership**.  The possible values depend on the &#x60;type&#x60;.  - For &#x60;type&#x60; **Trust**:  **CashManagementTrust**, **CorporateUnitTrust**, **DeceasedEstate**, **DiscretionaryInvestmentTrust**, **DiscretionaryServicesManagementTrust**, **DiscretionaryTradingTrust**, **FirstHomeSaverAccountsTrust**, **FixedTrust**, **FixedUnitTrust**, **HybridTrust**, **ListedPublicUnitTrust**, **OtherTrust**, **PooledSuperannuationTrust**, **PublicTradingTrust**, or **UnlistedPublicUnitTrust**.  - For &#x60;type&#x60; **Partnership**: **LimitedPartnership**, **FamilyPartnership**, or **OtherPartnership**
        /// </summary>
        /// <value>The form of legal arrangement. Required if &#x60;type&#x60; is **Trust** or **Partnership**.  The possible values depend on the &#x60;type&#x60;.  - For &#x60;type&#x60; **Trust**:  **CashManagementTrust**, **CorporateUnitTrust**, **DeceasedEstate**, **DiscretionaryInvestmentTrust**, **DiscretionaryServicesManagementTrust**, **DiscretionaryTradingTrust**, **FirstHomeSaverAccountsTrust**, **FixedTrust**, **FixedUnitTrust**, **HybridTrust**, **ListedPublicUnitTrust**, **OtherTrust**, **PooledSuperannuationTrust**, **PublicTradingTrust**, or **UnlistedPublicUnitTrust**.  - For &#x60;type&#x60; **Partnership**: **LimitedPartnership**, **FamilyPartnership**, or **OtherPartnership**</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LegalFormEnum
        {
            /// <summary>
            /// Enum CashManagementTrust for value: CashManagementTrust
            /// </summary>
            [EnumMember(Value = "CashManagementTrust")]
            CashManagementTrust = 1,
            /// <summary>
            /// Enum CorporateUnitTrust for value: CorporateUnitTrust
            /// </summary>
            [EnumMember(Value = "CorporateUnitTrust")]
            CorporateUnitTrust = 2,
            /// <summary>
            /// Enum DeceasedEstate for value: DeceasedEstate
            /// </summary>
            [EnumMember(Value = "DeceasedEstate")]
            DeceasedEstate = 3,
            /// <summary>
            /// Enum DiscretionaryInvestmentTrust for value: DiscretionaryInvestmentTrust
            /// </summary>
            [EnumMember(Value = "DiscretionaryInvestmentTrust")]
            DiscretionaryInvestmentTrust = 4,
            /// <summary>
            /// Enum DiscretionaryServicesManagementTrust for value: DiscretionaryServicesManagementTrust
            /// </summary>
            [EnumMember(Value = "DiscretionaryServicesManagementTrust")]
            DiscretionaryServicesManagementTrust = 5,
            /// <summary>
            /// Enum DiscretionaryTradingTrust for value: DiscretionaryTradingTrust
            /// </summary>
            [EnumMember(Value = "DiscretionaryTradingTrust")]
            DiscretionaryTradingTrust = 6,
            /// <summary>
            /// Enum FirstHomeSaverAccountsTrust for value: FirstHomeSaverAccountsTrust
            /// </summary>
            [EnumMember(Value = "FirstHomeSaverAccountsTrust")]
            FirstHomeSaverAccountsTrust = 7,
            /// <summary>
            /// Enum FixedTrust for value: FixedTrust
            /// </summary>
            [EnumMember(Value = "FixedTrust")]
            FixedTrust = 8,
            /// <summary>
            /// Enum FixedUnitTrust for value: FixedUnitTrust
            /// </summary>
            [EnumMember(Value = "FixedUnitTrust")]
            FixedUnitTrust = 9,
            /// <summary>
            /// Enum HybridTrust for value: HybridTrust
            /// </summary>
            [EnumMember(Value = "HybridTrust")]
            HybridTrust = 10,
            /// <summary>
            /// Enum ListedPublicUnitTrust for value: ListedPublicUnitTrust
            /// </summary>
            [EnumMember(Value = "ListedPublicUnitTrust")]
            ListedPublicUnitTrust = 11,
            /// <summary>
            /// Enum OtherTrust for value: OtherTrust
            /// </summary>
            [EnumMember(Value = "OtherTrust")]
            OtherTrust = 12,
            /// <summary>
            /// Enum PooledSuperannuationTrust for value: PooledSuperannuationTrust
            /// </summary>
            [EnumMember(Value = "PooledSuperannuationTrust")]
            PooledSuperannuationTrust = 13,
            /// <summary>
            /// Enum PublicTradingTrust for value: PublicTradingTrust
            /// </summary>
            [EnumMember(Value = "PublicTradingTrust")]
            PublicTradingTrust = 14,
            /// <summary>
            /// Enum UnlistedPublicUnitTrust for value: UnlistedPublicUnitTrust
            /// </summary>
            [EnumMember(Value = "UnlistedPublicUnitTrust")]
            UnlistedPublicUnitTrust = 15,
            /// <summary>
            /// Enum LimitedPartnership for value: LimitedPartnership
            /// </summary>
            [EnumMember(Value = "LimitedPartnership")]
            LimitedPartnership = 16,
            /// <summary>
            /// Enum FamilyPartnership for value: FamilyPartnership
            /// </summary>
            [EnumMember(Value = "FamilyPartnership")]
            FamilyPartnership = 17,
            /// <summary>
            /// Enum OtherPartnership for value: OtherPartnership
            /// </summary>
            [EnumMember(Value = "OtherPartnership")]
            OtherPartnership = 18        }
        /// <summary>
        /// The form of legal arrangement. Required if &#x60;type&#x60; is **Trust** or **Partnership**.  The possible values depend on the &#x60;type&#x60;.  - For &#x60;type&#x60; **Trust**:  **CashManagementTrust**, **CorporateUnitTrust**, **DeceasedEstate**, **DiscretionaryInvestmentTrust**, **DiscretionaryServicesManagementTrust**, **DiscretionaryTradingTrust**, **FirstHomeSaverAccountsTrust**, **FixedTrust**, **FixedUnitTrust**, **HybridTrust**, **ListedPublicUnitTrust**, **OtherTrust**, **PooledSuperannuationTrust**, **PublicTradingTrust**, or **UnlistedPublicUnitTrust**.  - For &#x60;type&#x60; **Partnership**: **LimitedPartnership**, **FamilyPartnership**, or **OtherPartnership**
        /// </summary>
        /// <value>The form of legal arrangement. Required if &#x60;type&#x60; is **Trust** or **Partnership**.  The possible values depend on the &#x60;type&#x60;.  - For &#x60;type&#x60; **Trust**:  **CashManagementTrust**, **CorporateUnitTrust**, **DeceasedEstate**, **DiscretionaryInvestmentTrust**, **DiscretionaryServicesManagementTrust**, **DiscretionaryTradingTrust**, **FirstHomeSaverAccountsTrust**, **FixedTrust**, **FixedUnitTrust**, **HybridTrust**, **ListedPublicUnitTrust**, **OtherTrust**, **PooledSuperannuationTrust**, **PublicTradingTrust**, or **UnlistedPublicUnitTrust**.  - For &#x60;type&#x60; **Partnership**: **LimitedPartnership**, **FamilyPartnership**, or **OtherPartnership**</value>
        [DataMember(Name="legalForm", EmitDefaultValue=false)]
        public LegalFormEnum? LegalForm { get; set; }
        /// <summary>
        /// The [type of legal arrangement](https://docs.adyen.com/platforms/verification-checks/legal-arrangements#types-of-legal-arrangements).  Possible values:  - **Association**   - **Partnership**   - **SoleProprietorship**   - **Trust**   
        /// </summary>
        /// <value>The [type of legal arrangement](https://docs.adyen.com/platforms/verification-checks/legal-arrangements#types-of-legal-arrangements).  Possible values:  - **Association**   - **Partnership**   - **SoleProprietorship**   - **Trust**   </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Association for value: Association
            /// </summary>
            [EnumMember(Value = "Association")]
            Association = 1,
            /// <summary>
            /// Enum Partnership for value: Partnership
            /// </summary>
            [EnumMember(Value = "Partnership")]
            Partnership = 2,
            /// <summary>
            /// Enum SoleProprietorship for value: SoleProprietorship
            /// </summary>
            [EnumMember(Value = "SoleProprietorship")]
            SoleProprietorship = 3,
            /// <summary>
            /// Enum Trust for value: Trust
            /// </summary>
            [EnumMember(Value = "Trust")]
            Trust = 4        }
        /// <summary>
        /// The [type of legal arrangement](https://docs.adyen.com/platforms/verification-checks/legal-arrangements#types-of-legal-arrangements).  Possible values:  - **Association**   - **Partnership**   - **SoleProprietorship**   - **Trust**   
        /// </summary>
        /// <value>The [type of legal arrangement](https://docs.adyen.com/platforms/verification-checks/legal-arrangements#types-of-legal-arrangements).  Possible values:  - **Association**   - **Partnership**   - **SoleProprietorship**   - **Trust**   </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalArrangementDetail" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="legalArrangementCode">Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement. Required when updating an existing legal arrangement entry in an &#x60;/updateAccountHolder&#x60; request..</param>
        /// <param name="legalArrangementEntities">An array containing information about other entities that are part of the legal arrangement..</param>
        /// <param name="legalArrangementReference">Your reference for the legal arrangement. Must be between 3 to 128 characters..</param>
        /// <param name="legalForm">The form of legal arrangement. Required if &#x60;type&#x60; is **Trust** or **Partnership**.  The possible values depend on the &#x60;type&#x60;.  - For &#x60;type&#x60; **Trust**:  **CashManagementTrust**, **CorporateUnitTrust**, **DeceasedEstate**, **DiscretionaryInvestmentTrust**, **DiscretionaryServicesManagementTrust**, **DiscretionaryTradingTrust**, **FirstHomeSaverAccountsTrust**, **FixedTrust**, **FixedUnitTrust**, **HybridTrust**, **ListedPublicUnitTrust**, **OtherTrust**, **PooledSuperannuationTrust**, **PublicTradingTrust**, or **UnlistedPublicUnitTrust**.  - For &#x60;type&#x60; **Partnership**: **LimitedPartnership**, **FamilyPartnership**, or **OtherPartnership**.</param>
        /// <param name="name">The legal name of the legal arrangement. Minimum length: 3 characters. (required).</param>
        /// <param name="registrationNumber">The registration number of the legal arrangement..</param>
        /// <param name="taxNumber">The tax identification number of the legal arrangement..</param>
        /// <param name="type">The [type of legal arrangement](https://docs.adyen.com/platforms/verification-checks/legal-arrangements#types-of-legal-arrangements).  Possible values:  - **Association**   - **Partnership**   - **SoleProprietorship**   - **Trust**    (required).</param>
        public LegalArrangementDetail(ViasAddress address = default(ViasAddress), string legalArrangementCode = default(string), List<LegalArrangementEntityDetail> legalArrangementEntities = default(List<LegalArrangementEntityDetail>), string legalArrangementReference = default(string), LegalFormEnum? legalForm = default(LegalFormEnum?), string name = default(string), string registrationNumber = default(string), string taxNumber = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for LegalArrangementDetail and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LegalArrangementDetail and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LegalArrangementDetail and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.LegalArrangementCode = legalArrangementCode;
            this.LegalArrangementEntities = legalArrangementEntities;
            this.LegalArrangementReference = legalArrangementReference;
            this.LegalForm = legalForm;
            this.RegistrationNumber = registrationNumber;
            this.TaxNumber = taxNumber;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement. Required when updating an existing legal arrangement entry in an &#x60;/updateAccountHolder&#x60; request.
        /// </summary>
        /// <value>Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement. Required when updating an existing legal arrangement entry in an &#x60;/updateAccountHolder&#x60; request.</value>
        [DataMember(Name="legalArrangementCode", EmitDefaultValue=false)]
        public string LegalArrangementCode { get; set; }

        /// <summary>
        /// An array containing information about other entities that are part of the legal arrangement.
        /// </summary>
        /// <value>An array containing information about other entities that are part of the legal arrangement.</value>
        [DataMember(Name="legalArrangementEntities", EmitDefaultValue=false)]
        public List<LegalArrangementEntityDetail> LegalArrangementEntities { get; set; }

        /// <summary>
        /// Your reference for the legal arrangement. Must be between 3 to 128 characters.
        /// </summary>
        /// <value>Your reference for the legal arrangement. Must be between 3 to 128 characters.</value>
        [DataMember(Name="legalArrangementReference", EmitDefaultValue=false)]
        public string LegalArrangementReference { get; set; }


        /// <summary>
        /// The legal name of the legal arrangement. Minimum length: 3 characters.
        /// </summary>
        /// <value>The legal name of the legal arrangement. Minimum length: 3 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The registration number of the legal arrangement.
        /// </summary>
        /// <value>The registration number of the legal arrangement.</value>
        [DataMember(Name="registrationNumber", EmitDefaultValue=false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The tax identification number of the legal arrangement.
        /// </summary>
        /// <value>The tax identification number of the legal arrangement.</value>
        [DataMember(Name="taxNumber", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalArrangementDetail {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LegalArrangementCode: ").Append(LegalArrangementCode).Append("\n");
            sb.Append("  LegalArrangementEntities: ").Append(LegalArrangementEntities).Append("\n");
            sb.Append("  LegalArrangementReference: ").Append(LegalArrangementReference).Append("\n");
            sb.Append("  LegalForm: ").Append(LegalForm).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as LegalArrangementDetail);
        }

        /// <summary>
        /// Returns true if LegalArrangementDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalArrangementDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalArrangementDetail input)
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
                    this.LegalArrangementCode == input.LegalArrangementCode ||
                    (this.LegalArrangementCode != null &&
                    this.LegalArrangementCode.Equals(input.LegalArrangementCode))
                ) && 
                (
                    this.LegalArrangementEntities == input.LegalArrangementEntities ||
                    this.LegalArrangementEntities != null &&
                    input.LegalArrangementEntities != null &&
                    this.LegalArrangementEntities.SequenceEqual(input.LegalArrangementEntities)
                ) && 
                (
                    this.LegalArrangementReference == input.LegalArrangementReference ||
                    (this.LegalArrangementReference != null &&
                    this.LegalArrangementReference.Equals(input.LegalArrangementReference))
                ) && 
                (
                    this.LegalForm == input.LegalForm ||
                    (this.LegalForm != null &&
                    this.LegalForm.Equals(input.LegalForm))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.LegalArrangementCode != null)
                    hashCode = hashCode * 59 + this.LegalArrangementCode.GetHashCode();
                if (this.LegalArrangementEntities != null)
                    hashCode = hashCode * 59 + this.LegalArrangementEntities.GetHashCode();
                if (this.LegalArrangementReference != null)
                    hashCode = hashCode * 59 + this.LegalArrangementReference.GetHashCode();
                if (this.LegalForm != null)
                    hashCode = hashCode * 59 + this.LegalForm.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.TaxNumber != null)
                    hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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