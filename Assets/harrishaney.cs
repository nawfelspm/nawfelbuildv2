using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class harrishaney : MonoBehaviour
{

    int isabelclay;
    AsyncOperation progress = null;
    Image progressBar;
    float dionnebillings = 0;
    string mauramuller;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + sammyherring.desireegillespie.ToString());
        if (sammyherring.desireegillespie)
        {
            mauramuller = "NotiSc";
        }
        else
        {
            mauramuller = quentincarlson.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            isabelclay = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            isabelclay = 0;
        }
        isabelclay++;
        PlayerPrefs.SetInt("appStartedNumber", isabelclay);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (dionnebillings < 5)
        {
            dionnebillings += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + sammyherring.desireegillespie.ToString());
        if (sammyherring.desireegillespie)
        {
            mauramuller = "NotiSc";
        }
        else
        {
            mauramuller = quentincarlson.Homenamescene;
        }
        SceneManager.LoadScene(mauramuller);
    }

}
