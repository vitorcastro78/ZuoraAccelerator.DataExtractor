using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
    /// </summary>
    [DataContract]
    public class CustomFields : Dictionary<string, Object>
    {
      
    }
}