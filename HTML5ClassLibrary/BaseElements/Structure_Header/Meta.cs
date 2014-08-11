﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using HTML5ClassLibrary.Attributes;
using HTML5ClassLibrary.Attributes.AttributeGroups.HTMLGlobal;

namespace HTML5ClassLibrary.BaseElements.Structure_Header
{
    /// <summary>
    /// The meta element is a generic mechanism for specifying metadata for a Web page. 
    /// Some search engines use this information.
    /// </summary>
    public class Meta : IHTML5Item
    {
        internal const string ElementName = "meta";


        private readonly ContentAttribute _contentAttribute = new ContentAttribute();
        private readonly TokenNameAttribute _nameAttribute = new TokenNameAttribute();
        private readonly HTTPEquivAttribute _httpEqvAttribute = new HTTPEquivAttribute();
        private readonly CharsetAttribute _charsetAttribute = new CharsetAttribute();
        private readonly HTMLGlobalAttributes _globalAttributes = new HTMLGlobalAttributes();



        public HTMLGlobalAttributes GlobalAttributes { get { return _globalAttributes; }}

        /// <summary>
        /// Specifies the character encoding for the HTML document 
        /// </summary>
        public CharsetAttribute Charset { get { return _charsetAttribute; }}

        /// <summary>
        /// This attribute may be used in place of the name attribute. 
        /// Web servers use this attribute to gather information for HTTP response message headers.
        /// </summary>
        public HTTPEquivAttribute HTTPEquvalent { get { return _httpEqvAttribute; } }

        /// <summary>
        /// The property's value.
        /// </summary>
        public ContentAttribute Content { get { return _contentAttribute; } }


        /// <summary>
        /// Property name. 
        /// This attribute is required.
        /// </summary>
        public TokenNameAttribute Name { get { return _nameAttribute; } }


        /// <summary>
        /// Specifies an absolute URL that acts as the base URL for resolving relative URLs. 
        /// This attribute is required.
        /// </summary>
        public static XNamespace XhtmlNameSpace = @"http://www.w3.org/1999/xhtml";

        public void Load(XNode xNode)
        {
            if (xNode.NodeType != XmlNodeType.Element)
            {
                throw new Exception("xNode is not of element type");
            }
            var xElement = (XElement)xNode;
            if (xElement.Name.LocalName != ElementName)
            {
                throw new Exception(string.Format("xNode is not {0} element", ElementName));
            }

            _globalAttributes.ReadAttributes(xElement);
            _contentAttribute.ReadAttribute(xElement);
            _nameAttribute.ReadAttribute(xElement);
            _httpEqvAttribute.ReadAttribute(xElement);
            _charsetAttribute.ReadAttribute(xElement);
        }

        public XNode Generate()
        {
            var xElement = new XElement(XhtmlNameSpace + ElementName);

            _globalAttributes.AddAttributes(xElement);
            _contentAttribute.AddAttribute(xElement);
            _nameAttribute.AddAttribute(xElement);
            _httpEqvAttribute.AddAttribute(xElement);
            _charsetAttribute.AddAttribute(xElement);

            return xElement;
        }

        public bool IsValid()
        {
            return true;
        }

        /// <summary>
        /// Adds sub-item to the item , only if 
        /// allowed by the rules and element can accept content
        /// </summary>
        /// <param name="item">sub-item to add</param>
        public void Add(IHTML5Item item)
        {
            throw new Exception("This element does not contain sub-items");
        }

        public void Remove(IHTML5Item item)
        {
            throw new Exception("This element does not contain sub-items");
        }

        public List<IHTML5Item> SubElements()
        {
            return null;
        }

        /// <summary>
        /// Get/Set item parent in the XHTML "tree"
        /// </summary>
        public IHTML5Item Parent { get; set; }
    }
}
