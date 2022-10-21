
# LadybugDisplaySchema.Model.LegendParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "LegendParameters"]
**Min** | [**AnyOfDefaultnumber**](AnyOfDefaultnumber.md) | A number to set the lower boundary of the legend. If Default, the minimum of the values associated with the legend will be used. | [optional] 
**Max** | [**AnyOfDefaultnumber**](AnyOfDefaultnumber.md) | A number to set the upper boundary of the legend. If Default, the maximum of the values associated with the legend will be used. | [optional] 
**SegmentCount** | [**AnyOfDefaultinteger**](AnyOfDefaultinteger.md) | An integer representing the number of steps between the high and low boundary of the legend. The default is set to 11 or it will be equal to the number of items in the ordinal_dictionary. Any custom values input in here should always be greater than or equal to 2. | [optional] 
**Colors** | [**List&lt;Color&gt;**](Color.md) | An list of color objects. Default is the Ladybug original colorset. | [optional] 
**Title** | **string** | Text string for Legend title. Typically, the units of the data are used here but the type of data might also be used. | [optional] [default to ""]
**ContinuousLegend** | **bool** | Boolean noting whether legend is drawn as a gradient or discrete segments. | [optional] [default to false]
**OrdinalDictionary** | **Object** | Optional dictionary that maps values to text categories. If None, numerical values will be used for the legend segments. If not, text categories will be used and the legend will be ordinal. Note that, if the number of items in the dictionary are less than the segment_count, some segments will not receive any label. Examples for possible dictionaries include: {-1: \&quot;Cold\&quot;, 0: \&quot;Neutral\&quot;, 1: \&quot;Hot\&quot;}, {0: \&quot;False\&quot;, 1: \&quot;True\&quot;} | [optional] 
**DecimalCount** | **int** | An an integer for the number of decimal places in the legend text. Note that this input has no bearing on the resulting legend text when an ordinal_dictionary is present. | [optional] [default to 2]
**IncludeLargerSmaller** | **bool** | Boolean noting whether &gt; and &lt; should be included in legend segment text. | [optional] [default to false]
**Vertical** | **bool** | Boolean noting whether legend is vertical (True) or horizontal (False). | [optional] [default to true]
**Font** | **string** | Text string to set the font for the legend text. Examples include \&quot;Arial\&quot;, \&quot;Times New Roman\&quot;, \&quot;Courier\&quot;. Note that this parameter may not have an effect on certain interfaces that have limited access to fonts. | [optional] [default to "Arial"]
**Properties3d** | [**Legend3DParameters**](Legend3DParameters.md) | A Legend3DParameters object to specify the dimensional properties of the legend when it is rendered in the 3D environment of the geometry scene. | [optional] 
**Properties2d** | [**Legend2DParameters**](Legend2DParameters.md) | A Legend2DParameters object to specify the dimensional properties of the legend when it is rendered in the 2D plane of a screen. | [optional] 
**UserData** | **Object** | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

