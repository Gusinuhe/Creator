using System;

namespace Innoactive.Creator.Core.Attributes
{
    /// <summary>
    /// Displayed name of training entity's property or field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Class)]
    public class DisplayNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public DisplayNameAttribute(string name)
        {
            Name = name;
        }
    }
}
