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
    /// A single line segment face in 2D space with display properties.
    /// </summary>
    [Serializable]
    [DataContract(Name = "DisplayLineSegment2D")]
    public partial class DisplayLineSegment2D : DisplayBaseModel, IEquatable<DisplayLineSegment2D>, IValidatableObject
    {
        /// <summary>
        /// Text to indicate the type of line to display (dashed, dotted, etc.). The LineTypes enumeration contains all acceptable types.
        /// </summary>
        /// <value>Text to indicate the type of line to display (dashed, dotted, etc.). The LineTypes enumeration contains all acceptable types.</value>
        [DataMember(Name="line_type")]
        public LineTypes LineType { get; set; } = LineTypes.Continuous;
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayLineSegment2D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisplayLineSegment2D() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayLineSegment2D";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayLineSegment2D" /> class.
        /// </summary>
        /// <param name="color">Color for the geometry. (required).</param>
        /// <param name="geometry">LineSegment2D for the geometry. (required).</param>
        /// <param name="lineWidth">Number for line width in pixels (for the screen) or millimeters (in print). Set to zero to hide the geometry..</param>
        /// <param name="lineType">Text to indicate the type of line to display (dashed, dotted, etc.). The LineTypes enumeration contains all acceptable types..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public DisplayLineSegment2D
        (
           Color color, LineSegment2D geometry, // Required parameters
            Object userData= default, AnyOf<Default,double> lineWidth= default, LineTypes lineType= LineTypes.Continuous// Optional parameters
        ) : base(userData: userData)// BaseClass
        {
            // to ensure "color" is required (not null)
            this.Color = color ?? throw new ArgumentNullException("color is a required property for DisplayLineSegment2D and cannot be null");
            // to ensure "geometry" is required (not null)
            this.Geometry = geometry ?? throw new ArgumentNullException("geometry is a required property for DisplayLineSegment2D and cannot be null");
            this.LineWidth = lineWidth;
            this.LineType = lineType;

            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayLineSegment2D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DisplayLineSegment2D))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DisplayLineSegment2D";

        /// <summary>
        /// Color for the geometry.
        /// </summary>
        /// <value>Color for the geometry.</value>
        [DataMember(Name = "color", IsRequired = true)]
        public Color Color { get; set; } 
        /// <summary>
        /// LineSegment2D for the geometry.
        /// </summary>
        /// <value>LineSegment2D for the geometry.</value>
        [DataMember(Name = "geometry", IsRequired = true)]
        public LineSegment2D Geometry { get; set; } 
        /// <summary>
        /// Number for line width in pixels (for the screen) or millimeters (in print). Set to zero to hide the geometry.
        /// </summary>
        /// <value>Number for line width in pixels (for the screen) or millimeters (in print). Set to zero to hide the geometry.</value>
        [DataMember(Name = "line_width")]
        public AnyOf<Default,double> LineWidth { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DisplayLineSegment2D";
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
            sb.Append("DisplayLineSegment2D:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DisplayLineSegment2D object</returns>
        public static DisplayLineSegment2D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DisplayLineSegment2D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DisplayLineSegment2D object</returns>
        public virtual DisplayLineSegment2D DuplicateDisplayLineSegment2D()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDisplayLineSegment2D();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override DisplayBaseModel DuplicateDisplayBaseModel()
        {
            return DuplicateDisplayLineSegment2D();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DisplayLineSegment2D);
        }

        /// <summary>
        /// Returns true if DisplayLineSegment2D instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayLineSegment2D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayLineSegment2D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Color, input.Color) && 
                    Extension.Equals(this.Geometry, input.Geometry) && 
                    Extension.Equals(this.LineWidth, input.LineWidth) && 
                    Extension.Equals(this.LineType, input.LineType) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.LineWidth != null)
                    hashCode = hashCode * 59 + this.LineWidth.GetHashCode();
                if (this.LineType != null)
                    hashCode = hashCode * 59 + this.LineType.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^DisplayLineSegment2D$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
