using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Syntactic
{
    public class VerbData : InquirerItem
    {
        /// <summary>
        ///  Verb 
        /// </summary>
        [InfoField("VERB")]
        public bool IsVerb { get; private set; }

        /// <summary>
        ///  be, being, is, was, -re..
        /// </summary>
        [InfoField("BE")]
        public bool IsBeingVerb { get; private set; }

        /// <summary>
        /// Linking verb seem, feel, look, sound, remain...
        /// </summary>
        [InfoField("LINK")]
        public bool IsLinkingVerb { get; private set; }

        /// <summary>
        /// Becoming verbs become, get, turn into, grow...
        /// </summary>
        [InfoField("VB")]
        public bool IsBecomingVerbs { get; private set; }

        /// <summary>
        /// have, has, had, having, 've...
        /// </summary>
        [InfoField("HAV")]
        public bool IsHave { get; private set; }

        /// <summary>
        /// can, may, shall, will, must -'ll...
        /// </summary>
        [InfoField("MOD")]
        public bool IsModal { get; private set; }

        /// <summary>
        /// Go verbs go, goes, going, gone, went...
        /// </summary>
        [InfoField("GO")]
        public bool IsGoVerb { get; private set; }

        /// <summary>
        /// Do verb do, did, does
        /// </summary>
        [InfoField("DO")]
        public bool IsDoVerb { get; private set; }

        /// <summary>
        /// "to" as an infinitive
        /// </summary>
        [InfoField("TO")]
        public bool IsTo { get; private set; }

        /// <summary>
        /// not, -n't, never
        /// </summary>
        [InfoField("NEG")]
        public bool IsNegative { get; private set; }

        /// <summary>
        /// any verb, including special verbs
        /// </summary>
        [InfoField("SUPV")]
        public bool IsSuperverb { get; private set; }

        public override string Name => "Verb";
    }
}
