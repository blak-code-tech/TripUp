namespace TripUp.Services
{
    public interface IStatusBarChanger
    {
        void SetDeviceBarColor(System.Drawing.Color color, string type = "both");

        void SetLightTheme(System.Drawing.Color color);
        void SetDarkTheme(System.Drawing.Color color);
    }
}
