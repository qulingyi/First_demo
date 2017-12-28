using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RoomSize : MonoBehaviour {
    public GameObject room;
    //public float scale;
    private Vector3 roomOriginal;
	// Use this for initialization
	void Start () {
        roomOriginal = room.transform.position;
        //Debug.Log(room.transform.position);

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            //room.transform.localScale *= scale/100.0f;
            
            //Debug.Log(room.transform.position);
            room.transform.localScale += new Vector3(2, 2, 2);
            room.transform.position = roomOriginal;
        }
    }
}
