using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jonhartley : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool eddiemason = false;




    void Update()
    {
        if (irenepope.Length > 0 && !eddiemason)
        {
            eddiemason = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + inezcrocker);

            if (inezcrocker.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(leonordarby(jeannieescobar, image));
                return;
            }
            else if (matildahand.Length > 0)
            {
                thomascope.Instance.ShowApplovin();
            }
            else if (eleanorjones.Length > 0)
            {
                thomascope.Instance.ShowInterstitialfb();
            }
            else if (billieambrose.Length > 0)
            {
                thomascope.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(thomascope.Homenamescene);

        }
    }

    string eleanorjones = "";
    string jeannieescobar = "";
    string matildahand = "";
    string billieambrose = "";
    string inezcrocker = "";
    string irenepope = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(thomascope.firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          if (task.IsFaulted)
          {
              UnityEngine.Debug.Log("XReceived data error ");

          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              eleanorjones = snapshot.Child("NotiFbads").Value.ToString();
              jeannieescobar = snapshot.Child("NotiImg").Value.ToString();
              matildahand = snapshot.Child("NotiLovin").Value.ToString();
              billieambrose = snapshot.Child("NotiUnityads").Value.ToString();
              billieambrose = snapshot.Child("NotiUnityads").Value.ToString();
              inezcrocker = snapshot.Child("NotiUrl").Value.ToString();
              irenepope = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived jeannieescobar " + jeannieescobar);
              UnityEngine.Debug.Log("XReceived inezcrocker " + inezcrocker);

          }
      });

    }

    public void lulamartinez()
    {
        Application.OpenURL(inezcrocker);

    }

    UnityWebRequest www;
    IEnumerator leonordarby(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
