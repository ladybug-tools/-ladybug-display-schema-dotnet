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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DataTypes
    {
        /// <summary>
        /// Enum ActivityLevel for value: ActivityLevel
        /// </summary>
        [EnumMember(Value = "ActivityLevel")]
        ActivityLevel = 1,

        /// <summary>
        /// Enum AerosolOpticalDepth for value: AerosolOpticalDepth
        /// </summary>
        [EnumMember(Value = "AerosolOpticalDepth")]
        AerosolOpticalDepth = 2,

        /// <summary>
        /// Enum AirSpeed for value: AirSpeed
        /// </summary>
        [EnumMember(Value = "AirSpeed")]
        AirSpeed = 3,

        /// <summary>
        /// Enum AirTemperature for value: AirTemperature
        /// </summary>
        [EnumMember(Value = "AirTemperature")]
        AirTemperature = 4,

        /// <summary>
        /// Enum AirTemperatureDelta for value: AirTemperatureDelta
        /// </summary>
        [EnumMember(Value = "AirTemperatureDelta")]
        AirTemperatureDelta = 5,

        /// <summary>
        /// Enum Albedo for value: Albedo
        /// </summary>
        [EnumMember(Value = "Albedo")]
        Albedo = 6,

        /// <summary>
        /// Enum Angle for value: Angle
        /// </summary>
        [EnumMember(Value = "Angle")]
        Angle = 7,

        /// <summary>
        /// Enum Area for value: Area
        /// </summary>
        [EnumMember(Value = "Area")]
        Area = 8,

        /// <summary>
        /// Enum AtmosphericStationPressure for value: AtmosphericStationPressure
        /// </summary>
        [EnumMember(Value = "AtmosphericStationPressure")]
        AtmosphericStationPressure = 9,

        /// <summary>
        /// Enum CeilingHeight for value: CeilingHeight
        /// </summary>
        [EnumMember(Value = "CeilingHeight")]
        CeilingHeight = 10,

        /// <summary>
        /// Enum ClothingInsulation for value: ClothingInsulation
        /// </summary>
        [EnumMember(Value = "ClothingInsulation")]
        ClothingInsulation = 11,

        /// <summary>
        /// Enum ConvectionCoefficient for value: ConvectionCoefficient
        /// </summary>
        [EnumMember(Value = "ConvectionCoefficient")]
        ConvectionCoefficient = 12,

        /// <summary>
        /// Enum CoolingDegreeTime for value: CoolingDegreeTime
        /// </summary>
        [EnumMember(Value = "CoolingDegreeTime")]
        CoolingDegreeTime = 13,

        /// <summary>
        /// Enum Current for value: Current
        /// </summary>
        [EnumMember(Value = "Current")]
        Current = 14,

        /// <summary>
        /// Enum DewPointTemperature for value: DewPointTemperature
        /// </summary>
        [EnumMember(Value = "DewPointTemperature")]
        DewPointTemperature = 15,

        /// <summary>
        /// Enum DiffuseHorizontalIlluminance for value: DiffuseHorizontalIlluminance
        /// </summary>
        [EnumMember(Value = "DiffuseHorizontalIlluminance")]
        DiffuseHorizontalIlluminance = 16,

        /// <summary>
        /// Enum DiffuseHorizontalIrradiance for value: DiffuseHorizontalIrradiance
        /// </summary>
        [EnumMember(Value = "DiffuseHorizontalIrradiance")]
        DiffuseHorizontalIrradiance = 17,

        /// <summary>
        /// Enum DiffuseHorizontalRadiation for value: DiffuseHorizontalRadiation
        /// </summary>
        [EnumMember(Value = "DiffuseHorizontalRadiation")]
        DiffuseHorizontalRadiation = 18,

        /// <summary>
        /// Enum DirectHorizontalIrradiance for value: DirectHorizontalIrradiance
        /// </summary>
        [EnumMember(Value = "DirectHorizontalIrradiance")]
        DirectHorizontalIrradiance = 19,

        /// <summary>
        /// Enum DirectHorizontalRadiation for value: DirectHorizontalRadiation
        /// </summary>
        [EnumMember(Value = "DirectHorizontalRadiation")]
        DirectHorizontalRadiation = 20,

        /// <summary>
        /// Enum DirectNormalIlluminance for value: DirectNormalIlluminance
        /// </summary>
        [EnumMember(Value = "DirectNormalIlluminance")]
        DirectNormalIlluminance = 21,

        /// <summary>
        /// Enum DirectNormalIrradiance for value: DirectNormalIrradiance
        /// </summary>
        [EnumMember(Value = "DirectNormalIrradiance")]
        DirectNormalIrradiance = 22,

        /// <summary>
        /// Enum DirectNormalRadiation for value: DirectNormalRadiation
        /// </summary>
        [EnumMember(Value = "DirectNormalRadiation")]
        DirectNormalRadiation = 23,

        /// <summary>
        /// Enum DiscomfortReason for value: DiscomfortReason
        /// </summary>
        [EnumMember(Value = "DiscomfortReason")]
        DiscomfortReason = 24,

        /// <summary>
        /// Enum Distance for value: Distance
        /// </summary>
        [EnumMember(Value = "Distance")]
        Distance = 25,

        /// <summary>
        /// Enum DryBulbTemperature for value: DryBulbTemperature
        /// </summary>
        [EnumMember(Value = "DryBulbTemperature")]
        DryBulbTemperature = 26,

        /// <summary>
        /// Enum EffectiveRadiantField for value: EffectiveRadiantField
        /// </summary>
        [EnumMember(Value = "EffectiveRadiantField")]
        EffectiveRadiantField = 27,

        /// <summary>
        /// Enum Energy for value: Energy
        /// </summary>
        [EnumMember(Value = "Energy")]
        Energy = 28,

        /// <summary>
        /// Enum EnergyFlux for value: EnergyFlux
        /// </summary>
        [EnumMember(Value = "EnergyFlux")]
        EnergyFlux = 29,

        /// <summary>
        /// Enum EnergyIntensity for value: EnergyIntensity
        /// </summary>
        [EnumMember(Value = "EnergyIntensity")]
        EnergyIntensity = 30,

        /// <summary>
        /// Enum Enthalpy for value: Enthalpy
        /// </summary>
        [EnumMember(Value = "Enthalpy")]
        Enthalpy = 31,

        /// <summary>
        /// Enum ExtraterrestrialDirectNormalRadiation for value: ExtraterrestrialDirectNormalRadiation
        /// </summary>
        [EnumMember(Value = "ExtraterrestrialDirectNormalRadiation")]
        ExtraterrestrialDirectNormalRadiation = 32,

        /// <summary>
        /// Enum ExtraterrestrialHorizontalRadiation for value: ExtraterrestrialHorizontalRadiation
        /// </summary>
        [EnumMember(Value = "ExtraterrestrialHorizontalRadiation")]
        ExtraterrestrialHorizontalRadiation = 33,

        /// <summary>
        /// Enum Fraction for value: Fraction
        /// </summary>
        [EnumMember(Value = "Fraction")]
        Fraction = 34,

        /// <summary>
        /// Enum GlobalHorizontalIlluminance for value: GlobalHorizontalIlluminance
        /// </summary>
        [EnumMember(Value = "GlobalHorizontalIlluminance")]
        GlobalHorizontalIlluminance = 35,

        /// <summary>
        /// Enum GlobalHorizontalIrradiance for value: GlobalHorizontalIrradiance
        /// </summary>
        [EnumMember(Value = "GlobalHorizontalIrradiance")]
        GlobalHorizontalIrradiance = 36,

        /// <summary>
        /// Enum GlobalHorizontalRadiation for value: GlobalHorizontalRadiation
        /// </summary>
        [EnumMember(Value = "GlobalHorizontalRadiation")]
        GlobalHorizontalRadiation = 37,

        /// <summary>
        /// Enum GroundTemperature for value: GroundTemperature
        /// </summary>
        [EnumMember(Value = "GroundTemperature")]
        GroundTemperature = 38,

        /// <summary>
        /// Enum HeatingDegreeTime for value: HeatingDegreeTime
        /// </summary>
        [EnumMember(Value = "HeatingDegreeTime")]
        HeatingDegreeTime = 39,

        /// <summary>
        /// Enum HorizontalInfraredRadiationIntensity for value: HorizontalInfraredRadiationIntensity
        /// </summary>
        [EnumMember(Value = "HorizontalInfraredRadiationIntensity")]
        HorizontalInfraredRadiationIntensity = 40,

        /// <summary>
        /// Enum HumidityRatio for value: HumidityRatio
        /// </summary>
        [EnumMember(Value = "HumidityRatio")]
        HumidityRatio = 41,

        /// <summary>
        /// Enum Illuminance for value: Illuminance
        /// </summary>
        [EnumMember(Value = "Illuminance")]
        Illuminance = 42,

        /// <summary>
        /// Enum Irradiance for value: Irradiance
        /// </summary>
        [EnumMember(Value = "Irradiance")]
        Irradiance = 43,

        /// <summary>
        /// Enum LiquidPrecipitationDepth for value: LiquidPrecipitationDepth
        /// </summary>
        [EnumMember(Value = "LiquidPrecipitationDepth")]
        LiquidPrecipitationDepth = 44,

        /// <summary>
        /// Enum LiquidPrecipitationQuantity for value: LiquidPrecipitationQuantity
        /// </summary>
        [EnumMember(Value = "LiquidPrecipitationQuantity")]
        LiquidPrecipitationQuantity = 45,

        /// <summary>
        /// Enum Luminance for value: Luminance
        /// </summary>
        [EnumMember(Value = "Luminance")]
        Luminance = 46,

        /// <summary>
        /// Enum Mass for value: Mass
        /// </summary>
        [EnumMember(Value = "Mass")]
        Mass = 47,

        /// <summary>
        /// Enum MassFlowRate for value: MassFlowRate
        /// </summary>
        [EnumMember(Value = "MassFlowRate")]
        MassFlowRate = 48,

        /// <summary>
        /// Enum MeanRadiantTemperature for value: MeanRadiantTemperature
        /// </summary>
        [EnumMember(Value = "MeanRadiantTemperature")]
        MeanRadiantTemperature = 49,

        /// <summary>
        /// Enum MetabolicRate for value: MetabolicRate
        /// </summary>
        [EnumMember(Value = "MetabolicRate")]
        MetabolicRate = 50,

        /// <summary>
        /// Enum OpaqueSkyCover for value: OpaqueSkyCover
        /// </summary>
        [EnumMember(Value = "OpaqueSkyCover")]
        OpaqueSkyCover = 51,

        /// <summary>
        /// Enum OperativeTemperature for value: OperativeTemperature
        /// </summary>
        [EnumMember(Value = "OperativeTemperature")]
        OperativeTemperature = 52,

        /// <summary>
        /// Enum OperativeTemperatureDelta for value: OperativeTemperatureDelta
        /// </summary>
        [EnumMember(Value = "OperativeTemperatureDelta")]
        OperativeTemperatureDelta = 53,

        /// <summary>
        /// Enum PercentagePeopleDissatisfied for value: PercentagePeopleDissatisfied
        /// </summary>
        [EnumMember(Value = "PercentagePeopleDissatisfied")]
        PercentagePeopleDissatisfied = 54,

        /// <summary>
        /// Enum Power for value: Power
        /// </summary>
        [EnumMember(Value = "Power")]
        Power = 55,

        /// <summary>
        /// Enum PrecipitableWater for value: PrecipitableWater
        /// </summary>
        [EnumMember(Value = "PrecipitableWater")]
        PrecipitableWater = 56,

        /// <summary>
        /// Enum PredictedMeanVote for value: PredictedMeanVote
        /// </summary>
        [EnumMember(Value = "PredictedMeanVote")]
        PredictedMeanVote = 57,

        /// <summary>
        /// Enum Pressure for value: Pressure
        /// </summary>
        [EnumMember(Value = "Pressure")]
        Pressure = 58,

        /// <summary>
        /// Enum PrevailingOutdoorTemperature for value: PrevailingOutdoorTemperature
        /// </summary>
        [EnumMember(Value = "PrevailingOutdoorTemperature")]
        PrevailingOutdoorTemperature = 59,

        /// <summary>
        /// Enum RValue for value: RValue
        /// </summary>
        [EnumMember(Value = "RValue")]
        RValue = 60,

        /// <summary>
        /// Enum RadiantCoefficient for value: RadiantCoefficient
        /// </summary>
        [EnumMember(Value = "RadiantCoefficient")]
        RadiantCoefficient = 61,

        /// <summary>
        /// Enum RadiantTemperature for value: RadiantTemperature
        /// </summary>
        [EnumMember(Value = "RadiantTemperature")]
        RadiantTemperature = 62,

        /// <summary>
        /// Enum RadiantTemperatureDelta for value: RadiantTemperatureDelta
        /// </summary>
        [EnumMember(Value = "RadiantTemperatureDelta")]
        RadiantTemperatureDelta = 63,

        /// <summary>
        /// Enum Radiation for value: Radiation
        /// </summary>
        [EnumMember(Value = "Radiation")]
        Radiation = 64,

        /// <summary>
        /// Enum RelativeHumidity for value: RelativeHumidity
        /// </summary>
        [EnumMember(Value = "RelativeHumidity")]
        RelativeHumidity = 65,

        /// <summary>
        /// Enum SkyTemperature for value: SkyTemperature
        /// </summary>
        [EnumMember(Value = "SkyTemperature")]
        SkyTemperature = 66,

        /// <summary>
        /// Enum SnowDepth for value: SnowDepth
        /// </summary>
        [EnumMember(Value = "SnowDepth")]
        SnowDepth = 67,

        /// <summary>
        /// Enum SpecificEnergy for value: SpecificEnergy
        /// </summary>
        [EnumMember(Value = "SpecificEnergy")]
        SpecificEnergy = 68,

        /// <summary>
        /// Enum Speed for value: Speed
        /// </summary>
        [EnumMember(Value = "Speed")]
        Speed = 69,

        /// <summary>
        /// Enum StandardEffectiveTemperature for value: StandardEffectiveTemperature
        /// </summary>
        [EnumMember(Value = "StandardEffectiveTemperature")]
        StandardEffectiveTemperature = 70,

        /// <summary>
        /// Enum Temperature for value: Temperature
        /// </summary>
        [EnumMember(Value = "Temperature")]
        Temperature = 71,

        /// <summary>
        /// Enum TemperatureDelta for value: TemperatureDelta
        /// </summary>
        [EnumMember(Value = "TemperatureDelta")]
        TemperatureDelta = 72,

        /// <summary>
        /// Enum TemperatureTime for value: TemperatureTime
        /// </summary>
        [EnumMember(Value = "TemperatureTime")]
        TemperatureTime = 73,

        /// <summary>
        /// Enum ThermalComfort for value: ThermalComfort
        /// </summary>
        [EnumMember(Value = "ThermalComfort")]
        ThermalComfort = 74,

        /// <summary>
        /// Enum ThermalCondition for value: ThermalCondition
        /// </summary>
        [EnumMember(Value = "ThermalCondition")]
        ThermalCondition = 75,

        /// <summary>
        /// Enum ThermalConditionElevenPoint for value: ThermalConditionElevenPoint
        /// </summary>
        [EnumMember(Value = "ThermalConditionElevenPoint")]
        ThermalConditionElevenPoint = 76,

        /// <summary>
        /// Enum ThermalConditionFivePoint for value: ThermalConditionFivePoint
        /// </summary>
        [EnumMember(Value = "ThermalConditionFivePoint")]
        ThermalConditionFivePoint = 77,

        /// <summary>
        /// Enum ThermalConditionNinePoint for value: ThermalConditionNinePoint
        /// </summary>
        [EnumMember(Value = "ThermalConditionNinePoint")]
        ThermalConditionNinePoint = 78,

        /// <summary>
        /// Enum ThermalConditionSevenPoint for value: ThermalConditionSevenPoint
        /// </summary>
        [EnumMember(Value = "ThermalConditionSevenPoint")]
        ThermalConditionSevenPoint = 79,

        /// <summary>
        /// Enum Time for value: Time
        /// </summary>
        [EnumMember(Value = "Time")]
        Time = 80,

        /// <summary>
        /// Enum TotalSkyCover for value: TotalSkyCover
        /// </summary>
        [EnumMember(Value = "TotalSkyCover")]
        TotalSkyCover = 81,

        /// <summary>
        /// Enum UTCICategory for value: UTCICategory
        /// </summary>
        [EnumMember(Value = "UTCICategory")]
        UTCICategory = 82,

        /// <summary>
        /// Enum UValue for value: UValue
        /// </summary>
        [EnumMember(Value = "UValue")]
        UValue = 83,

        /// <summary>
        /// Enum UniversalThermalClimateIndex for value: UniversalThermalClimateIndex
        /// </summary>
        [EnumMember(Value = "UniversalThermalClimateIndex")]
        UniversalThermalClimateIndex = 84,

        /// <summary>
        /// Enum Visibility for value: Visibility
        /// </summary>
        [EnumMember(Value = "Visibility")]
        Visibility = 85,

        /// <summary>
        /// Enum Voltage for value: Voltage
        /// </summary>
        [EnumMember(Value = "Voltage")]
        Voltage = 86,

        /// <summary>
        /// Enum Volume for value: Volume
        /// </summary>
        [EnumMember(Value = "Volume")]
        Volume = 87,

        /// <summary>
        /// Enum VolumeFlowRate for value: VolumeFlowRate
        /// </summary>
        [EnumMember(Value = "VolumeFlowRate")]
        VolumeFlowRate = 88,

        /// <summary>
        /// Enum VolumeFlowRateIntensity for value: VolumeFlowRateIntensity
        /// </summary>
        [EnumMember(Value = "VolumeFlowRateIntensity")]
        VolumeFlowRateIntensity = 89,

        /// <summary>
        /// Enum WetBulbTemperature for value: WetBulbTemperature
        /// </summary>
        [EnumMember(Value = "WetBulbTemperature")]
        WetBulbTemperature = 90,

        /// <summary>
        /// Enum WindDirection for value: WindDirection
        /// </summary>
        [EnumMember(Value = "WindDirection")]
        WindDirection = 91,

        /// <summary>
        /// Enum WindSpeed for value: WindSpeed
        /// </summary>
        [EnumMember(Value = "WindSpeed")]
        WindSpeed = 92,

        /// <summary>
        /// Enum ZenithLuminance for value: ZenithLuminance
        /// </summary>
        [EnumMember(Value = "ZenithLuminance")]
        ZenithLuminance = 93

    }

}
