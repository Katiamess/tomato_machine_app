using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonENGhandler : MonoBehaviour
{   
    public GameObject langENG;
    public GameObject tag_valve;
    public GameObject tag_atmos;
    public GameObject tag_atmos120;
    public GameObject tag_kinisi;
    public GameObject tag_box;
    public GameObject tag_swlinas;
    public GameObject tag_92;
    public GameObject tag_vrisi;
    public GameObject CanvasSTART;
    public GameObject Audioclick;
    public GameObject kouti_fin_ENG;
    public GameObject vidmachineENG;
    public GameObject imgmachineENG;

   


    //game tags with descriptive text in English

    private Button langENGButton;

    private Sprite tag_valve_ENG;
    private Sprite tag_atmos_ENG;
    private Sprite tag_atmos120_ENG;
    private Sprite tag_kinisi_ENG;
    private Sprite tag_box_ENG;
    private Sprite tag_92_ENG;
    private Sprite tag_vrisi_ENG;
    private Sprite tag_swlinas_ENG;




    private Button GetlangENGButton()
    {
        if (langENGButton == null)
        langENGButton = langENG.GetComponent<Button>();
        return langENGButton;
    }

    private void Count()
    {
        
        vidmachineENG.SetActive(false);
        imgmachineENG.SetActive(false);

    }



    //choose language function
    void OnEnable()
    {
        GetlangENGButton().onClick.AddListener(OnClick);
        GetlangENGButton().interactable = true;
        tag_valve_ENG = Resources.Load<Sprite>("VANA_eng");
        tag_atmos_ENG = Resources.Load<Sprite>("expl_atmos_eng");
        tag_atmos120_ENG = Resources.Load<Sprite>("expl_atmos_120_eng");
        tag_kinisi_ENG = Resources.Load<Sprite>("KINISI_eng");
        tag_box_ENG = Resources.Load<Sprite>("KOUTI_eng");
        tag_92_ENG = Resources.Load<Sprite>("expl_poltos_eng");
        tag_vrisi_ENG = Resources.Load<Sprite>("VRISI_eng");
        tag_swlinas_ENG = Resources.Load<Sprite>("EISAGWGI_eng");

    }

    void OnDisable()
    {
        GetlangENGButton().onClick.RemoveListener(OnClick);
        GetlangENGButton().interactable = false;
    }



    void OnClick()
    {
        CanvasSTART.SetActive(false);
        GetlangENGButton().interactable = false;

        Audioclick.SetActive(true);
        vidmachineENG.SetActive(true);
        imgmachineENG.SetActive(true);
        kouti_fin_ENG.SetActive(true);
       
        Invoke("Count", 19.0f);

        tag_valve.GetComponent<Image>().sprite = tag_valve_ENG;
        tag_atmos.GetComponent<Image>().sprite = tag_atmos_ENG;
        tag_atmos120.GetComponent<Image>().sprite = tag_atmos120_ENG;
        tag_kinisi.GetComponent<Image>().sprite = tag_kinisi_ENG;
        tag_box.GetComponent<Image>().sprite = tag_box_ENG;
        tag_92.GetComponent<Image>().sprite = tag_92_ENG;
        tag_vrisi.GetComponent<Image>().sprite = tag_vrisi_ENG;
        tag_swlinas.GetComponent<Image>().sprite = tag_swlinas_ENG;


    }



}
