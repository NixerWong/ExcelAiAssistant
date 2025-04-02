using System;
using System.Globalization;
using System.Threading;

public static class LanguageManager
{
    public static event Action LanguageChanged; // 语言切换事件

    public static void SetLanguage(string cultureCode)
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
        LanguageChanged?.Invoke(); // 触发事件通知所有窗体刷新
    }
}