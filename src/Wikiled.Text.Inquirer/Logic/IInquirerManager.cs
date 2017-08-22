using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Logic
{
    public interface IInquirerManager
    {
        int Total { get; }

        InquirerDefinition GetDefinitions(string word);

        void Load();
    }
}