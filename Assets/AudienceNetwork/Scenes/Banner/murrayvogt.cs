using UnityEngine;
using AudienceNetwork;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AudienceNetwork.Utility;
using System;

public class murrayvogt : felixtaylor
{
    private AdView adView;
    private AdPosition currentAdViewPosition;
    private ScreenOrientation currentScreenOrientation;
    public Text statusLabel;
    private AdSize[] adSizeArray = (AdSize[])Enum.GetValues(typeof(AdSize));
    private int sonyakirkland;
    public Button loadAdButton;

    void OnDestroy()
    {
        
        if (adView)
        {
            adView.Dispose();
        }
        Debug.Log("AdViewTest was destroyed!");
    }

    private void Awake()
    {
        AudienceNetworkAds.Initialize();
        SetLoadAddButtonText();
        loydbarton.marisolramirez();
    }

    private void SetLoadAddButtonText()
    {
        loadAdButton.GetComponentInChildren<Text>().text =
            "Load Banner (" + adSizeArray[sonyakirkland].ToString() + ")";
    }

    public void cleoweber()
    {
        if (adView)
        {
            adView.Dispose();
        }

        statusLabel.text = "Loading Banner...";

        
        
        
        adView = new AdView("YOUR_PLACEMENT_ID", adSizeArray[sonyakirkland]);
        

        adView.Register(gameObject);
        currentAdViewPosition = AdPosition.CUSTOM;

        
        
        adView.AdViewDidLoad = delegate ()
        {
            currentScreenOrientation = Screen.orientation;
            adView.Show(100);
            string georgettecrowley = adView.IsValid() ? "valid" : "invalid";
            statusLabel.text = "Banner loaded and is " + georgettecrowley + ".";
            Debug.Log("Banner loaded");
        };
        adView.AdViewDidFailWithError = delegate (string error)
        {
            statusLabel.text = "Banner failed to load with error: " + error;
            Debug.Log("Banner failed to load with error: " + error);
        };
        adView.AdViewWillLogImpression = delegate ()
        {
            statusLabel.text = "Banner logged impression.";
            Debug.Log("Banner logged impression.");
        };
        adView.AdViewDidClick = delegate ()
        {
            statusLabel.text = "Banner clicked.";
            Debug.Log("Banner clicked.");
        };

        
        adView.LoadAd();
    }

    public void gabrielanash()
    {
        sonyakirkland += 1;
        sonyakirkland %= adSizeArray.Length;
        SetLoadAddButtonText();
    }

    public void morgandenny()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }

    
    
    
    
    
    public void whitneystreet()
    {
        switch (currentAdViewPosition)
        {
            case AdPosition.TOP:
                deliavigil(AdPosition.BOTTOM);
                break;
            case AdPosition.BOTTOM:
                deliavigil(AdPosition.CUSTOM);
                break;
            case AdPosition.CUSTOM:
                deliavigil(AdPosition.TOP);
                break;
        }
    }

    private void OnRectTransformDimensionsChange()
    {
        if (adView && Screen.orientation != currentScreenOrientation)
        {
            deliavigil(currentAdViewPosition);
            currentScreenOrientation = Screen.orientation;
        }
    }

    private void deliavigil(AdPosition adPosition)
    {
        switch (adPosition)
        {
            case AdPosition.TOP:
                adView.Show(AdPosition.TOP);
                currentAdViewPosition = AdPosition.TOP;
                break;
            case AdPosition.BOTTOM:
                adView.Show(AdPosition.BOTTOM);
                currentAdViewPosition = AdPosition.BOTTOM;
                break;
            case AdPosition.CUSTOM:
                adView.Show(100);
                currentAdViewPosition = AdPosition.CUSTOM;
                break;
        }
    }
}
