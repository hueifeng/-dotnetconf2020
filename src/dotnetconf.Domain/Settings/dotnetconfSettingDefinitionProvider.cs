using Volo.Abp.Settings;

namespace dotnetconf.Settings
{
    public class dotnetconfSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(dotnetconfSettings.MySetting1));
        }
    }
}
