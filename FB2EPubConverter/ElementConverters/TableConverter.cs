﻿using System;
using FB2Library.Elements.Table;
using XHTMLClassLibrary.BaseElements;
using XHTMLClassLibrary.BaseElements.TableElements;

namespace FB2EPubConverter.ElementConverters
{
    internal class TableConverter : BaseElementConverter
    {
        /// <summary>
        /// Converts FB2 Table object into XHTML reperesentation
        /// </summary>
        /// <param name="tableItem">item to convert</param>
        /// <returns>XHTML representation</returns>
        public IHTMLItem Convert(TableItem tableItem)
        {
            if (tableItem == null)
            {
                throw new ArgumentNullException("tableItem");
            }
            var table = new Table();

            foreach (var row in tableItem.Rows)
            {
                var rowConverter = new RowConverter{Settings = Settings};
                table.Add(rowConverter.Convert(row));
            }

            SetClassType(table);

            table.GlobalAttributes.ID.Value = Settings.ReferencesManager.AddIdUsed(tableItem.ID, table);

            return table;
        }

        public override string GetElementType()
        {
            return string.Empty;
        }
    }
}
