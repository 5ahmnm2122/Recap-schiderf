using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zielscheibe : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log("Target Clicked");
        Destroy(this.gameObject);
    }
}
