using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField, Range(0,20)] private float _moveSpeed = 5;
    [SerializeField, Range(0,20)] private float _jumpForce = 10;

    [Header("Components")]

    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private bool _lookRight = true;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetAxis("Horizontal") == 1)
        {
            _rigidbody.velocity = new Vector2(_moveSpeed, _rigidbody.velocity.y);
            _lookRight = true;
            
        }
        if (Input.GetAxis("Horizontal") == -1)
        {
            _rigidbody.velocity = new Vector2(-_moveSpeed, _rigidbody.velocity.y);
            _lookRight = false;

        }
        CheckFlip();
    }

    public void Jump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpForce);
    }
    private void CheckFlip()
    {
        
    if (_lookRight == false)
        {
            transform.localScale = new Vector2(-0.166f, transform.localScale.y);
        }
    if (_lookRight == true)
        {
            transform.localScale = new Vector2(0.166f, transform.localScale.y);
        }
    }
}
