using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBControl : MonoBehaviour
{
    public GameObject VideoGO, PhotoGO;

    VirtualButtonBehaviour[] vrb;

    // Start is called before the first frame update
    void Start()
    {
        VideoGO.SetActive(false);
        PhotoGO.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for(int i=0; i<vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "VideoVB")
        {
            VideoGO.SetActive(true);
            PhotoGO.SetActive(false);
        }
        else if(vb.VirtualButtonName == "PhotoVB") {
            VideoGO.SetActive(false);
            PhotoGO.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual button does not exist");
        }
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
