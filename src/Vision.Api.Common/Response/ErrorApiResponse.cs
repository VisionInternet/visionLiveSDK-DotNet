using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vision.Api.Common
{
    /// <summary>
    /// The Class to handle error.
    /// </summary>
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class ErrorApiResponse : ApiResponse<ErrorApiRequest>
    {
    }
}
