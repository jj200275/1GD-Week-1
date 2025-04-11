using UnityEngine;

public class penguinmovement : MonoBehaviour
{
    public double velocity = 5;
    public Rigidbody2D me;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        me.linearVelocityX = -(float)velocity;
        //me.AddForce(new Vector2(-(float)velocity, 0));

        if (transform.position.x < -10)
        {
            transform.position = new Vector3(9,4);
            //me.linearVelocityX = 0;
        }
    }
}
