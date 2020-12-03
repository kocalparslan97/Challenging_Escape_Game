using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaMenuBasla : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void ButtonCkick() //butona basınca ne yapacak
    {
        Application.LoadLevel("zorluKacis");
        Debug.Log("bolum yuklendi");
    }
	}

