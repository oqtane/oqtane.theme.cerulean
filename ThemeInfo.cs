using Oqtane.Themes;

namespace Oqtane.Theme.Cerulean
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Cerulean Theme",
            Version = "1.0.1"
        };
    }
}
