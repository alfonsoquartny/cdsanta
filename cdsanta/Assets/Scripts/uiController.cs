using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class uiController : MonoBehaviour
{


    public TriggerControl Triggercontrol;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DevamEtButton()
    {
        Triggercontrol.bankAnimator.SetBool("stories", true);
    }

public void StoriesGeriButton()
    {
        Triggercontrol.bankAnimator.SetBool("stories", false);

    }


    public void sceneLoader(int sahne)
    {
        SceneManager.LoadScene(sahne);
    }
}

