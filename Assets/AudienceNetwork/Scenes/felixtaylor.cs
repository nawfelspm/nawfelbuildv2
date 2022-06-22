using UnityEngine;
using UnityEngine.SceneManagement;

public class felixtaylor : MonoBehaviour
{
    
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }

    public void doloresreese()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
