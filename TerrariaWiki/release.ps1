dotnet publish Flow.Launcher.Plugin.TerrariaWiki -c Release -r win-x64 --no-self-contained
Compress-Archive -LiteralPath Flow.Launcher.Plugin.TerrariaWiki/bin/Release/win-x64/publish -DestinationPath Flow.Launcher.Plugin.TerrariaWiki/bin/TerrariaWiki.zip -Force