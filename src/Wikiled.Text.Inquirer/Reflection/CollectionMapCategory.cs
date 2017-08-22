﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Wikiled.Core.Utility.Arguments;
using Wikiled.Text.Inquirer.Reflection.Data;

namespace Wikiled.Text.Inquirer.Reflection
{
    public class CollectionMapCategory : ChildMapCategory
    {
        public CollectionMapCategory(IMapCategory parent, InfoArrayCategoryAttribute attribute, PropertyInfo propertyInfo)
            : base(parent, attribute.Name, propertyInfo)
        {
            Attribute = attribute;
        }

        protected override IEnumerable<IMapField> ConstructAllChildFields()
        {
            yield break;
        }

        public override IMapField[] Fields { get; } = {};

        public InfoArrayCategoryAttribute Attribute { get; }

        public override IEnumerable<IDataItem> GetOtherLeafs(object instance)
        {
            var collection = (IEnumerable)instance;
            PropertyInfo textProperty = null;
            PropertyInfo valueProperty = null;
            foreach(var item in collection)
            {
                if(textProperty == null)
                {
                    Type itemType = item.GetType();
                    textProperty = itemType.GetProperty(Attribute.TextField);
                    valueProperty = itemType.GetProperty(Attribute.ValueField);
                    Guard.NotNull(() => textProperty, textProperty);
                    Guard.NotNull(() => valueProperty, valueProperty);
                }

                string name = (string)textProperty.GetValue(item, null);
                object value = valueProperty.GetValue(item, null);
                DataItem dataItemitem = new DataItem(Name, name, name, value);
                yield return dataItemitem;
            }
        }
    }
}
