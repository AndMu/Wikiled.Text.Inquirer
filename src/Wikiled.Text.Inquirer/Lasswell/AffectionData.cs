using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Lasswell
{
    /// <summary>
    /// Affection is the valuing of love and friendship
    /// </summary>
    public class AffectionData : InquirerItem
    {
        /// <summary>
        /// Words for reaping affect
        /// </summary>
        [InfoField("AffGain")]
        public bool IsGain { get; private set; }

        /// <summary>
        /// Words for affect loss and indifference
        /// </summary>
        [InfoField("AffLoss")]
        public bool IsLoss { get; private set; }

        /// <summary>
        /// Words for friends and family
        /// </summary>
        [InfoField("AffPt")]
        public bool IsParticipant { get; private set; }

        /// <summary>
        /// Affect words not in other categories
        /// </summary>
        [InfoField("AffOth")]
        public bool IsOther { get; private set; }

        /// <summary>
        /// Words in the affect domain
        /// </summary>
        [InfoField("AffTot")]
        public bool IsTotal { get; private set; }

        public override string Name => "Affection";
    }
}
