using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VrisiHandler : MonoBehaviour
{
    public GameObject vrisi;
    public GameObject VidVrisiFlow;
    public GameObject VidVrisiIdle;
    public GameObject CanvasFin;
    public GameObject audiofin;
    public GameObject audio_can;
    public GameObject tag_vrisi;

    public GameObject audio_vrisidle;
    public GameObject audio_vrisiflow;


    private Button vrisiButton;

    private Button GetVrisiButton()
    {
        if (vrisiButton == null)
            vrisiButton = vrisi.GetComponent<Button>();
        return vrisiButton;
    }

    private void Count()
    {

        CanvasFin.SetActive(true);
        audiofin.SetActive(true);
        audio_can.SetActive(false);

    }

    void OnEnable()
    {
        GetVrisiButton().onClick.AddListener(OnClick);
        GetVrisiButton().interactable = true;
    }

    void OnDisable()
    {
        GetVrisiButton().onClick.RemoveListener(OnClick);
        GetVrisiButton().interactable = false;
    }


    void OnClick()
    {
        GetVrisiButton().interactable = false;
        
        audio_can.SetActive(true);
        VidVrisiFlow.SetActive(true);
        audio_vrisiflow.SetActive(true);
        VidVrisiIdle.SetActive(false);
        audio_vrisidle.SetActive(false);

        tag_vrisi.SetActive(false);
        Invoke("Count", 10.0f);
    }



    public void OnAnimEnded()
    {
        vrisi.SetActive(false); // triggers OnDisable above
    }

}
