using UnityEngine;

public class taylorfrye : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static taylorfrye USE;

    private AudioSource avasewell;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            avasewell = transform.GetChild(0).GetComponent<AudioSource>();

            katrinamadrid();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void katrinamadrid()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void michellelim()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void lizaayers(AudioClip clip)
    {
        avasewell.PlayOneShot(clip);
    }
}
