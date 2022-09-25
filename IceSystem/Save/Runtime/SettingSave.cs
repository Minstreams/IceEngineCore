namespace IceEngine.Internal
{
    [IceSettingPath("IceEngine/IceSystem/Save")]
    public class SettingSave : Framework.IceSetting<SettingSave>
    {
        public SettingSave()
        {
            themeColor = new UnityEngine.Color(0.4773f, 0.7075f, 0.4953f);
        }
    }
}