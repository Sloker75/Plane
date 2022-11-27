using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;

    public void Die()
    {
        _coinSound.Play();
        Destroy(gameObject, 0.1f);
    }
}
