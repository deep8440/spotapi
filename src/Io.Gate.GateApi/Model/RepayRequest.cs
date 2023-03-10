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
    /// RepayRequest
    /// </summary>
    [DataContract]
    public partial class RepayRequest :  IEquatable<RepayRequest>, IValidatableObject
    {
        /// <summary>
        /// Repay mode. all - repay all; partial - repay only some portion
        /// </summary>
        /// <value>Repay mode. all - repay all; partial - repay only some portion</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum Partial for value: partial
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial = 2

        }

        /// <summary>
        /// Repay mode. all - repay all; partial - repay only some portion
        /// </summary>
        /// <value>Repay mode. all - repay all; partial - repay only some portion</value>
        [DataMember(Name="mode")]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepayRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepayRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepayRequest" /> class.
        /// </summary>
        /// <param name="currencyPair">Currency pair (required).</param>
        /// <param name="currency">Loan currency (required).</param>
        /// <param name="mode">Repay mode. all - repay all; partial - repay only some portion (required).</param>
        /// <param name="amount">Repay amount. Required in &#x60;partial&#x60; mode.</param>
        public RepayRequest(string currencyPair = default(string), string currency = default(string), ModeEnum mode = default(ModeEnum), string amount = default(string))
        {
            // to ensure "currencyPair" is required (not null)
            this.CurrencyPair = currencyPair ?? throw new ArgumentNullException("currencyPair", "currencyPair is a required property for RepayRequest and cannot be null");
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for RepayRequest and cannot be null");
            this.Mode = mode;
            this.Amount = amount;
        }

        /// <summary>
        /// Currency pair
        /// </summary>
        /// <value>Currency pair</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Loan currency
        /// </summary>
        /// <value>Loan currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Repay amount. Required in &#x60;partial&#x60; mode
        /// </summary>
        /// <value>Repay amount. Required in &#x60;partial&#x60; mode</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepayRequest {\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as RepayRequest);
        }

        /// <summary>
        /// Returns true if RepayRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RepayRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepayRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
