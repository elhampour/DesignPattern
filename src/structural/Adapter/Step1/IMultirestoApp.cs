namespace Adapter.Step1
{
    public class FancyUIServiceAdaptor : IMultiRestoApp
    {
        private readonly FancyUIService fancyUIService;

        public FancyUIServiceAdaptor()
        {
            fancyUIService = new FancyUIService();
        }

        public void DisplayMenu(XmlData xmlData)
        {
            JsonData jsonData = ConvertXmlToJson(xmlData);
            fancyUIService.DisplayMenu(jsonData);
        }

        public void DisplayRecommendtaions(XmlData xmlData)
        {
            JsonData jsonData = ConvertXmlToJson(xmlData);
            fancyUIService.DisplayRecommendtaions(jsonData);
        }

        private JsonData ConvertXmlToJson(XmlData xmlData)
        {
            return new JsonData();
        }
    }
}
