﻿using HTML5ClassLibrary.Attributes.Events;

namespace HTML5ClassLibrary.Attributes.AttributeGroups.MediaEvents
{
    /// <summary>
    /// Script to be run when an error occurs when the file is being loaded 
    /// </summary>
    public class OnMediaErrorEventAttribute : OnEventAttribute
    {
        #region Overrides of OnEventAttribute

        protected override string GetAttributeName()
        {
            return "onerror";
        }

        #endregion
    }
}
