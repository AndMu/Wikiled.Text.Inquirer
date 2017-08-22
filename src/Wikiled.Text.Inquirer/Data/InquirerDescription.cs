using Wikiled.Text.Inquirer.Harvard;
using Wikiled.Text.Inquirer.Lasswell;
using Wikiled.Text.Inquirer.Reflection;

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
        }

        [InfoCategory("Harward")]
        public HarwardDescription Harward { get; }

        [InfoCategory("Lasswell")]
        public LasswellDescription Lasswell { get; }

        [InfoField("General Information", IsOptional = true)]
        public string Information { get; set; }

        public string OtherTags { get; set; }
    }
}
