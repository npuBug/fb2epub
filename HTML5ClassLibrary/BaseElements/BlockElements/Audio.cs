﻿using XHTMLClassLibrary.Attributes;
using XHTMLClassLibrary.BaseElements.InlineElements;

namespace XHTMLClassLibrary.BaseElements.BlockElements
{
    /// <summary>
    /// The "audio" tag defines sound, such as music or other audio streams.
    /// Currently, there are 3 supported file formats for the "audio" element: MP3, Wav, and Ogg:
    /// </summary>
    [HTMLItemAttribute(ElementName = "audio", SupportedStandards = HTMLElementType.HTML5)]
    public class Audio : HTMLItem, IBlockElement
    {
        [AttributeTypeAttributeMember(Name = "src", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly URITypeAttribute _src = new URITypeAttribute();

        [AttributeTypeAttributeMember(Name = "autoplay", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly FlagTypeAttribute _autoplay = new FlagTypeAttribute();

        [AttributeTypeAttributeMember(Name = "controls", SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly FlagTypeAttribute _controls = new FlagTypeAttribute();

        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly LoopAttribute  _loop = new LoopAttribute();

        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly MutedAttribute _muted = new MutedAttribute();

        [AttributeTypeAttributeMember(SupportedStandards = HTMLElementType.HTML5 | HTMLElementType.XHTML5)]
        private readonly PreloadAttribute _preload = new PreloadAttribute();



        /// <summary>
        /// Specifies the URL of the audio file
        /// </summary>
        public URITypeAttribute Src
        {
            get { return _src; }
        }

        /// <summary>
        /// Specifies that the audio will start playing as soon as it is ready
        /// </summary>
        public FlagTypeAttribute AutoPlay
        {
            get { return _autoplay; }
        }


        /// <summary>
        /// Specifies that audio controls should be displayed (such as a play/pause button etc)
        /// </summary>
        public FlagTypeAttribute  Controls
        {
            get { return _controls; }    
        }


        /// <summary>
        /// Specifies that the audio will start over again, every time it is finished
        /// </summary>
        public LoopAttribute Loop
        {
            get { return _loop; }
        }


        /// <summary>
        /// Specifies that the audio output should be muted
        /// </summary>
        public MutedAttribute Muted
        {
            get { return _muted; }
        }

        /// <summary>
        /// Specifies if and how the author thinks the audio should be loaded when the page loads
        /// </summary>
        public PreloadAttribute Preload
        {
            get { return _preload; }
        }

        public override bool IsValid()
        {
            return true;
        }

        protected override bool IsValidSubType(IHTMLItem item)
        {
            if (item is IInlineItem ||
                item is IBlockElement ||
                item is SimpleHTML5Text)
            {
                return item.IsValid();
            }
            return false;
        }
       
    }
}
