using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Localization.Settings;
using JetBrains.Annotations;
using UnityEngine.Localization;
using System.Threading;

public class LocalSelector : MonoBehaviour
{
    public void ChangeLocale(int localeID)  
    {
        SetLocale(localeID);
    }

    public void SetLocale(int _localeID)
    {
        var currentLocaleId = LocalizationSettings.SelectedLocale.SortOrder;
        if (currentLocaleId != _localeID)
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

    }

}
