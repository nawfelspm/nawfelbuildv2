using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vaughnhouston : MonoBehaviour
{
    private static string kristyberry = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string jonidonovan;

    
    public static void alexisbrandt()
    {
        string prefix = PlayerPrefs.GetString(kristyberry, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        jonidonovan = PlayerPrefs.GetString(kristyberry, "");
        urlPrefixInput.text = jonidonovan;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        jonidonovan = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(kristyberry, jonidonovan);
        AudienceNetwork.AdSettings.SetUrlPrefix(jonidonovan);
    }

    public void AdViewScene()
    {
        SceneManager.LoadScene("AdViewScene");
    }

    public void InterstitialAdScene()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }

    public void RewardedVideoAdScene()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }
}
