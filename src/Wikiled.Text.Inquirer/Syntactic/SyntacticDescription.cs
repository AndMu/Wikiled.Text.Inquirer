using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Syntactic
{
    public class SyntacticDescription
    {
        public SyntacticDescription()
        {
            Determiner = new DeterminerData();
        }

        /// <summary>
        /// A valuing of having the influence to affect the policies of others.
        /// </summary>
        [InfoCategory("Determiner")]
        public DeterminerData Determiner { get; }
    }
}
