using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speedX = 1f;
    [SerializeField] private float _jumpForce = 400f;

    private Rigidbody2D _rigidbody;
    private bool _isTurnedRight = true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
        
    public void Jump()
    {
        _rigidbody.AddForce(new Vector2(0, _jumpForce));
    }

    public void Move(float direction)
    {
        _rigidbody.velocity = new Vector2(_speedX * direction, _rigidbody.velocity.y);

        if ((direction > 0 && !_isTurnedRight) || (direction < 0 && _isTurnedRight))
        {
            Flip();
        }
    }

    private void Flip()
    {
        _isTurnedRight = !_isTurnedRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
