using System;
using System.Windows;

namespace ThemeDemo.Models
{
    public class ThemeModel
    {
        public enum ThemeType
        {
            Light,
            Dark,
            Blue
        }

        public void ChangeTheme(ThemeType themeType)
        {
            string themePath = themeType switch
            {
                ThemeType.Light => "/Resources/Themes/LightTheme.xaml",
                ThemeType.Dark => "/Resources/Themes/DarkTheme.xaml",
                ThemeType.Blue => "/Resources/Themes/BlueTheme.xaml",
                _ => "/Resources/Themes/LightTheme.xaml",
            };

            // 清除当前资源字典中的主题相关合并字典
            var mergedDicts = Application.Current.Resources.MergedDictionaries;
            
            // 移除可能存在的主题资源字典
            for (int i = mergedDicts.Count - 1; i >= 0; i--)
            {
                var dict = mergedDicts[i];
                if (dict.Source != null && dict.Source.OriginalString.Contains("/Resources/Themes/"))
                {
                    mergedDicts.RemoveAt(i);
                }
            }

            // 创建并加载新的资源字典
            ResourceDictionary newDict = new ResourceDictionary
            {
                Source = new Uri(themePath, UriKind.Relative)
            };

            // 将新的资源字典添加到应用程序资源
            Application.Current.Resources.MergedDictionaries.Add(newDict);
        }
    }
} 