using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler
{
    [SerializeField] int moveRange = 100;
    [SerializeField] Vector3 startPos;
    public Vector3 inputDirection;
    [SerializeField] Image bgImage;
    private Image thisImage;

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos = Vector3.zero;
        int delta = (int)(eventData.position.x - startPos.x);
        delta = Mathf.Clamp(delta, -moveRange, moveRange);
        newPos.x = delta;

        int delta2 = (int)(eventData.position.y - startPos.y);
        delta2 = Mathf.Clamp(delta2, -moveRange, moveRange);
        newPos.y = delta2;

        transform.position = new Vector3(startPos.x + newPos.x, startPos.y + newPos.y, startPos.z + newPos.z);
        UpdateVirtualAxis(new Vector3(newPos.x * 1f / moveRange, 0, newPos.y * 1f / moveRange));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position = startPos;
        UpdateVirtualAxis(new Vector3(0, 0, 0));
    }

    private void Start()
    {
        thisImage = GetComponent<Image>();
        startPos = transform.position;
    }


    void UpdateVirtualAxis(Vector3 value)
    {
        var delta = startPos - value;
        delta.y = -delta.y;
        delta /= moveRange;

        inputDirection = value;
    }
}
