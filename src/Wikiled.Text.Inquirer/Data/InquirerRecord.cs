using System;
using Wikiled.Text.Inquirer.Logic;

namespace Wikiled.Text.Inquirer.Data
{
    public class InquirerRecord
    {
        public InquirerRecord(string word, string[] categories)
        {
            if (categories == null)
            {
                throw new ArgumentNullException(nameof(categories));
            }

            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(word));
            }

            Word = word;
            RawCategories = categories ?? throw new ArgumentNullException(nameof(categories));
            Description = InquirerDefinitionFactory.Instance.Construct(this);
        }

        public string[] RawCategories { get; }

        public string Word { get; }

        public InquirerDescription Description { get; }
    }
}
