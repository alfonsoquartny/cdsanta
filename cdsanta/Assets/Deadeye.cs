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

    public List<GameObject> prefabs;
    void Start()
    {
        canDeadEye = true;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 testvec = new Vector3(cursorVec.x, cursorVec.y, 0);

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        cursorVec = Camera.main.ScreenToWorldPoint(mousePos);
        cursor.transform.position = testvec;
            
        if (canDeadEye == true&&Input.GetKeyDown(KeyCode.Mouse2))
        {
            DeadEye=!DeadEye;
        }


        if (DeadEye == true)
        {
            deadeyeScreen.SetActive(true);
            Time.timeScale = 0.3f;

            if (canDeployX == true)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    var xPrefab= Instantiate(x, testvec, Quaternion.identity);
                    prefabs.Add(xPrefab);
                   
                }
            }
        }
        if (DeadEye == false)
        {
            Time.timeScale = 1f;

            deadeyeScreen.SetActive(false);

            for (var i = 0; i < prefabs.Count; i++)
            {
                GameObject.Destroy(prefabs[i]);

            }

          // prefabs.Clear(); list array ý temizler






        }

    }






    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
