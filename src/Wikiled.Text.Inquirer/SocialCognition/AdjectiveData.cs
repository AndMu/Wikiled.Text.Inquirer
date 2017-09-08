using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.SocialCognition
{
    /// <summary>
    /// Adjective - based social cognition
    /// </summary>
    public class AdjectiveData : DataItem
    {
        /// <summary>
        /// Adjective referring to relations between people, such as "unkind, aloof, supportive".
        /// </summary>
        [InfoField("IPadj")]
        public bool IsRelationship  { get; private set; }

        /// <summary>
        /// Adjective describing people apart from their relations to one another, such as "thrifty, restless"
        /// </summary>
        [InfoField("IndAdj")]
        public bool IsApartRelationship  { get; private set; }

        public override string Name => "Adjective";
    }
}
