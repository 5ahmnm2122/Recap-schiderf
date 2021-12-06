using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static int Score = 0;
    public GameObject Gewonnen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Score == 10)
        {
            Gewonnen.SetActive(true);
        }
    }
}
