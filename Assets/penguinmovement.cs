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
    void Update()
    {
        me.linearVelocityX = -(float)velocity;
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(9,4);
        }
    }
}
