
using System.Text.Json;

namespace Agility.NET5.Shared.Util
{
    public static class Constants
    {
        public static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public static readonly string BaseUrl = "https://api.aglty.io";
        public static readonly string BaseUrlDev = "https://api-dev.aglty.io";
        public static readonly string Fetch = "fetch";
        public static readonly string Preview = "preview";
        public static readonly string Live = "live";
        public static readonly string SitemapPagesKey = "sitemapPages";
        public static readonly string UrlRedirectionsResponseKey = "urlRedirectionsResponse";
        public static readonly string PageTypeFolder = "folder";
        public static readonly string AgilityPreviewKeyName = "agilitypreviewkey";
        public static readonly string IsPreviewCookieName = "isPreview";

        public const string Html = "html";
        public const string Text = "text";
        public const string CustomField = "customfield";
        public const string DropDownList = "dropdownlist";
        public const string LongText = "longtext";
        public const string Boolean = "boolean";
        public const string Link = "link";
        public const string Content = "content";
        public const string Date = "date";
        public const string ImageAttachment = "imageattachment";
        public const string Integer = "integer";
    }



}

