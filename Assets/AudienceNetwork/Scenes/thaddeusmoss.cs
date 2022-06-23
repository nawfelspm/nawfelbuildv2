using UnityEngine;
using UnityEngine.SceneManagement;

public class thaddeusmoss : MonoBehaviour
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

    public void kimberleebeal()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
