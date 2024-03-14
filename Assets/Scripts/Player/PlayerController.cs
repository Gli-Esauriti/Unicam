using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1000000;

    private Rigidbody2D rb;
    private Animator animator;
    private static readonly int CamminaDestra = Animator.StringToHash("CamminaDestra");
    private static readonly int CamminaSinistra = Animator.StringToHash("CamminaSinistra");
    private static readonly int CamminaSu = Animator.StringToHash("CamminaSu");
    private static readonly int CamminaGiu = Animator.StringToHash("CamminaGiu");
    private static readonly int IdleGiu = Animator.StringToHash("Idle");

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        if (inputX > 0.1)
        {
            animator.SetBool(CamminaDestra, true);
            animator.SetBool(CamminaSinistra, false);
            animator.SetBool(CamminaGiu, false);
            animator.SetBool(CamminaSu, false);
            animator.SetBool(IdleGiu, false);
        }
        else if (inputX < 0)
        {
            animator.SetBool(CamminaSinistra, true);
            animator.SetBool(CamminaDestra, false);
            animator.SetBool(CamminaGiu, false);
            animator.SetBool(CamminaSu, false);
            animator.SetBool(IdleGiu, false);
        }
        else if (inputY > 0.1)
        {
            animator.SetBool(CamminaSu, true);
            animator.SetBool(CamminaGiu, false);
            animator.SetBool(CamminaDestra, false);
            animator.SetBool(CamminaSinistra, false);
            animator.SetBool(IdleGiu, false);
        }
        else if (inputY < 0)
        {
            animator.SetBool(CamminaGiu, true);
            animator.SetBool(CamminaSu, false);
            animator.SetBool(CamminaDestra, false);
            animator.SetBool(CamminaSinistra, false);
            animator.SetBool(IdleGiu, false);
        }
        else
        {
            animator.SetBool(CamminaDestra, false);
            animator.SetBool(CamminaSinistra, false);
            animator.SetBool(CamminaGiu, false);
            animator.SetBool(CamminaSu, false);
            animator.SetBool(IdleGiu, true);
        }

        Vector2 movement = new Vector2(inputX, inputY);

        rb.velocity = movement * speed;
    }
}
