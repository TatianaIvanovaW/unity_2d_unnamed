using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static tags;
public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float catSpeedX = 0.3f;
    public bool inAir = false;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float runAmount = Input.GetAxis("Horizontal") * catSpeedX;
        transform.Translate(runAmount, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            Jump();
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
        {
            if (other.gameObject.tag != tags.pumpkin)
            {
            inAir = false;
            }
        } 
    
    void OnCollisionExit2D(Collision2D other) 
        {
            if (other.gameObject.tag != tags.pumpkin)
            {
            inAir = true;
            }

        }

    private void Jump()
    {
        float jumpAmount = 16;
        float gravityScale = 5;
        float fallingGravityScale = 10;
        rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }
}
