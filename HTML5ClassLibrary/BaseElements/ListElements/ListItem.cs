﻿using XHTMLClassLibrary.Attributes;
using XHTMLClassLibrary.BaseElements.BlockElements;
using XHTMLClassLibrary.BaseElements.InlineElements;

namespace XHTMLClassLibrary.BaseElements.ListElements
{
    /// <summary>
    /// The li element represents a list item in ordered lists and unordered lists.
    /// </summary>
    [HTMLItemAttribute(ElementName = "li", SupportedStandards = HTMLElementType.HTML5 |  HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
    public class ListItem : HTMLItem 
    {
        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly ListItemTypeAtttribute _listItemTypeAtttribute = new ListItemTypeAtttribute();

        [AttributeTypeAttributeMember(Name = "value", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5 | HTMLElementType.XHTML11 | HTMLElementType.Transitional | HTMLElementType.Strict | HTMLElementType.FrameSet)]
        private readonly TextValueAttribute _valueAttribute = new TextValueAttribute();




        /// <summary>
        ///  Specifies which kind of bullet point will be used
        /// Not supported in HTML5.
        /// </summary>
        public ListItemTypeAtttribute Type { get { return _listItemTypeAtttribute; }}

        /// <summary>
        /// Specifies the value of a list item. 
        /// </summary>
        public TextValueAttribute Value { get { return _valueAttribute; }}

        protected override bool IsValidSubType(IHTMLItem item)
        {
            if (item is IInlineItem)
            {
                return item.IsValid();
            }
            if (item is IBlockElement)
            {
                return item.IsValid();
            }
            if (item is SimpleHTML5Text)
            {
                return item.IsValid();
            }
            return false;
        }


        /// <summary>
        /// Checks it element data is valid
        /// </summary>
        /// <returns>true if valid</returns>
        public override bool IsValid()
        {
            return true;
        }
    }
}
