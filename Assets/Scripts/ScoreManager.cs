using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    public int score;



    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        score = 0000;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}
