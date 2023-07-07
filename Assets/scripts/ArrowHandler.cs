 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowHandler : MonoBehaviour

{
    public GameObject arrow;
    public GameObject VidHotIdle;
    public GameObject VidHotRotate;
    public GameObject VidBox;
    public GameObject VidTomatoIdle;
    
    public GameObject VidTomatoIn;

    
    public GameObject audio_rotate;
    public GameObject audio_box;
    public GameObject audio_tomidle;
    public GameObject audio_tomin; 

    public GameObject tag_kinisi;
    public GameObject tag_box;
    public GameObject tag_swlinas;
    public GameObject tag_92;
    

  

    private Button arrowButton;

    private Button GetArrowButton()
    {
        if (arrowButton == null)
            arrowButton = arrow.GetComponent<Button>();

        return arrowButton;
    }

    private void Count()
    {
        tag_box.SetActive(true);
        arrow.SetActive(true);
    }

    private void Count92()
    {
        tag_92.SetActive(true);
        
    }

    private void Count92off()
    {
        tag_92.SetActive(false);

    }

    void OnEnable()
    {  
        GetArrowButton().onClick.AddListener(OnClick);
        GetArrowButton().interactable = true;
    }

    void OnDisable()
    {
        GetArrowButton().onClick.RemoveListener(OnClick);
        GetArrowButton().interactable = false;
    }

    void OnClick()
    {
        if (VidHotIdle.activeInHierarchy == true && VidHotRotate.activeInHierarchy == false)
        {
            Invoke("Count", 3.0f);

            VidHotRotate.SetActive(true);
            audio_rotate.SetActive(true);
            VidHotIdle.SetActive(false);
            

            tag_kinisi.SetActive(false);
            arrow.SetActive(false);
           
           



        }
        else if (VidHotRotate.activeInHierarchy == true &&  VidBox.activeInHierarchy == false)
        {
            
            VidBox.SetActive(true);
            audio_box.SetActive(true);
            VidHotRotate.SetActive(false);
            audio_rotate.SetActive(false);
            tag_box.SetActive(false);

            

        }



        else if (VidTomatoIdle.activeInHierarchy == true)

        {
            

            VidTomatoIdle.SetActive(false);
            VidTomatoIn.SetActive(true);

            audio_tomin.SetActive(true);
            audio_tomidle.SetActive(false);

            tag_swlinas.SetActive(false);
            arrow.SetActive(false);

            Invoke("Count92", 6.94f);
            Invoke("Count92off", 12.0f);
        }
    }
}
