using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;

    private float speed = 8f;

    private float jump = 16f;

    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Transform groundCheck;

    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private bool IsGround() => Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
}
