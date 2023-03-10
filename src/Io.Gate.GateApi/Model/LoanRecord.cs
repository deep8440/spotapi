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
    /// Margin loaned record details
    /// </summary>
    [DataContract]
    public partial class LoanRecord :  IEquatable<LoanRecord>, IValidatableObject
    {
        /// <summary>
        /// Loan record status
        /// </summary>
        /// <value>Loan record status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Loaned for value: loaned
            /// </summary>
            [EnumMember(Value = "loaned")]
            Loaned = 1,

            /// <summary>
            /// Enum Finished for value: finished
            /// </summary>
            [EnumMember(Value = "finished")]
            Finished = 2

        }

        /// <summary>
        /// Loan record status
        /// </summary>
        /// <value>Loan record status</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanRecord" /> class.
        /// </summary>
        /// <param name="id">Loan record ID.</param>
        /// <param name="loanId">Loan ID the record belongs to.</param>
        /// <param name="createTime">Loan time.</param>
        /// <param name="expireTime">Expiration time.</param>
        /// <param name="status">Loan record status.</param>
        /// <param name="borrowUserId">Garbled user ID.</param>
        /// <param name="currency">Loan currency.</param>
        /// <param name="rate">Loan rate.</param>
        /// <param name="amount">Loan amount.</param>
        /// <param name="days">Loan days.</param>
        /// <param name="autoRenew">Whether the record will auto renew on expiration (default to false).</param>
        /// <param name="repaid">Repaid amount.</param>
        public LoanRecord(string id = default(string), string loanId = default(string), string createTime = default(string), string expireTime = default(string), StatusEnum? status = default(StatusEnum?), string borrowUserId = default(string), string currency = default(string), string rate = default(string), string amount = default(string), int days = default(int), bool autoRenew = false, string repaid = default(string))
        {
            this.Id = id;
            this.LoanId = loanId;
            this.CreateTime = createTime;
            this.ExpireTime = expireTime;
            this.Status = status;
            this.BorrowUserId = borrowUserId;
            this.Currency = currency;
            this.Rate = rate;
            this.Amount = amount;
            this.Days = days;
            this.AutoRenew = autoRenew;
            this.Repaid = repaid;
        }

        /// <summary>
        /// Loan record ID
        /// </summary>
        /// <value>Loan record ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Loan ID the record belongs to
        /// </summary>
        /// <value>Loan ID the record belongs to</value>
        [DataMember(Name="loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// Loan time
        /// </summary>
        /// <value>Loan time</value>
        [DataMember(Name="create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        /// <value>Expiration time</value>
        [DataMember(Name="expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// Garbled user ID
        /// </summary>
        /// <value>Garbled user ID</value>
        [DataMember(Name="borrow_user_id")]
        public string BorrowUserId { get; set; }

        /// <summary>
        /// Loan currency
        /// </summary>
        /// <value>Loan currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Loan rate
        /// </summary>
        /// <value>Loan rate</value>
        [DataMember(Name="rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Loan amount
        /// </summary>
        /// <value>Loan amount</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Loan days
        /// </summary>
        /// <value>Loan days</value>
        [DataMember(Name="days")]
        public int Days { get; set; }

        /// <summary>
        /// Whether the record will auto renew on expiration
        /// </summary>
        /// <value>Whether the record will auto renew on expiration</value>
        [DataMember(Name="auto_renew")]
        public bool AutoRenew { get; set; }

        /// <summary>
        /// Repaid amount
        /// </summary>
        /// <value>Repaid amount</value>
        [DataMember(Name="repaid")]
        public string Repaid { get; set; }

        /// <summary>
        /// Repaid interest
        /// </summary>
        /// <value>Repaid interest</value>
        [DataMember(Name="paid_interest", EmitDefaultValue=false)]
        public string PaidInterest { get; private set; }

        /// <summary>
        /// Outstanding interest yet to be paid
        /// </summary>
        /// <value>Outstanding interest yet to be paid</value>
        [DataMember(Name="unpaid_interest", EmitDefaultValue=false)]
        public string UnpaidInterest { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanRecord {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoanId: ").Append(LoanId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BorrowUserId: ").Append(BorrowUserId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  Repaid: ").Append(Repaid).Append("\n");
            sb.Append("  PaidInterest: ").Append(PaidInterest).Append("\n");
            sb.Append("  UnpaidInterest: ").Append(UnpaidInterest).Append("\n");
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
            return this.Equals(input as LoanRecord);
        }

        /// <summary>
        /// Returns true if LoanRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanRecord input)
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
                    this.LoanId == input.LoanId ||
                    (this.LoanId != null &&
                    this.LoanId.Equals(input.LoanId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.BorrowUserId == input.BorrowUserId ||
                    (this.BorrowUserId != null &&
                    this.BorrowUserId.Equals(input.BorrowUserId))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days.Equals(input.Days)
                ) && 
                (
                    this.AutoRenew == input.AutoRenew ||
                    this.AutoRenew.Equals(input.AutoRenew)
                ) && 
                (
                    this.Repaid == input.Repaid ||
                    (this.Repaid != null &&
                    this.Repaid.Equals(input.Repaid))
                ) && 
                (
                    this.PaidInterest == input.PaidInterest ||
                    (this.PaidInterest != null &&
                    this.PaidInterest.Equals(input.PaidInterest))
                ) && 
                (
                    this.UnpaidInterest == input.UnpaidInterest ||
                    (this.UnpaidInterest != null &&
                    this.UnpaidInterest.Equals(input.UnpaidInterest))
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
                if (this.LoanId != null)
                    hashCode = hashCode * 59 + this.LoanId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ExpireTime != null)
                    hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BorrowUserId != null)
                    hashCode = hashCode * 59 + this.BorrowUserId.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Days.GetHashCode();
                hashCode = hashCode * 59 + this.AutoRenew.GetHashCode();
                if (this.Repaid != null)
                    hashCode = hashCode * 59 + this.Repaid.GetHashCode();
                if (this.PaidInterest != null)
                    hashCode = hashCode * 59 + this.PaidInterest.GetHashCode();
                if (this.UnpaidInterest != null)
                    hashCode = hashCode * 59 + this.UnpaidInterest.GetHashCode();
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
