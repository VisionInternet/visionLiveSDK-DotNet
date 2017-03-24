using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common.Token
{
    public class ConstantApiTokenGenerator : IApiTokenGenerator
    {
        #region Ctor
        public ConstantApiTokenGenerator(string token)
        {
            TokenFunc = () => token;
        }
        public ConstantApiTokenGenerator(Func<string> tokenFunc)
        {
            TokenFunc = tokenFunc;
        }

        #endregion

        #region Properties
        public Func<string> TokenFunc { get; set; }
        #endregion

        #region Implement IApiTokenGenerator
        public string Generate()
        {
            return TokenFunc();
        }
        #endregion

    }
}
