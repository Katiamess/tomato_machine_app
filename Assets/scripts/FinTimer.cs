using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinTimer : MonoBehaviour
{

	public GameObject machineclosed_enable;
	public GameObject valve_enable;
    public GameObject tagvalve_enable;
    public GameObject sittingman_enable;
	public GameObject liqTap1_disable;
	public GameObject liqTap2_disable;
	public GameObject liqMain_disable;
	public GameObject box_disable;
	public GameObject objTomato_disable;
	public GameObject machineopen_disable;
	public GameObject sittingman_fill_dis;
    public GameObject audiocan_dis;
    public GameObject SteamParts_dis;
    public GameObject vrisi_red_dis;
    public GameObject axonhotAnimToDisable;
	public GameObject helixhotAnimToDisable;

    void Start()
	{

	}

	void OnEnable()
	{ 
		Invoke("Count",12.0f);
	}

	private void Count()
	{

        machineclosed_enable.SetActive(true);
        valve_enable.SetActive(true);
        tagvalve_enable.SetActive(true);
        sittingman_enable.SetActive(true);
        liqTap1_disable.SetActive(false);
        liqTap2_disable.SetActive(false);
        liqMain_disable.SetActive(false);
        box_disable.SetActive(false);
        objTomato_disable.SetActive(false);
        machineopen_disable.SetActive(false);
        sittingman_fill_dis.SetActive(false);
        audiocan_dis.SetActive(false);
        SteamParts_dis.SetActive(false);
        vrisi_red_dis.SetActive(false);
        axonhotAnimToDisable.GetComponent<Animator>().enabled = false;
        helixhotAnimToDisable.GetComponent<Animator>().enabled = false;


    }


}


