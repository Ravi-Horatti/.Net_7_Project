using System.Text.Json.Serialization;

namespace New_Project.Models
{
   [ JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Knight=1,
        Mage=2,
        Cleric=3
        
    }
}