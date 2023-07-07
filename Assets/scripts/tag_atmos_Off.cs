using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_atmos_Off : MonoBehaviour
{
    public GameObject tag_atmos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnAnimEndTag()
    {
        tag_atmos.SetActive(false);
       
    }
}
