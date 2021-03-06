using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Emeric.LightAnimator
{
    public static class Constants
    {
        #region Animated Light Labels & Tooltips & Values

        //Intensity
        public const string Label_LightIntensityRange = "Intensity Range";
        public const string Tooltip_LightIntensityRange = "The light intensity target will be defined from this range and cannot go outside of this range." + 
                                                          "\n\nUse negative values if you want to weigh in more chance for the light to be off.";

        //Speed
        public const string Label_LightIntensitySpeedRange = "Speed Range";
        public const string Tooltip_LightIntensitySpeedRange = "The amount of light intensity that can change per second." +
                                                               "Each time a new target intensity is assigned, a random speed value from this range is assigned.";
        public const float Value_LightIntensitySpeedRangeMax = 100f;

        //Step
        public const string Label_LightIntensityChangeStepRange = "Step Range";
        public const string Tooltip_LightIntensityChangeStepRange = "A step added to or substracted from the target intensity." + 
                                                                    "\n\nEach time a new target intensity is assigned, a random step value from this range is assigned." + 
                                                                    "\n\nThe max value of this field equals your intensity range.";

        //Color Method
        public const string Label_ColorChangeMethod = "Color Change Method";
        public const string Tooltip_ColorChangeMethod = "Keep: Keeps the current color.\n\nSet: Sets the color on update.\n\nLerp: Changes the color gradually.";

        //Color
        public const string Label_ColorToSet = "";
        public const string Tooltip_ColorToSet = "The color to set the target light to.";
        public const string InfoText_IfPresetSetColorFalse = "The selected preset does not set color. Override the 'Color Change Method' if you wish to change the light's color.";
        public const string InfoText_IfOverrideColorMethodKeep = "The 'Color Change Method' Override is set to 'Keep'. Set it to 'Set' or 'Lerp' if you wish to change the light's color.";

        //Timer Range
        public const string Label_TimerRange = "Timer Range";
        public const string Tooltip_TimerRange = "When this timer reaches 0, targets are changed." + 
                                                 "\n\nEach time a new target intensity is assigned, a random timer is assigned from this range.";

        //(initial) timer
        public const string Label_ChangeTargetTimer = "Initial Timer";
        public const string Tooltip_ChangeTargetTimer = "The timer will be set to this value when the light is assigne this setting." +
                                                        "Use this if you need lights with similar settings that need to alternate (e.g. police).";

        #endregion
    }
}
