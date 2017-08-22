using Wikiled.Core.Utility.Arguments;

namespace Wikiled.Text.Inquirer.Data
{
    public class InquirerDefinition
    {
        public InquirerDefinition(string word, InquirerRecord[] records)
        {
            Guard.NotNullOrEmpty(() => word, word);
            Guard.NotNull(() => records, records);
            Word = word;
            Records = records;
        }

        public string Word { get; }

        public InquirerRecord[] Records { get; }
    }
}
