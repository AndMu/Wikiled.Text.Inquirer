﻿using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Lasswell
{
    /// <summary>
    /// Reflect the valuing of skills. especially those of the arts in the aesthetics subcategory
    /// </summary>
    public class SkillData : InquirerItem
    {
        /// <summary>
        /// Skill aesthetic words mostly of the arts
        /// </summary>
        [InfoField("SklAsth")]
        public bool IsAesthetic { get; private set; }

        /// <summary>
        /// Participant - mainly about trades and professions.
        /// </summary>
        [InfoField("SklPt")]
        public bool IsParticipant { get; private set; }

        /// <summary>
        /// Other skill-related
        /// </summary>
        [InfoField("SklOth")]
        public bool IsOther { get; private set; }

        /// <summary>
        /// Any
        /// </summary>
        [InfoField("SklTOT")]
        public bool IsTotal { get; private set; }

        public override string Name => "Skills";
    }
}
