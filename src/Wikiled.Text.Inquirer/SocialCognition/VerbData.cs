using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.SocialCognition
{
    /// <summary>
    /// Verb - based social cognition
    /// </summary>
    public class VerbData : InquirerItem
    {
        /// <summary>
        /// Verb giving an interpretative explanation of an action, such as "encourage, mislead, flatter"
        /// </summary>
        [InfoField("IAV")]
        public bool GivesInterpretativeExplanation { get; private set; }

        /// <summary>
        /// Straight descriptive verbs of an action or feature of an action, such as "run, walk, write, read".
        /// </summary>
        [InfoField("DAV")]
        public bool IsStraightDescriptive { get; private set; }

        /// <summary>
        /// Verb describing mental or emotional states. usually detached from specific observable events, such as "love, trust, abhor".
        /// </summary>
        [InfoField("SV")]
        public bool DoesDescribeMentalState { get; private set; }

        public override string Name => "Verb";
    }
}
