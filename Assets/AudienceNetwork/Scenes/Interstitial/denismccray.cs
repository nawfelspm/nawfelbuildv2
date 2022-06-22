using UnityEngine;
using UnityEngine.UI;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using AudienceNetwork.Utility;

public class denismccray : felixtaylor
{

    private InterstitialAd interstitialAd;
    private bool anniekaplan;
#pragma warning disable 0414
    private bool michellehammond;
#pragma warning restore 0414
    
    public Text statusLabel;

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        loydbarton.marisolramirez();
    }

    
    public void LoadInterstitial()
    {
        statusLabel.text = "Loading interstitial ad...";

        
        
        interstitialAd = new InterstitialAd("YOUR_PLACEMENT_ID");

        interstitialAd.Register(gameObject);

        
        interstitialAd.InterstitialAdDidLoad = delegate ()
        {
            Debug.Log("Interstitial ad loaded.");
            anniekaplan = true;
            michellehammond = false;
            string georgettecrowley = interstitialAd.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Ad loaded and is " + georgettecrowley + ". Click show to present!";
        };
        interstitialAd.InterstitialAdDidFailWithError = delegate (string error)
        {
            Debug.Log("Interstitial ad failed to load with error: " + error);
            statusLabel.text = "Interstitial ad failed to load. Check console for details.";
        };
        interstitialAd.InterstitialAdWillLogImpression = delegate ()
        {
            Debug.Log("Interstitial ad logged impression.");
        };
        interstitialAd.InterstitialAdDidClick = delegate ()
        {
            Debug.Log("Interstitial ad clicked.");
        };
        interstitialAd.InterstitialAdDidClose = delegate ()
        {
            Debug.Log("Interstitial ad did close.");
            michellehammond = true;
            if (interstitialAd != null)
            {
                interstitialAd.Dispose();
            }
        };

#if UNITY_ANDROID
        /*
         * Only relevant to Android.
         * This callback will only be triggered if the Interstitial activity has
         * been destroyed without being properly closed. This can happen if an
         * app with launchMode:singleTask (such as a Unity game) goes to
         * background and is then relaunched by tapping the icon.
         */
        interstitialAd.interstitialAdActivityDestroyed = delegate() {
            if (!michellehammond) {
                Debug.Log("Interstitial activity destroyed without being closed first.");
                Debug.Log("Game should resume.");
            }
        };
#endif

        
        interstitialAd.LoadAd();
    }

    
    public void ShowInterstitial()
    {
        if (anniekaplan)
        {
            interstitialAd.Show();
            anniekaplan = false;
            statusLabel.text = "";
        }
        else
        {
            statusLabel.text = "Ad not loaded. Click load to request an ad.";
        }
    }

    void OnDestroy()
    {
        
        if (interstitialAd != null)
        {
            interstitialAd.Dispose();
        }
        Debug.Log("InterstitialAdTest was destroyed!");
    }

    
    public void morgandenny()
    {
        SceneManager.LoadScene("AdViewScene");
    }
}
