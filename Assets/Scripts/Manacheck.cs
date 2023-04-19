using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manacheck : MonoBehaviour
{
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        boton.gameObject.SetActive(false);
        StartCoroutine("Aparece");
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarEscena()
    {
        SceneManager.LoadScene(1);
        
    }

    IEnumerator Aparece()
    {
        yield return new WaitForSeconds(2f);
        boton.gameObject.SetActive(true);

    }
}
