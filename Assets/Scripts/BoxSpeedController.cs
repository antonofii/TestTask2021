using UnityEngine;

public class BoxSpeedController : MonoBehaviour
{
    private float _speed = -2;
    private Timer _timer;
    public static BoxSpeedController Instance;

    public float Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }

    private void Start()
    {
        Instance = this;
        _timer = gameObject.AddComponent<Timer>();
    }

    private void Update()
    {
        if (_timer.Seconds >= 5)
        {
            Speed -= 1;
            _timer.Seconds = 0;
        }
    }
}
