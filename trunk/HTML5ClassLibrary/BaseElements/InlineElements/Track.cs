﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using XHTMLClassLibrary.Attributes;
using XHTMLClassLibrary.Attributes.FlaggedAttributes;

namespace XHTMLClassLibrary.BaseElements.InlineElements
{
    /// <summary>
    /// The "track" tag specifies text tracks for media elements ("audio" and "video").
    /// This element is used to specify subtitles, caption files or other files containing text, that should be visible when the media is playing.
    /// </summary>
    [HTMLItemAttribute(ElementName = "track", SupportedStandards = HTMLElementType.HTML5)]
    public class Track : HTMLItem, IInlineItem
    {
        [AttributeTypeAttributeMember(Name = "default", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly FlagAttribute _defaultAttribute = new FlagAttribute();

        [AttributeTypeAttributeMember(Name = "label", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly TextValueAttribute _labelAttribute = new TextValueAttribute();

        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly SourceAttribute _sourceAttribute = new SourceAttribute();

        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly TrackKindAttribute _trackKindAttribute = new TrackKindAttribute();

        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly SourceLanguageAttribute _sourceLanguageAttribute = new SourceLanguageAttribute();


        /// <summary>
        /// Specifies the language of the track text data (required if kind="subtitles")
        /// </summary>
        public SourceLanguageAttribute SourceLanguage { get { return _sourceLanguageAttribute; }}

        /// <summary>
        /// Specifies the kind of text track
        /// </summary>
        public TrackKindAttribute Kind { get { return _trackKindAttribute; }}

        /// <summary>
        /// Required. Specifies the URL of the track file
        /// </summary>
        public SourceAttribute Source { get { return _sourceAttribute; }}

        /// <summary>
        /// Specifies the title of the text track
        /// </summary>
        public TextValueAttribute Label { get { return _labelAttribute; }}

        /// <summary>
        /// Specifies that the track is to be enabled if the user's preferences do not indicate that another track would be more appropriate
        /// </summary>
        public FlagAttribute Default { get { return _defaultAttribute; }}

        public override bool IsValid()
        {
            return _sourceAttribute.HasValue();
        }

        public override List<IHTMLItem> SubElements()
        {
            return null;
        }
    }
}