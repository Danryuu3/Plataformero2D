using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTeDestruyas : MonoBehaviour
{
    public GameObject  Personaje;
    public Canvas interfaz;
    public GameObject camara1;
    public GameObject camara2;



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Personaje);
        DontDestroyOnLoad(interfaz);
        DontDestroyOnLoad(camara1);
        DontDestroyOnLoad(camara2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
