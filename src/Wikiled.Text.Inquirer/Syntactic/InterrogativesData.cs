using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Syntactic
{
    public class InterrogativesData : InquirerItem
    {
        /// <summary>
        ///  wh-words -when, why, who, what, where, how
        /// </summary>
        [InfoField("INT")]
        public bool IsInterrogatives { get; private set; }

        public override string Name => "Interrogative";
    }
}
