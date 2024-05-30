using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    private float moveSpeed = 5f;
    private Animator animator;

    Rigidbody2D rb;
   
    float speedX, speedY;
    private bool faceRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
   
    void Update()   
    {
       
float verticalInput = Input.GetAxisRaw("Vertical");
float horizontalInput = Input.GetAxisRaw("Horizontal");

if (verticalInput != 0 || horizontalInput != 0) 
{
    animator.SetFloat("moveSpeed", 1);
}   
else 
{
    animator.SetFloat("moveSpeed", 0);
}
if ((horizontalInput > 0 && !faceRight) || (horizontalInput < 0 && faceRight))
{

    transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    faceRight = !faceRight;
}


        speedX = (Input.GetAxisRaw("Horizontal") * moveSpeed); ;
        speedY = (Input.GetAxisRaw("Vertical") * moveSpeed);
        rb.velocity = new Vector2(speedX, speedY);
    }
    
}
