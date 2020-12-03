using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltinToplam : MonoBehaviour
{

    public int puan;
    public int skor;
    // Use this for initialization
    void Start()
    {

    }
    
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "Para")
        {
            puan += 1;

            Destroy(col.gameObject);



        }
    }
}
