﻿using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Analysis.Reflection;

namespace Wikiled.Text.Inquirer.Harvard
{
    /// <summary>
    /// References to objects
    /// </summary>
    public class ObjectData : InquirerItem
    {
        /// <summary>
        /// Object
        /// </summary>
        [InfoField("Object")]
        public bool IsObject { get; private set; }

        /// <summary>
        /// Tool
        /// </summary>
        [InfoField("Tool")]
        public bool Tool { get; private set; }

        /// <summary>
        /// Food
        /// </summary>
        [InfoField("Food")]
        public bool IsFood { get; private set; }

        /// <summary>
        /// Vehicle
        /// </summary>
        [InfoField("Vehicle")]
        public bool IsVehicle { get; private set; }

        /// <summary>
        /// Buildings, rooms in buildings, and other building parts
        /// </summary>
        [InfoField("BldgPt")]
        public bool IsBuilding { get; private set; }

        /// <summary>
        /// Tools of communication
        /// </summary>
        [InfoField("ComnObj")]
        public bool IsCommunication { get; private set; }

        /// <summary>
        /// Natural objects including plants, minerals and other objects occurring in nature other than people or animals
        /// </summary>
        [InfoField("NatObj")]
        public bool IsNatural { get; private set; }

        /// <summary>
        /// List of parts of the body 
        /// </summary>
        [InfoField("BodyPt")]
        public bool IsBodyPart { get; private set; }

        public override string Name => "Object";
    }
}
