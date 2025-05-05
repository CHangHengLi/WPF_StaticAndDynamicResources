using System.Windows.Input;
using ThemeDemo.Models;

namespace ThemeDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly ThemeModel _themeModel;
        private string _currentTheme;

        public MainViewModel()
        {
            _themeModel = new ThemeModel();
            _currentTheme = "浅色主题";

            SwitchToLightThemeCommand = new RelayCommand(param => SwitchTheme(ThemeModel.ThemeType.Light));
            SwitchToDarkThemeCommand = new RelayCommand(param => SwitchTheme(ThemeModel.ThemeType.Dark));
            SwitchToBlueThemeCommand = new RelayCommand(param => SwitchTheme(ThemeModel.ThemeType.Blue));
        }

        public string CurrentTheme
        {
            get => _currentTheme;
            set => SetProperty(ref _currentTheme, value);
        }

        public ICommand SwitchToLightThemeCommand { get; }
        public ICommand SwitchToDarkThemeCommand { get; }
        public ICommand SwitchToBlueThemeCommand { get; }

        private void SwitchTheme(ThemeModel.ThemeType themeType)
        {
            _themeModel.ChangeTheme(themeType);
            
            CurrentTheme = themeType switch
            {
                ThemeModel.ThemeType.Light => "浅色主题",
                ThemeModel.ThemeType.Dark => "深色主题",
                ThemeModel.ThemeType.Blue => "蓝色主题",
                _ => "浅色主题",
            };
        }
    }
} 