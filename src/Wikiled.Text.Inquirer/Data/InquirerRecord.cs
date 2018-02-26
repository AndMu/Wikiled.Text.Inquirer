using Wikiled.Common.Arguments;
using Wikiled.Text.Inquirer.Logic;

namespace Wikiled.Text.Inquirer.Data
{
    public class InquirerRecord
    {
        public InquirerRecord(string word, string[] categories)
        {
            Guard.NotNullOrEmpty(() => word, word);
            Guard.NotEmpty(() => categories, categories);
            Word = word;
            RawCategories = categories;
            Description = InquirerDefinitionFactory.Instance.Construct(this);
        }

        public string[] RawCategories { get; }

        public string Word { get; }

        public InquirerDescription Description { get; }
    }
}
