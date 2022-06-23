using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class jamiecolvin : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool lindseymcconnell = false;
    [System.Serializable]
    public class elijahlocke : UnityEvent { }
    [SerializeField]
    private elijahlocke myOwnEvent = new elijahlocke();
    public elijahlocke onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, marianeely = 1f;
    private Vector3 startPosition, cleowinkler;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (lindseymcconnell)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (lindseymcconnell)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator normabergeron()
    {
        yield return estherstallings(transform, transform.localPosition, cleowinkler, marianeely);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float vivianhuggins = 1.0f / value;
        float melisacorona = 0.0f;
        while (melisacorona < 1.0)
        {
            melisacorona += Time.deltaTime * vivianhuggins;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, melisacorona));
            yield return null;
        }

        thisTransform.localPosition = cleowinkler;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        cleowinkler = EPos;

        marianeely = MTime;

        StartCoroutine(normabergeron());
    }
}
