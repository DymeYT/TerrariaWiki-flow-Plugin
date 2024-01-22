using Flow.Launcher.Plugin;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using Flow.Launcher.Plugin.SharedCommands;

namespace Flow.Launcher.Plugin.TerrariaWiki
{
    public class TerrariaWiki : IPlugin
    {
        private PluginInitContext _context;

        private readonly string base_url = "https://terraria.fandom.com/";
        private string query_url;

        private readonly string icon_path = "icon.png";

        public void Init(PluginInitContext context)
        {
            query_url = base_url + "api.php?action=query&list=search&srwhat=text&format=json&srsearch=";

            _context = context;
        }

        public List<Result> Query(Query query)
        {

            string finalUrl = base_url + "wiki/" + query.Search;

            var result = new Result
            {
                Title = "`Search Terraria wiki",
                SubTitle = $" {query_url+  query.Search}",
                Action = e =>
                {
                    finalUrl.OpenInBrowserTab();
                    return true;
                },
                IcoPath = "icon.png"
            };
            return new List<Result>() { result };
        }
    }
}