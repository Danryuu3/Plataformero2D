using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject spawn;
    public float shootForce;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (count == 0)
            {
                
                if (Input.GetAxis("Horizontal") > 0)
                {
                    GameObject newBullet = Instantiate(bullet1, spawn.transform.position, Quaternion.identity);
                    newBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * shootForce);
                    count = 1;
                    StartCoroutine("EsperaBala");
                }
                else if (Input.GetAxis("Horizontal") < 0)
                {
                    GameObject newBullet2 = Instantiate(bullet2, spawn.transform.position, Quaternion.identity);
                    newBullet2.GetComponent<Rigidbody2D>().AddForce(Vector2.right * shootForce * -1);
                    count = 1;
                    StartCoroutine("EsperaBala");
                }
                else
                {
                    GameObject newBullet = Instantiate(bullet1, spawn.transform.position, Quaternion.identity);
                    newBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * shootForce);
                    count = 1;
                    StartCoroutine("EsperaBala");
                }
            }
        }
    }

    IEnumerator EsperaBala()
    {
        yield return new WaitForSeconds(0.5f);
        count = 0;
        
    }

}
