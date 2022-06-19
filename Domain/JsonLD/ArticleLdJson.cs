using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Domain.JsonLD
{
    public class ArticleLdJson
    {
        public string context { get; set; } = "https://schema.org";

        public string type { get; set; } = "NewsArticle";

        public MainEntityOfPage mainEntityOfPage { get; set; }

        public string headline { get; set; }

        public List<string> image { get; set; } = new List<string>();

        public string datePublished { get; set; }

        public string dateModified { get; set; }

        public Author author { get; set; }

        public Publisher publisher { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this)
                .Replace("context", "@context")
                .Replace("type", "@type")
                .Replace("id", "@id");
        }
    }

    public class MainEntityOfPage
    {
        public string type { get; set; } = "WebPage";

        public string id { get; set; }
    }

    public class Author
    {
        public string type { get; set; } = "Person";

        public string name { get; set; }
    }

    public class Publisher
    {
        public string type { get; set; } = "Organization";

        public string name { get; set; } = "Lucasology";

        public Logo logo { get; set; } = new Logo();
    }

    public class Logo
    {
        public string type { get; set; } = "ImageObject";

        public string url { get; set; }
    }
}
