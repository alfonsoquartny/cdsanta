using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temas : MonoBehaviour
{
 

    public Deadeye deadeye;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("enemy"))
        {
            Debug.Log("sssssh");

            deadeye.canDeployX = true;
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Debug.Log("sssssh");

            deadeye.canDeployX = false;
        }
    }
}
