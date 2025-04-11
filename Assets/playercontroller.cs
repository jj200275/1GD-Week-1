using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    private float movementX;
    private float movementY;
    [SerializeField] private float speed = 3;
    [SerializeField] private float jumppower = 5;
    private Rigidbody2D rb;
    private float myvel;
    public bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(rb.linearVelocityX < 0) transform.localScale = new Vector2(-1, 1);
        if(rb.linearVelocityX > 0) transform.localScale = new Vector2(1, 1);
        Move();
        rb.linearVelocityX = myvel;
    }


    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        movementX = v.x;
        movementY = v.y;
    }

    void Move()
    {
        if (movementX < 0) myvel = -speed;
        else if (movementX > 0) myvel = speed;
        else myvel = 0;
        if (movementY > 0 && grounded) Jump();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

    void Jump()
    {
        rb.linearVelocityY = jumppower;
        grounded = false;
    }
}
