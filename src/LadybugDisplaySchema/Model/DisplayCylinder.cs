/* 
 * Ladybug Visualization Schema
 *
 * Documentation for Ladybug visualization schema
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
    /// A cylinder object with display properties.
    /// </summary>
    [Serializable]
    [DataContract(Name = "DisplayCylinder")]
    public partial class DisplayCylinder : DisplayBaseModel, IEquatable<DisplayCylinder>, IValidatableObject
    {
        /// <summary>
        /// Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types.
        /// </summary>
        /// <value>Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types.</value>
        [DataMember(Name="display_mode")]
        public DisplayModes DisplayMode { get; set; } = DisplayModes.Shaded;
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayCylinder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisplayCylinder() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayCylinder";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayCylinder" /> class.
        /// </summary>
        /// <param name="color">Color for the geometry. (required).</param>
        /// <param name="geometry">Cylinder for the geometry. (required).</param>
        /// <param name="displayMode">Text to indicate the display mode (shaded, wireframe, etc.). The DisplayModes enumeration contains all acceptable types..</param>
        /// <param name="layer">Optional text for the layer on which the geometry exists. Sub-layers should be separated from parent layers by means of a :: and platforms that support sub-layers will interpret the layer as such..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public DisplayCylinder
        (
           Color color, Cylinder geometry, // Required parameters
            string layer= default, Object userData= default, DisplayModes displayMode= DisplayModes.Shaded// Optional parameters
        ) : base(layer: layer, userData: userData )// BaseClass
        {
            // to ensure "color" is required (not null)
            this.Color = color ?? throw new ArgumentNullException("color is a required property for DisplayCylinder and cannot be null");
            // to ensure "geometry" is required (not null)
            this.Geometry = geometry ?? throw new ArgumentNullException("geometry is a required property for DisplayCylinder and cannot be null");
            this.DisplayMode = displayMode;

            // Set non-required readonly properties with defaultValue
            this.Type = "DisplayCylinder";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DisplayCylinder))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DisplayCylinder";

        /// <summary>
        /// Color for the geometry.
        /// </summary>
        /// <value>Color for the geometry.</value>
        [DataMember(Name = "color", IsRequired = true)]
        public Color Color { get; set; } 
        /// <summary>
        /// Cylinder for the geometry.
        /// </summary>
        /// <value>Cylinder for the geometry.</value>
        [DataMember(Name = "geometry", IsRequired = true)]
        public Cylinder Geometry { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DisplayCylinder";
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
            sb.Append("DisplayCylinder:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Layer: ").Append(this.Layer).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  Geometry: ").Append(this.Geometry).Append("\n");
            sb.Append("  DisplayMode: ").Append(this.DisplayMode).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DisplayCylinder object</returns>
        public static DisplayCylinder FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DisplayCylinder>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DisplayCylinder object</returns>
        public virtual DisplayCylinder DuplicateDisplayCylinder()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDisplayCylinder();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override DisplayBaseModel DuplicateDisplayBaseModel()
        {
            return DuplicateDisplayCylinder();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DisplayCylinder);
        }

        /// <summary>
        /// Returns true if DisplayCylinder instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayCylinder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayCylinder input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Color, input.Color) && 
                    Extension.Equals(this.Geometry, input.Geometry) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.DisplayMode, input.DisplayMode);
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
                if (this.DisplayMode != null)
                    hashCode = hashCode * 59 + this.DisplayMode.GetHashCode();
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
            Regex regexType = new Regex(@"^DisplayCylinder$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
