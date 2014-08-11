﻿using HTML5ClassLibrary.Attributes.Events;

namespace HTML5ClassLibrary.Attributes.AttributeGroups.MediaEvents
{
    /// <summary>
    /// Script to be run when a file can be played all the way to the end without pausing for buffering
    /// </summary>
    public class OnMediaCanPlayThroughEventAttribute : OnEventAttribute
    {
        #region Overrides of OnEventAttribute

        protected override string GetAttributeName()
        {
            return "oncanplaythrough";
        }

        #endregion
    }
}
