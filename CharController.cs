using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float playerSpeed = 30f;
    private float jumpPower = 20f;
    public int directionInput;
    public bool Ground;
    public Transform groundCheck;
    private float groundRadius = 1.5f;
    public LayerMask whatIsGround;
    private float doubleJump = 2f;

    
    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(playerSpeed * directionInput, rb2d.velocity.y);

        Ground = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        
       
    }


    public void Move(int InputAxis)
    {

        directionInput = InputAxis;

    }

    public void Update(bool isJump)
    {
        
        if (Ground == true)
        {
            doubleJump = 2f;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        }
        else                                /*Двойной прыжок */
            if (doubleJump >= 2f)
        {
            doubleJump--;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);  
        }
    }




}
