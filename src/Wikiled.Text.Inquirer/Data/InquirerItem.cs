using System;
using System.Linq;
using System.Reflection;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Data
{
    public abstract class InquirerItem
    {
        private PropertyInfo[] properties;

        public abstract string Name { get; }

        public virtual bool HasData
        {
            get
            {
                if (properties == null)
                {
                    properties = GetType().GetProperties()
                        .Where(property => Attribute.IsDefined(property, typeof(InfoFieldAttribute)))
                        .ToArray();
                }

                return properties
                    .Select(propertyInfo => (bool?)propertyInfo.GetValue(this, null))
                    .Any(value => value == true);
            }
        }
    }
}
