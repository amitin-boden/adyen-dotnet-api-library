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
using System.Reflection;

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// The schedule when the &#x60;triggerAmount&#x60; is evaluated. If the balance meets the threshold, funds are pushed out of or pulled in to the balance account.
    /// </summary>
    [JsonConverter(typeof(SweepConfigurationV2ScheduleJsonConverter))]
    [DataContract(Name = "SweepConfigurationV2_schedule")]
    public partial class SweepConfigurationV2Schedule : AbstractOpenAPISchema, IEquatable<SweepConfigurationV2Schedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2Schedule" /> class
        /// with the <see cref="CronSweepSchedule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CronSweepSchedule.</param>
        public SweepConfigurationV2Schedule(CronSweepSchedule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SweepConfigurationV2Schedule" /> class
        /// with the <see cref="SweepSchedule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SweepSchedule.</param>
        public SweepConfigurationV2Schedule(SweepSchedule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(CronSweepSchedule))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SweepSchedule))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CronSweepSchedule, SweepSchedule");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CronSweepSchedule`. If the actual instance is not `CronSweepSchedule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CronSweepSchedule</returns>
        public CronSweepSchedule GetCronSweepSchedule()
        {
            return (CronSweepSchedule)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SweepSchedule`. If the actual instance is not `SweepSchedule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SweepSchedule</returns>
        public SweepSchedule GetSweepSchedule()
        {
            return (SweepSchedule)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SweepConfigurationV2Schedule {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, SweepConfigurationV2Schedule.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SweepConfigurationV2Schedule
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SweepConfigurationV2Schedule</returns>
        public static SweepConfigurationV2Schedule FromJson(string jsonString)
        {
            SweepConfigurationV2Schedule newSweepConfigurationV2Schedule = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSweepConfigurationV2Schedule;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CronSweepSchedule).GetProperty("AdditionalProperties") == null)
                {
                    newSweepConfigurationV2Schedule = new SweepConfigurationV2Schedule(JsonConvert.DeserializeObject<CronSweepSchedule>(jsonString, SweepConfigurationV2Schedule.SerializerSettings));
                }
                else
                {
                    newSweepConfigurationV2Schedule = new SweepConfigurationV2Schedule(JsonConvert.DeserializeObject<CronSweepSchedule>(jsonString, SweepConfigurationV2Schedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CronSweepSchedule");
                match++;
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SweepSchedule).GetProperty("AdditionalProperties") == null)
                {
                    newSweepConfigurationV2Schedule = new SweepConfigurationV2Schedule(JsonConvert.DeserializeObject<SweepSchedule>(jsonString, SweepConfigurationV2Schedule.SerializerSettings));
                }
                else
                {
                    newSweepConfigurationV2Schedule = new SweepConfigurationV2Schedule(JsonConvert.DeserializeObject<SweepSchedule>(jsonString, SweepConfigurationV2Schedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SweepSchedule");
                match++;
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newSweepConfigurationV2Schedule;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SweepConfigurationV2Schedule);
        }

        /// <summary>
        /// Returns true if SweepConfigurationV2Schedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepConfigurationV2Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepConfigurationV2Schedule input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for SweepConfigurationV2Schedule
    /// </summary>
    public class SweepConfigurationV2ScheduleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SweepConfigurationV2Schedule).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return SweepConfigurationV2Schedule.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
