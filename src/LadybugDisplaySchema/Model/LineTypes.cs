/* 
 * Ladybug Visualization Schema
 *
 * Documentation for Ladybug visualization schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace LadybugDisplaySchema
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LineTypes
    {
        /// <summary>
        /// Enum Continuous for value: Continuous
        /// </summary>
        [EnumMember(Value = "Continuous")]
        Continuous = 1,

        /// <summary>
        /// Enum Dashed for value: Dashed
        /// </summary>
        [EnumMember(Value = "Dashed")]
        Dashed = 2,

        /// <summary>
        /// Enum Dotted for value: Dotted
        /// </summary>
        [EnumMember(Value = "Dotted")]
        Dotted = 3,

        /// <summary>
        /// Enum DashDot for value: DashDot
        /// </summary>
        [EnumMember(Value = "DashDot")]
        DashDot = 4

    }

}
