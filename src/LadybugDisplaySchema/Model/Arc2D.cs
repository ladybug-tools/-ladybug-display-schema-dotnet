/* 
 * Ladybug Display Schema
 *
 * Documentation for Ladybug display schema
 *
 * Contact: info@ladybug.tools
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


namespace LadybugDisplaySchema
{
    /// <summary>
    /// A single arc or circle in 2D space.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Arc2D")]
    public partial class Arc2D : OpenAPIGenBaseModel, IEquatable<Arc2D>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arc2D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Arc2D() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Arc2D";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Arc2D" /> class.
        /// </summary>
        /// <param name="c">Center of the arc as 2 (x, y) values. (required).</param>
        /// <param name="r">A number representing the radius of the arc. (required).</param>
        /// <param name="a1">A number between 0 and 2 * pi for the start angle of the arc. (default to 0D).</param>
        /// <param name="a2">A number between 0 and 2 * pi for the end angle of the arc. (default to 6.283185307179586D).</param>
        public Arc2D
        (
           List<double> c, double r, // Required parameters
           double a1 = 0D, double a2 = 6.283185307179586D// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "c" is required (not null)
            this.C = c ?? throw new ArgumentNullException("c is a required property for Arc2D and cannot be null");
            this.R = r;
            this.A1 = a1;
            this.A2 = a2;

            // Set non-required readonly properties with defaultValue
            this.Type = "Arc2D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Arc2D))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Arc2D";

        /// <summary>
        /// Center of the arc as 2 (x, y) values.
        /// </summary>
        /// <value>Center of the arc as 2 (x, y) values.</value>
        [DataMember(Name = "c", IsRequired = true)]
        public List<double> C { get; set; } 
        /// <summary>
        /// A number representing the radius of the arc.
        /// </summary>
        /// <value>A number representing the radius of the arc.</value>
        [DataMember(Name = "r", IsRequired = true)]
        public double R { get; set; } 
        /// <summary>
        /// A number between 0 and 2 * pi for the start angle of the arc.
        /// </summary>
        /// <value>A number between 0 and 2 * pi for the start angle of the arc.</value>
        [DataMember(Name = "a1")]
        public double A1 { get; set; }  = 0D;
        /// <summary>
        /// A number between 0 and 2 * pi for the end angle of the arc.
        /// </summary>
        /// <value>A number between 0 and 2 * pi for the end angle of the arc.</value>
        [DataMember(Name = "a2")]
        public double A2 { get; set; }  = 6.283185307179586D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Arc2D";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Arc2D:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  A1: ").Append(A1).Append("\n");
            sb.Append("  A2: ").Append(A2).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Arc2D object</returns>
        public static Arc2D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Arc2D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Arc2D object</returns>
        public virtual Arc2D DuplicateArc2D()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateArc2D();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateArc2D();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Arc2D);
        }

        /// <summary>
        /// Returns true if Arc2D instances are equal
        /// </summary>
        /// <param name="input">Instance of Arc2D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Arc2D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.C == input.C ||
                    Extension.AllEquals(this.C, input.C)
                ) && 
                (
                    Extension.Equals(this.R, input.R)
                ) && 
                (
                    Extension.Equals(this.Type, input.Type)
                ) && 
                (
                    Extension.Equals(this.A1, input.A1)
                ) && 
                (
                    Extension.Equals(this.A2, input.A2)
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
                int hashCode = base.GetHashCode();
                if (this.C != null)
                    hashCode = hashCode * 59 + this.C.GetHashCode();
                if (this.R != null)
                    hashCode = hashCode * 59 + this.R.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.A1 != null)
                    hashCode = hashCode * 59 + this.A1.GetHashCode();
                if (this.A2 != null)
                    hashCode = hashCode * 59 + this.A2.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Arc2D$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // A1 (double) maximum
            if(this.A1 > (double)6.283185307179586)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for A1, must be a value less than or equal to 6.283185307179586.", new [] { "A1" });
            }

            // A1 (double) minimum
            if(this.A1 < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for A1, must be a value greater than or equal to 0.", new [] { "A1" });
            }


            
            // A2 (double) maximum
            if(this.A2 > (double)6.283185307179586)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for A2, must be a value less than or equal to 6.283185307179586.", new [] { "A2" });
            }

            // A2 (double) minimum
            if(this.A2 < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for A2, must be a value greater than or equal to 0.", new [] { "A2" });
            }

            yield break;
        }
    }
}
