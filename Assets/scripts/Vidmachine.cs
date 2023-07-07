using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidmachine : MonoBehaviour
{

    public GameObject videomach;
    public GameObject imgmach;





    void Start()
    {

    }

    void OnEnable()
    {
        Invoke("Count", 3.0f);
    }

    private void Count()
    {

        videomach.SetActive(false);
        imgmach.SetActive(false);




    }
}


