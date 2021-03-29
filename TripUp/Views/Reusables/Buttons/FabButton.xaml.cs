using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripUp.Views.Reusables.Buttons
{
    public partial class FabButton : ContentView
    {
        #region Bindable Properties

        public static readonly BindableProperty FabBackgroundColorProperty =
            BindableProperty.Create("FabBackgroundColor", typeof(Color), 
                typeof(FabButton),Color.White, BindingMode.TwoWay);
        
        public static readonly BindableProperty FabBorderColorProperty =
            BindableProperty.Create("FabBorderColor", typeof(Color), 
                typeof(FabButton),Color.Transparent, BindingMode.TwoWay);

        public static readonly BindableProperty GlyphColorProperty =
            BindableProperty.Create("GlyphColor", typeof(Color), typeof(FabButton));

        public static readonly BindableProperty GlyphProperty =
            BindableProperty.Create("Glyph", typeof(string), typeof(FabButton));
        
        public static readonly BindableProperty GlyphSizeProperty =
            BindableProperty.Create("GlyphSize", typeof(double), 
                typeof(FabButton), 50.0);

        public static readonly BindableProperty GlyphFontFamilyProperty =
            BindableProperty.Create("GlyphFontFamily", typeof(string), typeof(FabButton));

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(FabButton));

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create("CommandParameter", typeof(string), typeof(FabButton));

        #endregion

        #region Properties

        public Color FabBackgroundColor
        {
            get { return (Color)GetValue(FabBackgroundColorProperty); }
            set { SetValue(FabBackgroundColorProperty, value); }
        }
        
        public Color FabBorderColor
        {
            get { return (Color)GetValue(FabBorderColorProperty); }
            set { SetValue(FabBorderColorProperty, value); }
        }

        public Color GlyphColor
        {
            get { return (Color)GetValue(GlyphColorProperty); }
            set { SetValue(GlyphColorProperty, value); }
        }

        public string Glyph
        {
            get { return (string)GetValue(GlyphProperty); }
            set { SetValue(GlyphProperty, value); }
        }
        
        public double GlyphSize
        {
            get { return (double)GetValue(GlyphSizeProperty); }
            set { SetValue(GlyphSizeProperty, value); }
        }

        public string GlyphFontFamily
        {
            get { return (string)GetValue(GlyphFontFamilyProperty); }
            set { SetValue(GlyphFontFamilyProperty, value); }
        }
        
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        
        public string CommandParameter
        {
            get { return (string)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        #endregion

        #region Constructor

        public FabButton()
        {
            InitializeComponent();

            BindingContext = this;
        }

        #endregion

    }
}