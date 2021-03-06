﻿using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Harvard
{
    /// <summary>
    /// Broader group
    /// </summary>
    public class BroadData : InquirerItem
    {
        /// <summary>
        /// Political
        /// </summary>
        [InfoField("POLIT")]
        public bool IsPolitical { get; private set; }

        /// <summary>
        /// Economic related
        /// </summary>
        [InfoField("ECON")]
        public bool IsEconomic { get; private set; }

        /// <summary>
        /// Economic related
        /// </summary>
        [InfoField("ABS")]
        public bool IsAbstract { get; private set; }

        /// <summary>
        /// Words which imply judgment and evaluation
        /// </summary>
        [InfoField("EVAL")]
        public bool IsEvaluation { get; private set; }

        public override string Name => "Broader group";
    }
}
