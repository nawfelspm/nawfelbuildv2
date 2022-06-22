using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loydbarton : MonoBehaviour
{
    private static string sandrayee = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string judithwillard;

    
    public static void marisolramirez()
    {
        string prefix = PlayerPrefs.GetString(sandrayee, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        judithwillard = PlayerPrefs.GetString(sandrayee, "");
        urlPrefixInput.text = judithwillard;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        judithwillard = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(sandrayee, judithwillard);
        AudienceNetwork.AdSettings.SetUrlPrefix(judithwillard);
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
