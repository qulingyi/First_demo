using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    //
    // VARIABLES
    //

    public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
    private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
    private bool isRotating;    // Is the camera being rotated
    private bool isMoving;
    public float speed = 10.0f;

    void Start()
    {

        mouseOrigin = transform.position;
    }

    void Update()
    {
        // Get the left mouse button
        if (Input.GetMouseButtonDown(1))
        {
            // Get mouse origin
            mouseOrigin = Input.mousePosition;
            isRotating = true;
        }
        // Disable movements on button release
        if (!Input.GetMouseButton(1))
        {
            isRotating = false;
        }
        // Rotate camera along X and Y axis
        if (isRotating)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
        }
        // Disable movements on button release
        if (!Input.GetMouseButton(0))
        {
            isMoving = false;
        }

        if (isMoving)
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }

            else if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
        }
      
    }

 }
