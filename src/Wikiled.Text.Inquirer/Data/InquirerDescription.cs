using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Inquirer.Harvard;
using Wikiled.Text.Inquirer.Lasswell;
using Wikiled.Text.Inquirer.Syntactic;

namespace Wikiled.Text.Inquirer.Data
{
    /// <summary>
    /// Inquirer word description
    /// </summary>
    [InfoCategory("Inquirer Description")]
    public class InquirerDescription
    {
        public InquirerDescription()
        {
            Harward = new HarwardDescription();
            Lasswell = new LasswellDescription();
            Syntactic = new SyntacticDescription();
        }

        [InfoCategory("Syntactic")]
        public SyntacticDescription Syntactic { get; }

        [InfoCategory("Harward")]
        public HarwardDescription Harward { get; }

        [InfoCategory("Lasswell")]
        public LasswellDescription Lasswell { get; }

        [InfoField("General Information", IsOptional = true)]
        public string Information { get; set; }

        public string OtherTags { get; set; }
    }
}
