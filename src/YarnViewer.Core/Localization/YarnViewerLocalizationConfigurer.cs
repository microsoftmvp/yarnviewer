using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace YarnViewer.Localization
{
    public static class YarnViewerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(YarnViewerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(YarnViewerLocalizationConfigurer).GetAssembly(),
                        "YarnViewer.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
