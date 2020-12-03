using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Olme : MonoBehaviour {
    
    public float yukseklik;
    public float zaman;
    public float maxzaman;
    public Text Kalanzamanyazi;
   
	// Use this for initialization
	void Start () {
        zaman = maxzaman;
	}
	
	// Update is called once per frame
	void Update () {
        Kalanzamanyazi.text = "TIME: " + (int)zaman;
       
        zaman -= Time.deltaTime;
        if(zaman <= 0)
        {
            Application.LoadLevel("AnaMenu");
        }
        if (transform.position.y <= yukseklik)
        {
            Application.LoadLevel("AnaMenu");
            zaman = maxzaman;
            Debug.Log("bolum yuklendi");
        }
	}
}
