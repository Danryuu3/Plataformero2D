using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public  int live = 2;
    public GameObject padre;
   
   
  
    
    // Start is called before the first frame update
    void Start()
    {
       //gameObject.GetComponent<Rigidbody2D>() 
       //scoreManager.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log(live);
            live = live - 1;
            if (live == 0)
            {
                Debug.Log(live);
                
                StartCoroutine("Espera");
                
            }            
        }
    }

    

    IEnumerator Espera()
    {
        yield return new WaitForSeconds(1f);
         
        Destroy(gameObject);
        Destroy(padre);
       
    }
}
