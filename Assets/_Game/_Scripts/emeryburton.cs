using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class emeryburton : MonoBehaviour
{
    
    void Start()
    {

        chelseysamuel();
    }

    
    bool terriemcdonald = false;




    void Update()
    {
        if (alfredacastro.Length > 0 && !terriemcdonald)
        {
            terriemcdonald = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + kimhouser);

            if (kimhouser.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(karalu(rosariopollard, image));
                return;
            }
            else if (maireid.Length > 0)
            {
                quentincarlson.Instance.ShowApplovin();
            }
            else if (janetmarino.Length > 0)
            {
                quentincarlson.Instance.ShowInterstitialfb();
            }
            else if (imogenebolden.Length > 0)
            {
                quentincarlson.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(quentincarlson.Homenamescene);

        }
    }

    string janetmarino = "";
    string rosariopollard = "";
    string maireid = "";
    string imogenebolden = "";
    string kimhouser = "";
    string alfredacastro = "";

    void chelseysamuel()
    {
        FirebaseDatabase.GetInstance(quentincarlson.firebaselink)
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
              janetmarino = snapshot.Child("NotiFbads").Value.ToString();
              rosariopollard = snapshot.Child("NotiImg").Value.ToString();
              maireid = snapshot.Child("NotiLovin").Value.ToString();
              imogenebolden = snapshot.Child("NotiUnityads").Value.ToString();
              imogenebolden = snapshot.Child("NotiUnityads").Value.ToString();
              kimhouser = snapshot.Child("NotiUrl").Value.ToString();
              alfredacastro = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived rosariopollard " + rosariopollard);
              UnityEngine.Debug.Log("XReceived kimhouser " + kimhouser);

          }
      });

    }

    public void roslyncotton()
    {
        Application.OpenURL(kimhouser);

    }

    UnityWebRequest www;
    IEnumerator karalu(string url, Image targetImage)
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
