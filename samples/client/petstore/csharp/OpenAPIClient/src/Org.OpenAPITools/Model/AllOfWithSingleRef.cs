/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AllOfWithSingleRef
    /// </summary>
    [DataContract]
    public partial class AllOfWithSingleRef :  IEquatable<AllOfWithSingleRef>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SingleRefType
        /// </summary>
        [DataMember(Name="SingleRefType", EmitDefaultValue=true)]
        public SingleRefType? SingleRefType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfWithSingleRef" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="singleRefType">singleRefType.</param>
        public AllOfWithSingleRef(string username = default(string), SingleRefType? singleRefType = default(SingleRefType?))
        {
            this.SingleRefType = singleRefType;
            this.Username = username;
            this.SingleRefType = singleRefType;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfWithSingleRef {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  SingleRefType: ").Append(SingleRefType).Append("\n");
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
            return this.Equals(input as AllOfWithSingleRef);
        }

        /// <summary>
        /// Returns true if AllOfWithSingleRef instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfWithSingleRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfWithSingleRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.SingleRefType == input.SingleRefType ||
                    (this.SingleRefType != null &&
                    this.SingleRefType.Equals(input.SingleRefType))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.SingleRefType != null)
                    hashCode = hashCode * 59 + this.SingleRefType.GetHashCode();
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
