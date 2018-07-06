using System;

namespace Wikiled.Text.Inquirer.Data
{
    public class InquirerDefinition
    {
        public InquirerDefinition(string word, InquirerRecord[] records)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(word));
            }

            Word = word;
            Records = records ?? throw new ArgumentNullException(nameof(records));
        }

        public string Word { get; }

        public InquirerRecord[] Records { get; }
    }
}
