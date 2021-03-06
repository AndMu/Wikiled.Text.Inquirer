﻿using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Lasswell
{
    /// <summary>
    /// Knowledge, insight, and information concerning personal and cultural relations
    /// </summary>
    public class EnlightenmentData : InquirerItem
    {
        /// <summary>
        /// Likely to reflect a gain in enlightenment through thought, education, etc.
        /// </summary>
        [InfoField("EnlGain")]
        public bool IsGain { get; private set; }

        /// <summary>
        /// Reflecting misunderstanding, being misguided, or oversimplified.
        /// </summary>
        [InfoField("EnlLoss")]
        public bool IsLoss { get; private set; }

        /// <summary>
        /// Denoting pursuit of intrinsic enlightenment ideas.
        /// </summary>
        [InfoField("EnlEnds")]
        public bool IsEnds { get; private set; }

        /// <summary>
        /// Referring to roles in the secular enlightenment sphere.
        /// </summary>
        [InfoField("EnlPt")]
        public bool IsParticipant { get; private set; }

        /// <summary>
        /// Other enlightenment words
        /// </summary>
        [InfoField("EnlOth")]
        public bool IsOther { get; private set; }

        /// <summary>
        /// Any
        /// </summary>
        [InfoField("EnlTot")]
        public bool IsTotal { get; private set; }

        public override string Name => "Enlightenment";
    }
}
