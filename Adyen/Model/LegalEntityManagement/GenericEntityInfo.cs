/*
* Legal Entity Management API
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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// GenericEntityInfo
    /// </summary>
    [DataContract]
    public partial class GenericEntityInfo :  IEquatable<GenericEntityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericEntityInfo" /> class.
        /// </summary>
        /// <param name="entityAssociations">List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories..</param>
        /// <param name="individual">individual.</param>
        /// <param name="organization">organization.</param>
        /// <param name="soleProprietorship">soleProprietorship.</param>
        public GenericEntityInfo(List<LegalEntityAssociation> entityAssociations = default(List<LegalEntityAssociation>), Individual individual = default(Individual), Organization organization = default(Organization), SoleProprietorship soleProprietorship = default(SoleProprietorship))
        {
            this.EntityAssociations = entityAssociations;
            this.Individual = individual;
            this.Organization = organization;
            this.SoleProprietorship = soleProprietorship;
        }

        /// <summary>
        /// List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.
        /// </summary>
        /// <value>List of legal entities associated with the current legal entity. For example, ultimate beneficial owners associated with an organization through ownership or control, or as signatories.</value>
        [DataMember(Name="entityAssociations", EmitDefaultValue=false)]
        public List<LegalEntityAssociation> EntityAssociations { get; set; }

        /// <summary>
        /// Gets or Sets Individual
        /// </summary>
        [DataMember(Name="individual", EmitDefaultValue=false)]
        public Individual Individual { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }

        /// <summary>
        /// Gets or Sets SoleProprietorship
        /// </summary>
        [DataMember(Name="soleProprietorship", EmitDefaultValue=false)]
        public SoleProprietorship SoleProprietorship { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericEntityInfo {\n");
            sb.Append("  EntityAssociations: ").Append(EntityAssociations).Append("\n");
            sb.Append("  Individual: ").Append(Individual).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  SoleProprietorship: ").Append(SoleProprietorship).Append("\n");
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
            return this.Equals(input as GenericEntityInfo);
        }

        /// <summary>
        /// Returns true if GenericEntityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericEntityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericEntityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityAssociations == input.EntityAssociations ||
                    this.EntityAssociations != null &&
                    input.EntityAssociations != null &&
                    this.EntityAssociations.SequenceEqual(input.EntityAssociations)
                ) && 
                (
                    this.Individual == input.Individual ||
                    (this.Individual != null &&
                    this.Individual.Equals(input.Individual))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.SoleProprietorship == input.SoleProprietorship ||
                    (this.SoleProprietorship != null &&
                    this.SoleProprietorship.Equals(input.SoleProprietorship))
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
                if (this.EntityAssociations != null)
                    hashCode = hashCode * 59 + this.EntityAssociations.GetHashCode();
                if (this.Individual != null)
                    hashCode = hashCode * 59 + this.Individual.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.SoleProprietorship != null)
                    hashCode = hashCode * 59 + this.SoleProprietorship.GetHashCode();
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
