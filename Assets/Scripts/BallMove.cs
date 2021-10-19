using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody2D _ballRigidbody;
    [SerializeField] Vector2 jumpForce;

    void Start()
    {
        _ballRigidbody = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    public void Jump()
    {
        _ballRigidbody.velocity = Vector2.zero;
        _ballRigidbody.AddForce(jumpForce, ForceMode2D.Impulse);
    }
}
