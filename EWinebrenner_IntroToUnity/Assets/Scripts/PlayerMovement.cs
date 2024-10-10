using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float jumpSpeed = 100.0f;
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private LayerMask groundLayer;
    bool onGround;
    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void OnDrawGizmos()
    {
        //Ternary operator ?
        Gizmos.color = onGround ? Color.blue : Color.red;

        //Same as...
        //if (onGround)
        //{
        //    Gizmos.color = Color.blue;
        //}
        //else
        //{
        //    Gizmos.color = Color.red;
        //}
        Gizmos.DrawWireSphere(transform.position, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D groundCol = Physics2D.OverlapCircle(transform.position, 0.2f, groundLayer);
        onGround = groundCol != null;
       // Debug.Log(onGround);

        //Get -1 to 1
        float xInput = Input.GetAxisRaw("Horizontal");
        //Horizontal speed
        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);

        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
           // rb.AddForce(new Vector2(0, jumpSpeed),ForceMode2D.Impulse);
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
}
