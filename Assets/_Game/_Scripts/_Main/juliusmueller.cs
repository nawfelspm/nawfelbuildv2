using UnityEngine;

public class juliusmueller : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static juliusmueller USE;

    private AudioSource leahmagee;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            leahmagee = transform.GetChild(0).GetComponent<AudioSource>();

            maryanneleyva();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void maryanneleyva()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void lessiehatcher()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void jaclyntemple(AudioClip clip)
    {
        leahmagee.PlayOneShot(clip);
    }
}
