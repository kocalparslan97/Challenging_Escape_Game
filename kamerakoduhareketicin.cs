using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakoduhareketicin : MonoBehaviour {

    // Use this for initialization
    float rot = 0;
  public  float hassalik;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // transform.Rotate(Input.GetAxis("Mouse Y")*-1, 0, 0); kamerayı y yonunde 360 derece dondurur. 

        rot += Input.GetAxis("Mouse Y")*-1*hassalik;
        rot=Mathf.Clamp(rot, -75, 75);
       // Debug.Log(rot);
        transform.eulerAngles = new Vector3(rot, transform.eulerAngles.y, 0);
    }
}
