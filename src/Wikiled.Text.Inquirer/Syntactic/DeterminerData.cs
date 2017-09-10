using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Syntactic
{
    public class DeterminerData : DataItem
    {
        /// <summary>
        /// Determiner
        /// </summary>
        [InfoField("DET")]
        public bool IsDeterminer { get; private set; }

        /// <summary>
        /// Article a, an, the
        /// </summary>
        [InfoField("ART")]
        public bool IsArticle { get; private set; }

        /// <summary>
        /// Demonstrative
        /// </summary>
        [InfoField("DEM")]
        public bool IsDemonstrative { get; private set; }

        /// <summary>
        /// this
        /// </summary>
        [InfoField("DEM1")]
        public bool IsDemonstrative1 { get; private set; }

        /// <summary>
        /// that, those
        /// </summary>
        [InfoField("DEM2")]
        public bool IsDemonstrative2 { get; private set; }

        /// <summary>
        /// Genitives  my, our, your, his, her, their, its, whose
        /// </summary>
        [InfoField("GEN")]
        public bool IsGenitive { get; private set; }

        /// <summary>
        /// Genitives  my, our, your, his, her, their, its, whose
        /// </summary>
        [InfoField("NUMB")]
        public bool IsNumber { get; private set; }

        /// <summary>
        /// one, two, three, 35, 1968
        /// </summary>
        [InfoField("CARD")]
        public bool IsCard { get; private set; }

        /// <summary>
        /// first, second, 3rd...next, last
        /// </summary>
        [InfoField("ORD")]
        public bool IsOrd { get; private set; }

        /// <summary>
        /// Prearticle
        /// </summary>
        [InfoField("PRE")]
        public bool IsPrearticle { get; private set; }

        /// <summary>
        /// both, each, either, another, few, fewer, many, several, neither, every
        /// </summary>
        [InfoField("PRE1")]
        public bool IsPrearticle1 { get; private set; }

        /// <summary>
        ///  all, any, some , enough, half, no
        /// </summary>
        [InfoField("PRE2")]
        public bool IsPrearticle2 { get; private set; }

        public override string Name => "Determiner";
    }
}
