using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private int _coinCount;
    [SerializeField] private float _coinDistance;

    private void Start()
    {
        for (int i = 0; i < _coinCount; i++)
        {
            var coin = Instantiate(_coinPrefab, transform.position, Quaternion.identity, transform);
            coin.transform.position = new Vector3(Random.Range(-_coinDistance, _coinDistance), 
                Random.Range(-_coinDistance, _coinDistance), 
                Random.Range(-_coinDistance, _coinDistance));
        }
    }


}
