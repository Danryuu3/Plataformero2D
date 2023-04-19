using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;
    private int vidas = 3;
    

    public Animator player;
    public Animator vida1;
    public Animator vida2;
    public Animator vida3;

    private Vector3 initialPosition;
    private Rigidbody2D rb;
    private bool isGround = false;
    private GameObject spawn;
    


    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

       // if (Input.GetAxis("Horizontal") != 0)
       // {
       //     PlayerTop.SetBool("Moving", true);
       // }
       // else
       // {
       //     PlayerTop.SetBool("Moving", false);
       // }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveForce, rb.velocity.y);

        if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.transform.localScale = new Vector3(-1f, 1f, 1);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            isGround = false;
            player.SetBool("isJump", true);
            Debug.Log("Is Jumping");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(2);
            Spawn();
        }

        if (collision.gameObject.CompareTag("Victory"))
        {
            SceneManager.LoadScene(4);
        }


        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            player.SetBool("isJump", false);
            Debug.Log("Grounded");
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.SetBool("Damage", false);
            if (vidas == 3)
            {
                vida3.SetBool("Murio3", true);
                StartCoroutine("Quieto");
                StartCoroutine("Aguantame3");
                StartCoroutine("Pascua");

            }
            else if (vidas == 2)
            {
                vida2.SetBool("Murio2", true);
                StartCoroutine("Quieto");
                StartCoroutine("Aguantame2");
                StartCoroutine("Pascua");
            }
            else if (vidas == 1)
            {
                vida1.SetBool("Murio1", true);
                StartCoroutine("Quieto");
                StartCoroutine("Aguantame1");
                StartCoroutine("Pascua");
            }
            else
            {
                player.SetBool("Respawn", false);
                StartCoroutine("Quieto");
                StartCoroutine("GameOver");
                
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.SetBool("Damage", false);
            if (vidas == 3)
            {
                vida3.SetBool("Murio3", true);
                StartCoroutine("Quieto");
                StartCoroutine("Aguantame3");
                StartCoroutine("Pascua");

            }
            else if (vidas == 2)
            {
                vida2.SetBool("Murio2", true);
                StartCoroutine("Quieto");
                StartCoroutine("Aguantame2");
                StartCoroutine("Pascua");
            }
            else if (vidas == 1)
            {
                vida1.SetBool("Murio1", true);
                StartCoroutine("Quieto");
                StartCoroutine("Aguantame1");
                StartCoroutine("Pascua");
            }
            else
            {
                player.SetBool("Respawn", false);
                StartCoroutine("Quieto");
                StartCoroutine("GameOver");

            }
        }
    }
    public void Respawn()
    {
        gameObject.transform.position = initialPosition;
        player.SetBool("Quieto", true);
        player.SetBool("Damage", true);
        player.SetBool("Respawn", true);
        
    }

    public void Spawn()
    {
        gameObject.transform.position = new Vector3(-6f,0f,0f);
    }

   

   

    IEnumerator Quieto()
    {
        yield return new WaitForSeconds(0.1f);
    
        player.SetBool("Quieto", false);
    }

    IEnumerator Pascua()
    {
        yield return new WaitForSeconds(1f);
        Respawn();
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(3);
    }

    IEnumerator Aguantame3()
    {
        yield return new WaitForSeconds(1.5f);
        vidas = 2;
    }

    IEnumerator Aguantame2()
    {
        yield return new WaitForSeconds(1.5f);
        vidas = 1;
    }

    IEnumerator Aguantame1()
    {
        yield return new WaitForSeconds(1.5f);
        vidas = 0;
    }






}
