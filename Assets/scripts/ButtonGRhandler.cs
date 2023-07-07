using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGRhandler : MonoBehaviour
{
    public GameObject langGR;
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
    public GameObject koutiFIN_GR;
    public GameObject vidmachineGR;
    public GameObject imgmachineGR;





    //game tags with descriptive text in Greek
    private Button langGRButton;

    private Sprite tag_valve_GR;
    private Sprite tag_atmos_GR;
    private Sprite tag_atmos120_GR;
    private Sprite tag_kinisi_GR;
    private Sprite tag_box_GR;
    private Sprite tag_92_GR;
    private Sprite tag_vrisi_GR;
    private Sprite tag_swlinas_GR;




    private Button GetlangGRButton()
    {
        if (langGRButton == null)
            langGRButton = langGR.GetComponent<Button>();
        return langGRButton;
    }

    private void Count()
    {
        
        vidmachineGR.SetActive(false);
        imgmachineGR.SetActive(false);


    }



    //choose language function
    void OnEnable()
    {
        GetlangGRButton().onClick.AddListener(OnClick);
        GetlangGRButton().interactable = true;
        tag_valve_GR = Resources.Load<Sprite>("VANA");
        tag_atmos_GR = Resources.Load<Sprite>("expl_atmos");
        tag_atmos120_GR = Resources.Load<Sprite>("expl_atmos_120");
        tag_kinisi_GR = Resources.Load<Sprite>("KINISI");
        tag_box_GR = Resources.Load<Sprite>("KOUTI");
        tag_92_GR = Resources.Load<Sprite>("expl_poltos");
        tag_vrisi_GR = Resources.Load<Sprite>("VRISI");
        tag_swlinas_GR = Resources.Load<Sprite>("EISAGWGI");

    }

    void OnDisable()
    {
        GetlangGRButton().onClick.RemoveListener(OnClick);
        GetlangGRButton().interactable = false;
    }



    void OnClick()
    {
        GetlangGRButton().interactable = false;

        CanvasSTART.SetActive(false);
        Audioclick.SetActive(true);
        vidmachineGR.SetActive(true);
        imgmachineGR.SetActive(true);
        koutiFIN_GR.SetActive(true);
        
        Invoke("Count", 19.0f);

        tag_valve.GetComponent<Image>().sprite = tag_valve_GR;
        tag_atmos.GetComponent<Image>().sprite = tag_atmos_GR;
        tag_atmos120.GetComponent<Image>().sprite = tag_atmos120_GR;
        tag_kinisi.GetComponent<Image>().sprite = tag_kinisi_GR;
        tag_box.GetComponent<Image>().sprite = tag_box_GR;
        tag_92.GetComponent<Image>().sprite = tag_92_GR;
        tag_vrisi.GetComponent<Image>().sprite = tag_vrisi_GR;
        tag_swlinas.GetComponent<Image>().sprite = tag_swlinas_GR;


    }



}
