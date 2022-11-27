using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
            coin.Die();
        else if (collision.gameObject.TryGetComponent(out Bomb bomb))
            Destroy(coin.gameObject);
    }
}
