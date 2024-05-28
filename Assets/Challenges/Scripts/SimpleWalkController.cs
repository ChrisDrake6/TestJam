using UnityEngine;

/// <summary>
/// Simple implementaion of a characer controller
/// </summary>
public class SimpleWalkController : MonoBehaviour
{
    // Defines how fast the GO can move
    public float movementSpeed = 10;

    // Defines how fast the GO can turn
    public float turnSpeed = 90;

    // Update is called once per frame
    void Update()
    {
        // Stores inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Translate along z-axis
        transform.Translate(Vector3.back * verticalInput * movementSpeed * Time.deltaTime);

        // Are we moving
        if(verticalInput > 0) 
        {
            // calculate the angle around y-axis
            float turnAngle = turnSpeed * horizontalInput * Input.GetAxisRaw("Vertical") * Time.deltaTime;
            transform.Rotate(Vector3.up, turnAngle);
        }
    }
}
