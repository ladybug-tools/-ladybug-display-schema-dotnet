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
    /// An object where multiple data streams correspond to the same geometry.
    /// </summary>
    [Serializable]
    [DataContract(Name = "AnalysisGeometry")]
    public partial class AnalysisGeometry : OpenAPIGenBaseModel, IEquatable<AnalysisGeometry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisGeometry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalysisGeometry() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "AnalysisGeometry";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisGeometry" /> class.
        /// </summary>
        /// <param name="geometry">A ladybug-geometry object or list of ladybug-geometry objects that is aligned with the values in the input data_sets. If a Mesh or Polyface is specified here, it is expected that the number of values match the number of faces or the number of vertices. If a list of geometry objects is specified (ie. a list of Point3Ds), it is expected that the length of this list align with the number of values. (required).</param>
        /// <param name="dataSets">An list of VisualizationData objects representing the data sets that are associated with the input geometry. (required).</param>
        /// <param name="activeData">An integer to denote which of the input data_sets should be displayed by default. (default to 0).</param>
        public AnalysisGeometry
        (
           List<AnyOf<IGeometry>> geometry, List<VisualizationData> dataSets, // Required parameters
           int activeData = 0// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "geometry" is required (not null)
            this.Geometry = geometry ?? throw new ArgumentNullException("geometry is a required property for AnalysisGeometry and cannot be null");

            // to ensure "dataSets" is required (not null)
            this.DataSets = dataSets ?? throw new ArgumentNullException("dataSets is a required property for AnalysisGeometry and cannot be null");
            this.ActiveData = activeData;

            // Set non-required readonly properties with defaultValue
            this.Type = "AnalysisGeometry";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(AnalysisGeometry))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "AnalysisGeometry";

        /// <summary>
        /// A ladybug-geometry object or list of ladybug-geometry objects that is aligned with the values in the input data_sets. If a Mesh or Polyface is specified here, it is expected that the number of values match the number of faces or the number of vertices. If a list of geometry objects is specified (ie. a list of Point3Ds), it is expected that the length of this list align with the number of values.
        /// </summary>
        /// <value>A ladybug-geometry object or list of ladybug-geometry objects that is aligned with the values in the input data_sets. If a Mesh or Polyface is specified here, it is expected that the number of values match the number of faces or the number of vertices. If a list of geometry objects is specified (ie. a list of Point3Ds), it is expected that the length of this list align with the number of values.</value>
        [DataMember(Name = "geometry", IsRequired = true)]
        public List<AnyOf<IGeometry>> Geometry { get; set; } 
        /// <summary>
        /// An list of VisualizationData objects representing the data sets that are associated with the input geometry.
        /// </summary>
        /// <value>An list of VisualizationData objects representing the data sets that are associated with the input geometry.</value>
        [DataMember(Name = "data_sets", IsRequired = true)]
        public List<VisualizationData> DataSets { get; set; } 
        /// <summary>
        /// An integer to denote which of the input data_sets should be displayed by default.
        /// </summary>
        /// <value>An integer to denote which of the input data_sets should be displayed by default.</value>
        [DataMember(Name = "active_data")]
        public int ActiveData { get; set; }  = 0;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "AnalysisGeometry";
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
            sb.Append("AnalysisGeometry:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Geometry: ").Append(this.Geometry).Append("\n");
            sb.Append("  DataSets: ").Append(this.DataSets).Append("\n");
            sb.Append("  ActiveData: ").Append(this.ActiveData).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>AnalysisGeometry object</returns>
        public static AnalysisGeometry FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<AnalysisGeometry>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>AnalysisGeometry object</returns>
        public virtual AnalysisGeometry DuplicateAnalysisGeometry()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateAnalysisGeometry();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateAnalysisGeometry();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as AnalysisGeometry);
        }

        /// <summary>
        /// Returns true if AnalysisGeometry instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalysisGeometry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisGeometry input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Geometry, input.Geometry) && 
                (
                    this.DataSets == input.DataSets ||
                    Extension.AllEquals(this.DataSets, input.DataSets)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.ActiveData, input.ActiveData);
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.DataSets != null)
                    hashCode = hashCode * 59 + this.DataSets.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ActiveData != null)
                    hashCode = hashCode * 59 + this.ActiveData.GetHashCode();
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
            Regex regexType = new Regex(@"^AnalysisGeometry$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
