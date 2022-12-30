using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{

    public bool right;
    Rigidbody2D m_Rigidbody;
   public float m_Speed;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
    }

    // Update is called once per frame
    void Update()
    {
        if (right == true)
        {
            m_Rigidbody.velocity = transform.right * m_Speed;

        }
        else
        {
            m_Rigidbody.velocity = transform.right * -m_Speed;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.name == "Ters")
        {
            right = !right;
        }
    }
}
