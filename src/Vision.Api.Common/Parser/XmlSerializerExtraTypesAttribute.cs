using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Parser
{
    /// <summary>
    /// the attribute class to indicate the extra types which is used for XML serializer.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class XmlSerializerExtraTypesAttribute : Attribute
    {
        public XmlSerializerExtraTypesAttribute(params Type[] types)
        {
            Types = types;
        }

        public Type[] Types { get; private set; }
    }
}
