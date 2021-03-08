using UnityEngine;

public class CometPusher2 : MonoBehaviour
{
    private void Start()
    {
        Rigidbody2D ribd = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(0, -0.15f);
        ribd.AddForce(direction, ForceMode2D.Impulse);
    }
}
