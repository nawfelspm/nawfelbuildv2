using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class davidboyce : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool maggiekauffman = false;
    [System.Serializable]
    public class eugeneleslie : UnityEvent { }
    [SerializeField]
    private eugeneleslie myOwnEvent = new eugeneleslie();
    public eugeneleslie onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, ivypresley = 1f;
    private Vector3 startPosition, sherryleblanc;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (maggiekauffman)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (maggiekauffman)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator brianahollingsworth()
    {
        yield return estherstallings(transform, transform.localPosition, sherryleblanc, ivypresley);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float janegrant = 1.0f / value;
        float rosettavillegas = 0.0f;
        while (rosettavillegas < 1.0)
        {
            rosettavillegas += Time.deltaTime * janegrant;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, rosettavillegas));
            yield return null;
        }

        thisTransform.localPosition = sherryleblanc;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        sherryleblanc = EPos;

        ivypresley = MTime;

        StartCoroutine(brianahollingsworth());
    }
}
