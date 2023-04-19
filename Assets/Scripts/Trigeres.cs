using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigeres : MonoBehaviour
{

    public GameObject obs;
    public GameObject sal;
    //public GameObject Mayo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            sal.GetComponent<Animator>().SetTrigger("Camina");
            obs.GetComponent<Animator>().SetTrigger("Muevete");
           
        }
    }

   // void OnTriggerStay2D(Collider2D collider)
   // {
   //     if (collider.gameObject.tag == "Player")
   //     {
   //         Mayo.GetComponent<Animator>().SetTrigger("Baja");
   //     }
   // }
   //
    
}
