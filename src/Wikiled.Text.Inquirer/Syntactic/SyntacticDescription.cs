using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Syntactic
{
    public class SyntacticDescription
    {
        public SyntacticDescription()
        {
            Determiner = new DeterminerData();
            Conjunction = new ConjunctionData();
            Interrogative = new InterrogativesData();
            Verb = new VerbData();
        }

        /// <summary>
        /// A valuing of having the influence to affect the policies of others.
        /// </summary>
        [InfoCategory("Determiner")]
        public DeterminerData Determiner { get; }

        /// <summary>
        /// Conjunction
        /// </summary>
        [InfoCategory("Conjunction")]
        public ConjunctionData Conjunction { get; }

        /// <summary>
        /// Interrogative
        /// </summary>
        [InfoCategory("Interrogative")]
        public InterrogativesData Interrogative { get; }

        /// <summary>
        /// Verb
        /// </summary>
        [InfoCategory("Verb")]
        public VerbData Verb { get; }
    }
}
