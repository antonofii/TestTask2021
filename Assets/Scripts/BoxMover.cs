using UnityEngine;

public class BoxMover : MonoBehaviour
{
    private void Start()
    {
        Rigidbody2D ridb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(0, BoxSpeedController.Instance.Speed);
        ridb.AddForce(direction, ForceMode2D.Impulse);
    }
}
