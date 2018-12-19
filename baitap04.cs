using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

    public Transform top;
    public Transform bottom;
    public Transform left;
    public Transform right;

    Vector3 hor = new Vector3(1, 0);
    Vector3 ver = new Vector3(0, 1); 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        top.transform.Translate(-ver * Time.deltaTime);
        bottom.transform.Translate(ver * Time.deltaTime*2);
        left.transform.Translate(hor * Time.deltaTime/2);
        right.transform.Translate(-hor * Time.deltaTime/2);
	}
}
