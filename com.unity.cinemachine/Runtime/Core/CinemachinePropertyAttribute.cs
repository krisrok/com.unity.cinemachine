using UnityEngine;

namespace Cinemachine
{
    /// <summary>
    /// Property applied to AxisState.  Used for custom drawing in the inspector.
    /// </summary>
    [System.Obsolete]
    public sealed class AxisStatePropertyAttribute : PropertyAttribute {}

    /// <summary>
    /// Property applied to legacy input axis name specification.  Used for custom drawing in the inspector.
    /// </summary>
    public sealed class InputAxisNamePropertyAttribute : PropertyAttribute {}

    /// <summary>
    /// Property applied to OrbitalTransposer.Heading.  Used for custom drawing in the inspector.
    /// </summary>
    [System.Obsolete]
    public sealed class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute {}

    /// <summary>
    /// This attributs is obsolete and unused.
    /// </summary>
    [System.Obsolete]
    public sealed class LensSettingsPropertyAttribute : PropertyAttribute {}

    /// <summary>
    /// Suppresses the top-level foldout on a complex property
    /// </summary>
    public sealed class HideFoldoutAttribute : PropertyAttribute {}
    
    /// <summary>
    /// Draw a foldout with an Enabled toggle that shadows a field inside the foldout
    /// </summary>
    public sealed class FoldoutWithEnabledButtonAttribute : PropertyAttribute 
    { 
        /// <summary>The name of the field controlling the enabled state</summary>
        public string EnabledPropertyName; 

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="enabledProperty">The name of the field controlling the enabled state</param>
        public FoldoutWithEnabledButtonAttribute(string enabledProperty = "Enabled") 
        { 
            EnabledPropertyName = enabledProperty; 
        }
    }

    /// <summary>
    /// Property applied to int or float fields to generate a slider in the inspector.
    /// </summary>
    public sealed class RangeSliderAttribute : PropertyAttribute 
    { 
        /// <summary>Minimum value for the range slider</summary>
        public float Min;
        /// <summary>Maximum value for the range slider</summary>
        public float Max;
        /// <summary>Constructor for the range slider attribute</summary>
        /// <param name="min">Minimum value for the range slider</param>
        /// <param name="max">Maximum value for the range slider</param>
        public RangeSliderAttribute(float min, float max) { Min = min; Max = max; }
    }
    
    /// <summary>
    /// Property applied to int or float fields to generate a minmax range slider in the inspector.
    /// </summary>
    public sealed class MinMaxRangeSliderAttribute : PropertyAttribute 
    { 
        /// <summary>Minimum value for the range slider</summary>
        public float Min;
        /// <summary>Maximum value for the range slider</summary>
        public float Max;
        /// <summary>Constructor for the range slider attribute</summary>
        /// <param name="min">Minimum value for the range slider</param>
        /// <param name="max">Maximum value for the range slider</param>
        public MinMaxRangeSliderAttribute(float min, float max) { Min = min; Max = max; }
    }

    /// <summary>
    /// Property applied to Vcam Target fields.  Used for custom drawing in the inspector.
    /// </summary>
    public sealed class VcamTargetPropertyAttribute : PropertyAttribute { }

    /// <summary>
    /// Property applied to CinemachineBlendDefinition.  Used for custom drawing in the inspector.
    /// </summary>
    public sealed class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute {}

    /// <summary>
    /// Invoke play-mode-save for a class.  This class's fields will be scanned
    /// upon exiting play mode, and its property values will be applied to the scene object.
    /// This is a stopgap measure that will become obsolete once Unity implements
    /// play-mode-save in a more general way.
    /// </summary>
    public sealed class SaveDuringPlayAttribute : System.Attribute {}

    /// <summary>
    /// Suppresses play-mode-save for a field.  Use it if the calsee has [SaveDuringPlay] 
    /// attribute but there are fields in the class that shouldn't be saved.
    /// </summary>
    public sealed class NoSaveDuringPlayAttribute : PropertyAttribute {}

    /// <summary>Property field is a Tag.</summary>
    public sealed class TagFieldAttribute : PropertyAttribute {}

    /// <summary>Property field is a NoiseSettings asset.</summary>
    public sealed class NoiseSettingsPropertyAttribute : PropertyAttribute {}    
    
    /// <summary>
    /// Used for custom drawing in the inspector.  Inspector will show a foldout with the asset contents
    /// </summary>
    public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute 
    {
        /// <summary>If true, inspector will display a warning if the embedded asset is null</summary>
        public bool WarnIfNull;

        /// <summary>Standard constructor</summary>
        /// <param name="warnIfNull">If true, inspector will display a warning if the embedded asset is null</param>
        public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false)
        {
            WarnIfNull = warnIfNull;
        }
    }
    
    /// <summary>
    /// Property applied to Vector2 to treat (x, y) as (min, max).
    /// Used for custom drawing in the inspector.
    /// </summary>
    public sealed class Vector2AsRangeAttribute : PropertyAttribute {}
}
