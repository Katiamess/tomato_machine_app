using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_atmos_On : MonoBehaviour
{
    public GameObject tag_atmos120;
    public GameObject tag_atmos;
    public GameObject therm60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Count()
    {
        tag_atmos.SetActive(true);
        tag_atmos120.SetActive(false);
        therm60.SetActive(true);

    }

    public void OnAnimStartTag()
    {
        tag_atmos120.SetActive(true);
        Invoke("Count", 8.0f);
    }
}
