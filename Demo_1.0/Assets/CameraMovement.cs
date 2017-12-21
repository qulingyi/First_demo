using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
    private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
    private bool isRotating;    // Is the camera being rotated
    private bool isMoving;     // Is the camera being moved
    public float speed = 10.0f; //Speed of camera moving when mouse left click holding 

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
        //Get the left side button
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
        }
        // Disable movements on button release
        if (!Input.GetMouseButton(0))
        {
            isMoving = false;
        }
        //Move along X and Y axis
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

        if(Input.GetAxis("Mouse ScrollWheel")>0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - .2f,
                                            transform.position.z + .2f);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + .2f,
                                            transform.position.z - 2f);
        }

    }

 }
