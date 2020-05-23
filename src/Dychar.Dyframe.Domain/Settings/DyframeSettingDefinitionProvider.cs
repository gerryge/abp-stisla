using Volo.Abp.Settings;

namespace Dychar.Dyframe.Settings
{
    public class DyframeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DyframeSettings.MySetting1));
        }
    }
}
