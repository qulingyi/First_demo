using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class URL : MonoBehaviour {
    public GameObject s;
    
  
   
    // Use this for initialization
    void Start ()
    {
        //string q = Application.absoluteURL;
        string q = "size=5";
            //int t = q.Length - 1;
        string[] stringSeparators = new string[] { "size=" };
        //string m = q.Split("size="[0])[1];
        string[] m = q.Split(stringSeparators, StringSplitOptions.None);
        int si = int.Parse(m[1])-1;
           s.transform.localScale += new Vector3(si, si, si);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
 

}
