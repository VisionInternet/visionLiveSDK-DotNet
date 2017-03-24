using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Api.Common
{
    public class ApiDictionary : Dictionary<string, string>
    {
        #region Ctor
        public ApiDictionary() 
        { 
        }

        public ApiDictionary(IDictionary<string, string> dictionary)
            : base(dictionary)
        {
        }

        public ApiDictionary(NameValueCollection nameValueCollection)
            : this()
        {
            foreach (var key in nameValueCollection.AllKeys)
            {
                Add(key, nameValueCollection[key]);
            }
        }
        #endregion

        #region AddDictionary
        /// <summary>
        /// Add a new key value pair, NULL or Empty will be ignored.
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">The value of key, currently supported types: string, int, long, double, bool, DateTime</param>
        public void Add(string key, object value)
        {
            string strValue;

            if (value == null)
            {
                strValue = null;
            }
            else if (value is string)
            {
                strValue = (string)value;
            }
            else if (value is Nullable<DateTime>)
            {
                Nullable<DateTime> dateTime = value as Nullable<DateTime>;
                //strValue = dateTime.Value.ToUniversalTime().ToString();
                strValue = dateTime.Value.ToString(ApiConstant.DATE_TIME_FORMAT);
            }
            else if (value is Nullable<int>)
            {
                strValue = (value as Nullable<int>).Value.ToString();
            }
            else if (value is Nullable<long>)
            {
                strValue = (value as Nullable<long>).Value.ToString();
            }
            else if (value is Nullable<double>)
            {
                strValue = (value as Nullable<double>).Value.ToString();
            }
            else if (value is Nullable<bool>)
            {
                strValue = (value as Nullable<bool>).Value.ToString().ToLower();
            }
            else
            {
                strValue = value.ToString();
            }

            this.Add(key, strValue);
        }

        public new void Add(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                base.Add(key, value);
            }
        }

        public void Merge(IDictionary<string, string> newDictionary)
        {
            foreach (var keyValue in newDictionary)
            {
                Add(keyValue.Key, keyValue.Value);
            }
        }
        #endregion

    }
}
