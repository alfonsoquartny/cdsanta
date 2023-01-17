using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Deadeye : MonoBehaviour
{

    public bool DeadEye;
    public bool canDeadEye;

     Vector3 cursorVec;

    public GameObject cursor;

    public bool canDeployX;

    public GameObject deadeyeScreen;
    public GameObject x;
    void Start()
    {
        canDeadEye = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 testvec = new Vector3(cursorVec.x, cursorVec.y, 0);

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        cursorVec = Camera.main.ScreenToWorldPoint(mousePos);
        if (canDeadEye == true&&Input.GetKeyDown(KeyCode.Mouse2))
        {
            DeadEye=!DeadEye;
        }


        if (DeadEye == true)
        {
            deadeyeScreen.SetActive(true);
            if (canDeployX == true)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    var xPrefab= Instantiate(x, testvec, Quaternion.identity);

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        Destroy(xPrefab);
                        canDeadEye = false;

                        DeadEye = false;
                    }
                }
            }
        }
        else
        {
            deadeyeScreen.SetActive(false);
        }


      

        cursor.transform.position = testvec;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
