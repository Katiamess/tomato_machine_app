using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnivRestart : MonoBehaviour
{
    public GameObject VidClosed;
    public GameObject VidHotIdle;
    public GameObject VidHotRotate;
    public GameObject VidTomatoIdle;
    public GameObject VidVrisiIdle;


    
    
    public GameObject AudHotRotate;
    public GameObject AudTomatoIdle;
    public GameObject AudVrisiIdle;

   
    public GameObject valve_on;
    public GameObject vrisi_off;
    public GameObject tag_valve_on;
    public GameObject arrow_off;

    public GameObject tagvrisi_off;
    public GameObject tagbox_off;
    public GameObject tagswlinas_off;
    public GameObject tagkinisi_off;


    public GameObject canvasstart_on;




    public float timer = 0;

    void Update()
    {

        if (!Input.anyKey)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }

        //max seconds inactive before "go to initial screen" is activated
        if (timer >= (55)) {
            

            arrow_off.SetActive(false);

            VidClosed.SetActive(true);
            VidHotIdle.SetActive(false);
            VidHotRotate.SetActive(false);
            VidTomatoIdle.SetActive(false);
            VidVrisiIdle.SetActive(false);


            AudHotRotate.SetActive(false);
            AudTomatoIdle.SetActive(false);
            AudVrisiIdle.SetActive(false);


            tagvrisi_off.SetActive(false);
            tagbox_off.SetActive(false);
            tagswlinas_off.SetActive(false);
            tagkinisi_off.SetActive(false);

           

            
            valve_on.SetActive(true);
            vrisi_off.SetActive(false);
            tag_valve_on.SetActive(true);

            //initial screen
            canvasstart_on.SetActive(true);

            



            timer = 0;
        }

    }







}
