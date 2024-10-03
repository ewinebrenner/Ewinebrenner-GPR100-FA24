using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float jumpSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hello");
           // rb.AddForce(new Vector2(0, jumpSpeed),ForceMode2D.Impulse);
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
}
