using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _seconds = 0;

    public float Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            _seconds = value;
        }
    }

    private void Update()
    {
        _seconds += Time.deltaTime;
    }
}
