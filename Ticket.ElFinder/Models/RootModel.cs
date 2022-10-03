using System.Text.Json.Serialization;

namespace Ticket.ElFinder.Models
{
    public class RootModel : DirectoryModel
    {
        [JsonPropertyName("isroot")]
        public byte IsRoot => 1;
    }
}