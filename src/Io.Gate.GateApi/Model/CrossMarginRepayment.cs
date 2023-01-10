/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
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
using OpenAPIDateConverter = Io.Gate.GateApi.Client.OpenAPIDateConverter;

namespace Io.Gate.GateApi.Model
{
    /// <summary>
    /// CrossMarginRepayment
    /// </summary>
    [DataContract]
    public partial class CrossMarginRepayment :  IEquatable<CrossMarginRepayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossMarginRepayment" /> class.
        /// </summary>
        /// <param name="id">Loan record ID.</param>
        /// <param name="createTime">Repayment time.</param>
        /// <param name="loanId">Borrow loan ID.</param>
        /// <param name="currency">Currency name.</param>
        /// <param name="principal">Repaid principal.</param>
        /// <param name="interest">Repaid interest.</param>
        public CrossMarginRepayment(string id = default(string), long createTime = default(long), string loanId = default(string), string currency = default(string), string principal = default(string), string interest = default(string))
        {
            this.Id = id;
            this.CreateTime = createTime;
            this.LoanId = loanId;
            this.Currency = currency;
            this.Principal = principal;
            this.Interest = interest;
        }

        /// <summary>
        /// Loan record ID
        /// </summary>
        /// <value>Loan record ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Repayment time
        /// </summary>
        /// <value>Repayment time</value>
        [DataMember(Name="create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// Borrow loan ID
        /// </summary>
        /// <value>Borrow loan ID</value>
        [DataMember(Name="loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Repaid principal
        /// </summary>
        /// <value>Repaid principal</value>
        [DataMember(Name="principal")]
        public string Principal { get; set; }

        /// <summary>
        /// Repaid interest
        /// </summary>
        /// <value>Repaid interest</value>
        [DataMember(Name="interest")]
        public string Interest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossMarginRepayment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  LoanId: ").Append(LoanId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
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
            return this.Equals(input as CrossMarginRepayment);
        }

        /// <summary>
        /// Returns true if CrossMarginRepayment instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossMarginRepayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossMarginRepayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.LoanId == input.LoanId ||
                    (this.LoanId != null &&
                    this.LoanId.Equals(input.LoanId))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.Interest == input.Interest ||
                    (this.Interest != null &&
                    this.Interest.Equals(input.Interest))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LoanId != null)
                    hashCode = hashCode * 59 + this.LoanId.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.Interest != null)
                    hashCode = hashCode * 59 + this.Interest.GetHashCode();
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
