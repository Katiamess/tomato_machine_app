using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_92_Off : MonoBehaviour
{
    public GameObject tag_92;

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
        tag_92.SetActive(false);
    }
}
