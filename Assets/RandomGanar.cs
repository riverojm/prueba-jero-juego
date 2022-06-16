using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGanar : MonoBehaviour
{       
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(Random.Range(25, 5), Random.Range(2, 30), Random.Range(20, -20));
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
}
