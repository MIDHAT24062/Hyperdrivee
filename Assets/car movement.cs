using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement

    void Update()
    {
        // Get input for horizontal and vertical axes
        float horizontal = Input.GetAxis("Horizontal"); // Left (-1) and Right (+1)
        float vertical = Input.GetAxis("Vertical");     // Down (-1) and Up (+1)

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Apply movement to the object
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}

