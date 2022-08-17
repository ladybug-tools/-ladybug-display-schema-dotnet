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
    /// A Polyface in 3D space.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Polyface3D")]
    public partial class Polyface3D : OpenAPIGenBaseModel, IEquatable<Polyface3D>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polyface3D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Polyface3D() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Polyface3D";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Polyface3D" /> class.
        /// </summary>
        /// <param name="vertices">A list of points representing the vertices of the polyface. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values. (required).</param>
        /// <param name="faceIndices">A list of lists with one list for each face of the polyface. Each face list must contain at least one sub-list of integers corresponding to indices within the vertices list. Additional sub-lists of integers may follow this one such that the first sub-list denotes the boundary of the face while each subsequent sub-list denotes a hole in the face. (required).</param>
        /// <param name="edgeInformation">Optional edge information, which will speed up the creation of the Polyface object if it is available but should be left as None if it is unknown. If None, edge_information will be computed from the vertices and face_indices inputs..</param>
        public Polyface3D
        (
           List<List<double>> vertices, List<List<List<int>>> faceIndices, // Required parameters
           PolyfaceEdgeInfo edgeInformation= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "vertices" is required (not null)
            this.Vertices = vertices ?? throw new ArgumentNullException("vertices is a required property for Polyface3D and cannot be null");
            // to ensure "faceIndices" is required (not null)
            this.FaceIndices = faceIndices ?? throw new ArgumentNullException("faceIndices is a required property for Polyface3D and cannot be null");
            this.EdgeInformation = edgeInformation;

            // Set non-required readonly properties with defaultValue
            this.Type = "Polyface3D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Polyface3D))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Polyface3D";

        /// <summary>
        /// A list of points representing the vertices of the polyface. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values.
        /// </summary>
        /// <value>A list of points representing the vertices of the polyface. The list should include at least 3 points and each point should be a list of 3 (x, y, z) values.</value>
        [DataMember(Name = "vertices", IsRequired = true)]
        public List<List<double>> Vertices { get; set; } 
        /// <summary>
        /// A list of lists with one list for each face of the polyface. Each face list must contain at least one sub-list of integers corresponding to indices within the vertices list. Additional sub-lists of integers may follow this one such that the first sub-list denotes the boundary of the face while each subsequent sub-list denotes a hole in the face.
        /// </summary>
        /// <value>A list of lists with one list for each face of the polyface. Each face list must contain at least one sub-list of integers corresponding to indices within the vertices list. Additional sub-lists of integers may follow this one such that the first sub-list denotes the boundary of the face while each subsequent sub-list denotes a hole in the face.</value>
        [DataMember(Name = "face_indices", IsRequired = true)]
        public List<List<List<int>>> FaceIndices { get; set; } 
        /// <summary>
        /// Optional edge information, which will speed up the creation of the Polyface object if it is available but should be left as None if it is unknown. If None, edge_information will be computed from the vertices and face_indices inputs.
        /// </summary>
        /// <value>Optional edge information, which will speed up the creation of the Polyface object if it is available but should be left as None if it is unknown. If None, edge_information will be computed from the vertices and face_indices inputs.</value>
        [DataMember(Name = "edge_information")]
        public PolyfaceEdgeInfo EdgeInformation { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Polyface3D";
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
            sb.Append("Polyface3D:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Vertices: ").Append(this.Vertices).Append("\n");
            sb.Append("  FaceIndices: ").Append(this.FaceIndices).Append("\n");
            sb.Append("  EdgeInformation: ").Append(this.EdgeInformation).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Polyface3D object</returns>
        public static Polyface3D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Polyface3D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Polyface3D object</returns>
        public virtual Polyface3D DuplicatePolyface3D()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePolyface3D();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicatePolyface3D();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Polyface3D);
        }

        /// <summary>
        /// Returns true if Polyface3D instances are equal
        /// </summary>
        /// <param name="input">Instance of Polyface3D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Polyface3D input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Vertices == input.Vertices ||
                    Extension.AllEquals(this.Vertices, input.Vertices)
                ) && 
                (
                    this.FaceIndices == input.FaceIndices ||
                    Extension.AllEquals(this.FaceIndices, input.FaceIndices)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.EdgeInformation, input.EdgeInformation);
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
                if (this.Vertices != null)
                    hashCode = hashCode * 59 + this.Vertices.GetHashCode();
                if (this.FaceIndices != null)
                    hashCode = hashCode * 59 + this.FaceIndices.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EdgeInformation != null)
                    hashCode = hashCode * 59 + this.EdgeInformation.GetHashCode();
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
            Regex regexType = new Regex(@"^Polyface3D$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
