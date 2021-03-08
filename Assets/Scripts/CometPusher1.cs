using UnityEngine;

public class CometPusher1 : MonoBehaviour
{
    private void Start()
    {
        Rigidbody2D ribd = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(0, -0.03f);
        ribd.AddForce(direction, ForceMode2D.Impulse);
    }
}
