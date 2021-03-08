using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    private Timer _spawntimer;
  
    private void Start()
    {
        _spawntimer = gameObject.AddComponent<Timer>();
    }

    private void Update()
    {
        if (_spawntimer.Seconds >= 1.2)
        {
            GameObject prefabcopy = Instantiate(_prefab);
            _spawntimer.Seconds = 0;
        }
    }
}
