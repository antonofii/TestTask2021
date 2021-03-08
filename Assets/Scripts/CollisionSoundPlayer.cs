using UnityEngine;

public class CollisionSoundPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioSource _sound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _sound = gameObject.GetComponent<AudioSource>();
        _sound.Play();
    }
}
