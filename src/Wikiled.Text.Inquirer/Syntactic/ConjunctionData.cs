using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Syntactic
{
    public class ConjunctionData : InquirerItem
    {
        /// <summary>
        ///  Conjunction 
        /// </summary>
        [InfoField("CONJ")]
        public bool IsConjunction { get; private set; }

        /// <summary>
        ///  Sentential and, but
        /// </summary>
        [InfoField("CONJ1")]
        public bool IsSentential { get; private set; }

        /// <summary>
        ///  Clausal then, that, because, if, when, since, as, so, etc.
        /// </summary>
        [InfoField("CONJ2")]
        public bool IsClausal { get; private set; }
        
        public override string Name => "Conjunction";
    }
}
