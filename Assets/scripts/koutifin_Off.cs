using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koutifin_Off : MonoBehaviour
{
    
    public GameObject koutivid;
    public GameObject audiofin; 
    public GameObject CanvasStart;
    public GameObject audiokoutiStart;
    public GameObject CanvasFin;
    public GameObject VidClosed;
    public GameObject VidVrisiFlow;
    public GameObject AudVrisiFlow;
    public GameObject VrisiIcon;
    public GameObject ValveIcon;
    public GameObject ValveTag;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnAnimEnded()
    {

        koutivid.SetActive(false);
        
        audiofin.SetActive(false);
        CanvasStart.SetActive(true);
        CanvasFin.SetActive(false);
        audiokoutiStart.SetActive(true);
        VidClosed.SetActive(true);
        VidVrisiFlow.SetActive(false);
        AudVrisiFlow.SetActive(false);
        VrisiIcon.SetActive(false);
        ValveIcon.SetActive(true);
        ValveTag.SetActive(true);
    }
}
