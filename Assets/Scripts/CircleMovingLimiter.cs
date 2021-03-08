using UnityEngine;
using UnityEngine.EventSystems;

public class CircleMovingLimiter : MonoBehaviour, IPointerDownHandler, IDragHandler
{
   private Vector3 _inputPosition;

    public void OnDrag(PointerEventData eventData)
    {
        _inputPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        _inputPosition.y = -2.3f;
        _inputPosition.z = -2;
        if (_inputPosition.x > 2)
        {
            _inputPosition.x = 2;
        }
        if (_inputPosition.x < -2)
        {
            _inputPosition.x = -2;
        }
        gameObject.transform.position = _inputPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _inputPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        _inputPosition.y = -2.3f;
        _inputPosition.z = -2;
        if (_inputPosition.x > 2)
        {
            _inputPosition.x = 2;
        }
        if (_inputPosition.x < -2)
        {
            _inputPosition.x = -2;
        }
        gameObject.transform.position = _inputPosition;
    }

}
