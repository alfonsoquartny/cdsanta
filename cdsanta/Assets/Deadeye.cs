using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Deadeye : MonoBehaviour
{

    public bool DeadEye;
    public bool canDeadEye;

     Vector3 cursorVec;

    public GameObject cursor;
    void Start()
    {
        canDeadEye = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canDeadEye == true&&Input.GetKeyDown(KeyCode.Mouse2))
        {
            DeadEye=!DeadEye;
        }


        if (DeadEye == true)
        {
            if (cursor.gameObject.CompareTag("enemy"))
            {
                Debug.Log("ssh");
            }
        }


        Vector3 testvec = new Vector3(cursorVec.x, cursorVec.y,0);

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        cursorVec = Camera.main.ScreenToWorldPoint(mousePos);

        cursor.transform.position = testvec;

    }
}