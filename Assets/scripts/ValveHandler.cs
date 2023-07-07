using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValveHandler : MonoBehaviour
{
    public GameObject valve;
    public GameObject closed_sheet;
    public GameObject steam_sheet;

    public GameObject audiovalve;
    public GameObject audiointro;
    public GameObject audiokouti_click;
    public GameObject audio_steam;

    public GameObject TagSteam120;
    public GameObject TagSteam70;
    public GameObject TagValve;


    private Button valveButton;

    private Button GetValveButton()
    {
        if (valveButton == null)
            valveButton = valve.GetComponent<Button>();
        return valveButton;
    }

    private void Count()
    {
        TagSteam70.SetActive(true);
        TagSteam120.SetActive(false);

    }

    private void Count70()
    {
        TagSteam70.SetActive(false);
        

    }

    void OnEnable() 
    {
        GetValveButton().onClick.AddListener(OnClick);
        GetValveButton().interactable = true;
        
    }

    void OnDisable()
    {
        GetValveButton().onClick.RemoveListener(OnClick);
    }

    void OnClick()
    {
        GetValveButton().interactable = false;


        audiovalve.SetActive(true);
        steam_sheet.SetActive(true);
        closed_sheet.SetActive(false);
        
        TagSteam120.SetActive(true);
        TagValve.SetActive(false);

        audio_steam.SetActive(true);
        audiokouti_click.SetActive(false);
        audiointro.SetActive(false);

        Invoke("Count", 8.0f);
        Invoke("Count70", 12.63f);

    }

    public void OnAnimEnded()
    {
        valve.SetActive(false); // triggers OnDisable above
        
        audiovalve.SetActive(false);
    }
}
