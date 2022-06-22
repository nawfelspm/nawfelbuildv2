using UnityEngine;
using UnityEngine.UI;

public class elliotquezada : MonoBehaviour
{
    public Camera cameraObj;
    public adolfobernstein coloringMenu, paintingMenu;

    [System.Serializable]
    public class adolfobernstein
    {
        public GameObject janellcannon;
        public Color color;
        public Image image;
        public Sprite annmariepowell;
        public Sprite marioncole;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
                OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.janellcannon.SetActive(isPainting);
        coloringMenu.janellcannon.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.annmariepowell : paintingMenu.marioncole;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.annmariepowell : coloringMenu.marioncole;
    }

    public void alisonhorner()
    {
       
    }
}
