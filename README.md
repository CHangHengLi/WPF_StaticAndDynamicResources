 # WPF静态资源与动态资源示例

本项目是一个基于.NET 8.0和WPF框架的MVVM架构应用程序，用于演示WPF中静态资源(StaticResource)和动态资源(DynamicResource)的区别和使用方法。
![image](https://github.com/user-attachments/assets/58fca4cb-dc96-4965-a62b-cbf3c01785c2)

## 项目概述

本应用程序通过可视化界面直观展示了以下内容：

- 静态资源的使用及其特点（加载时解析，不响应变化）
- 动态资源的使用及其特点（运行时解析，自动响应变化）
- 资源字典和主题切换的实现
- MVVM架构下的资源管理

## 项目结构

```
ThemeDemo/
├── Models/              // 数据模型
│   └── ThemeModel.cs    // 主题切换模型
├── ViewModels/          // 视图模型
│   ├── BaseViewModel.cs // MVVM基类
│   ├── MainViewModel.cs // 主视图模型
│   └── RelayCommand.cs  // 命令实现
├── Views/               // 视图
│   └── MainView.xaml    // 主视图
├── Resources/           // 资源文件
│   └── Themes/          // 主题资源
│       ├── LightTheme.xaml  // 浅色主题
│       ├── DarkTheme.xaml   // 深色主题
│       └── BlueTheme.xaml   // 蓝色主题
├── App.xaml             // 应用程序定义
├── MainWindow.xaml      // 主窗口
└── ThemeDemo.csproj     // 项目文件
```

## 功能特点

1. **三种主题切换**：
   - 浅色主题
   - 深色主题
   - 蓝色主题

2. **静态资源与动态资源对比**：
   - 左侧区域展示静态资源不响应变化的特性
   - 右侧区域展示动态资源实时更新的特性

3. **MVVM架构**：
   - 使用完全分离的MVVM设计模式
   - 通过命令绑定实现UI交互
   - 视图、视图模型和模型层职责分明

## 技术要点

### 静态资源（StaticResource）
- 在XAML加载时一次性解析
- 性能开销小
- 不响应资源变化
- 适合固定不变的资源

### 动态资源（DynamicResource）
- 在运行时按需解析
- 自动响应资源变化
- 性能开销较大
- 适合需要动态变化的资源

### 资源管理
- 使用ResourceDictionary组织资源
- 通过MergedDictionaries实现主题切换
- 资源引用链实现资源复用

## 如何使用

1. **运行应用程序**：
   - 使用Visual Studio 2022打开解决方案文件(ThemeDemo.sln)
   - 按F5运行项目或点击"开始调试"按钮

2. **查看静态资源与动态资源区别**：
   - 观察初始状态下两个区域的显示
   - 点击底部主题切换按钮，观察两个区域的变化

3. **探索主题切换功能**：
   - 点击"切换到浅色主题"按钮应用浅色主题
   - 点击"切换到深色主题"按钮应用深色主题
   - 点击"切换到蓝色主题"按钮应用蓝色主题

## 开发环境

- .NET 8.0
- Visual Studio 2022
- Windows操作系统

## 扩展和定制

1. **添加新主题**：
   - 在Resources/Themes目录下创建新的主题XAML文件
   - 在ThemeModel.cs中添加对应的枚举值和资源路径
   - 在MainViewModel.cs中添加新的命令

2. **定制现有主题**：
   - 修改对应主题文件中的颜色和样式资源

## 学习资源

要深入了解WPF中的资源系统，请参考：
- [StaticResource标记扩展](https://docs.microsoft.com/zh-cn/dotnet/desktop/wpf/advanced/staticresource-markup-extension)
- [DynamicResource标记扩展](https://docs.microsoft.com/zh-cn/dotnet/desktop/wpf/advanced/dynamicresource-markup-extension)

## 许可证

本项目采用MIT许可证发布。
