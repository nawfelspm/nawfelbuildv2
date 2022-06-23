using UnityEngine;
using UnityEngine.UI;

public class cliftongood : MonoBehaviour
{
    public Camera cameraObj;
    public freddymorin coloringMenu, paintingMenu;

    [System.Serializable]
    public class freddymorin
    {
        public GameObject sydneyherrera;
        public Color color;
        public Image image;
        public Sprite joypettit;
        public Sprite jodiebarnard;
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

        paintingMenu.sydneyherrera.SetActive(isPainting);
        coloringMenu.sydneyherrera.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.joypettit : paintingMenu.jodiebarnard;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.joypettit : coloringMenu.jodiebarnard;
    }

    public void nelliehatcher()
    {
       
    }
}
