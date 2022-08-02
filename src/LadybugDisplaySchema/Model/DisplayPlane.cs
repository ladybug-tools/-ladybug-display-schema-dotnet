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
    /// A plane object with display properties.
    /// </summary>
    [Serializable]
    [DataContract(Name = "DisplayPlane")]
    public partial class DisplayPlane : DisplayBaseModel, IEquatable<DisplayPlane>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayPlane" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisplayPlane() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayPlane";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayPlane" /> class.
        /// </summary>
        /// <param name="color">Color for the geometry. (required).</param>
        /// <param name="geometry">Plane for the geometry. (required).</param>
        /// <param name="showAxes">A boolean to note whether the plane should be displayed with XY axes instead of just an origin point and a normal vector. (default to false).</param>
        /// <param name="showGrid">A boolean to note whether the plane should be displayed with a grid. (default to false).</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public DisplayPlane
        (
           Color color, Plane geometry, // Required parameters
            Object userData= default, bool showAxes = false, bool showGrid = false// Optional parameters
        ) : base(userData: userData)// BaseClass
        {
            // to ensure "color" is required (not null)
            this.Color = color ?? throw new ArgumentNullException("color is a required property for DisplayPlane and cannot be null");
            // to ensure "geometry" is required (not null)
            this.Geometry = geometry ?? throw new ArgumentNullException("geometry is a required property for DisplayPlane and cannot be null");
            this.ShowAxes = showAxes;
            this.ShowGrid = showGrid;

            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayPlane";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DisplayPlane))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DisplayPlane";

        /// <summary>
        /// Color for the geometry.
        /// </summary>
        /// <value>Color for the geometry.</value>
        [DataMember(Name = "color", IsRequired = true)]
        public Color Color { get; set; } 
        /// <summary>
        /// Plane for the geometry.
        /// </summary>
        /// <value>Plane for the geometry.</value>
        [DataMember(Name = "geometry", IsRequired = true)]
        public Plane Geometry { get; set; } 
        /// <summary>
        /// A boolean to note whether the plane should be displayed with XY axes instead of just an origin point and a normal vector.
        /// </summary>
        /// <value>A boolean to note whether the plane should be displayed with XY axes instead of just an origin point and a normal vector.</value>
        [DataMember(Name = "show_axes")]
        public bool ShowAxes { get; set; }  = false;
        /// <summary>
        /// A boolean to note whether the plane should be displayed with a grid.
        /// </summary>
        /// <value>A boolean to note whether the plane should be displayed with a grid.</value>
        [DataMember(Name = "show_grid")]
        public bool ShowGrid { get; set; }  = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DisplayPlane";
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
            sb.Append("DisplayPlane:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  ShowAxes: ").Append(ShowAxes).Append("\n");
            sb.Append("  ShowGrid: ").Append(ShowGrid).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DisplayPlane object</returns>
        public static DisplayPlane FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DisplayPlane>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DisplayPlane object</returns>
        public virtual DisplayPlane DuplicateDisplayPlane()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDisplayPlane();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override DisplayBaseModel DuplicateDisplayBaseModel()
        {
            return DuplicateDisplayPlane();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DisplayPlane);
        }

        /// <summary>
        /// Returns true if DisplayPlane instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayPlane to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayPlane input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Color, input.Color) && 
                    Extension.Equals(this.Geometry, input.Geometry) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.ShowAxes, input.ShowAxes) && 
                    Extension.Equals(this.ShowGrid, input.ShowGrid);
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ShowAxes != null)
                    hashCode = hashCode * 59 + this.ShowAxes.GetHashCode();
                if (this.ShowGrid != null)
                    hashCode = hashCode * 59 + this.ShowGrid.GetHashCode();
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
            Regex regexType = new Regex(@"^DisplayPlane$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
