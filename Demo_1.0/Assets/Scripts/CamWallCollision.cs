using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamWallCollision : MonoBehaviour
{
    public GameObject colli;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("wall"))  // Detect the collision is happening
        {
            //Debug.Log("Hit");
            //colli.GetComponent<CameraMovement>().speed = 0.0f;
            transform.position += new Vector3(0.0f, 0.0f, 0.0f);
        }
       
    }
}
