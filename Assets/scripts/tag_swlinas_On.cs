using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_swlinas_On : MonoBehaviour
{
    public GameObject tag_swlinas;

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
        tag_swlinas.SetActive(true);
    }
}
