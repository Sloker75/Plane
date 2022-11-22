using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speedToMove;
    [SerializeField] private float _torqueForce;

    private float _horizontalInput;
    private float _verticalInput;

    private void Update()
    {
        _rigidbody.velocity = transform.forward * _speedToMove * Time.deltaTime;

        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody.AddTorque(0f, 0f,-1 * _horizontalInput * _torqueForce);
        _rigidbody.AddTorque(_verticalInput * _torqueForce, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Coin coin))
            Destroy(coin.gameObject);
        else if(collision.gameObject.TryGetComponent(out Bomb bomb))
            Destroy(coin.gameObject);
    }
}
