using UnityEngine;

public class SceneStopper : MonoBehaviour
{
    [SerializeField]
    private GameObject _restartbutton;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _restartbutton.SetActive(true);
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}
