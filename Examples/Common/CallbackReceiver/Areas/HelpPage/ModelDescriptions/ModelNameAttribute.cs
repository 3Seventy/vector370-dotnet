using System;

namespace CallbackReceiver.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Use this attribute to change the name of the <see cref="ModelDescription"/> generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public sealed class ModelNameAttribute : Attribute
    {
        /// <summary />
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        /// <summary />
        public string Name { get; private set; }
    }
}