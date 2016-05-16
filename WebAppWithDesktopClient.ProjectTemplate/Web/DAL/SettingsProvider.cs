using $safeprojectname$.Properties;

namespace $safeprojectname$.DAL
{
    public class SettingsProvider: ISettingsProvider
    {
        private readonly Settings _settings;

        public SettingsProvider(Settings settings)
        {
            this._settings = settings;
        }

        public int PageSize
        {
            get
            {
                return this._settings.PageSize;
            }
        }
    }
}