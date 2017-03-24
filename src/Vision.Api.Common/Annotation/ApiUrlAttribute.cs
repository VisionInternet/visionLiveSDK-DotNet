using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    /// <summary>
    /// This class is to indicate the Api URL, which is usually used on IApiRequest class. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiUrlAttribute : Attribute
    {
        #region Ctor
        public ApiUrlAttribute(string url)
        {
            Url = url;
        }
        #endregion

        #region Property
        public string Url { get; private set; }
        #endregion
    }
}
