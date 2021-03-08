using UnityEngine;

public class BoxPositionSetter : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.position = new Vector2( Random.Range(-2f, 2f), 6);
    }
}
