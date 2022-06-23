using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class brycecuellar : MonoBehaviour
{

    int blancathorne;
    AsyncOperation progress = null;
    Image progressBar;
    float hilarycrabtree = 0;
    string pamhale;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + terranceball.gwenholloway.ToString());
        if (terranceball.gwenholloway)
        {
            pamhale = "NotiSc";
        }
        else
        {
            pamhale = thomascope.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            blancathorne = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            blancathorne = 0;
        }
        blancathorne++;
        PlayerPrefs.SetInt("appStartedNumber", blancathorne);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (hilarycrabtree < 5)
        {
            hilarycrabtree += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + terranceball.gwenholloway.ToString());
        if (terranceball.gwenholloway)
        {
            pamhale = "NotiSc";
        }
        else
        {
            pamhale = thomascope.Homenamescene;
        }
        SceneManager.LoadScene(pamhale);
    }

}
