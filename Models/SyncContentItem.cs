using System.Collections.Generic;

namespace Agility.NET5.Shared.Models
{
    public class SyncContentItem
    {
        public long SyncToken { get; set; }
        public List<ContentItem> Items { get; set; }
    }
}
