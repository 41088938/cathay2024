using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Switch;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class GetAnser : MonoBehaviour
{

    #region SelectionAreaVariables
    private GameObject sLighter1;
    private GameObject sLighter2;
    private GameObject sLighter3;
    private GameObject sLighter4;
    private GameObject sLighter5;
    private GameObject sLighter6;
    private GameObject sLighter7;
    private GameObject sLighter8;
    private GameObject sLighter9;
    private GameObject sLighter10;
    private GameObject sLighter11;
    private GameObject sLighter12;
    private GameObject sLighter13;
    private GameObject sLighter14;
    private GameObject sLighter15;
    private GameObject lighter16;
    private GameObject lighter17;

    private GameObject positionLighter1;
    private GameObject positionLighter2;
    private GameObject positionLighter3;
    private GameObject positionLighter4;//tester Shipment


    #endregion

    #region counter
    private int allBox=1;//change stage total boxs number
    private int OfferCorrectAnser=2;//change total aner number
    private int totleCorrectAnser=0;
    private int worngAnserCounter = 0;
    #endregion

    [SerializeField] GameObject stageComplectUI;

    [SerializeField] GameObject askingBar;
    [SerializeField] Text askingBarQ;
    [SerializeField] Button shipmentYes;
    [SerializeField] Button wayBillYes;
    [SerializeField] Button stickerYes;
    [SerializeField] LivePointController LPController;

    [SerializeField] Text score;
    private float point=0;

    private void  Start() { 
       
        getPackageVariables();
        //Debug.Log("sLighter1:"+sLighter1.name);
        askingBar.SetActive(false);
        PlayerPrefs.SetInt("boxComplection",0);
        stageComplectUI.SetActive(false);
        point = 0;
        
        score.text="Score :"+Mathf.Ceil(point).ToString();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "WrongAnser")
                {
                    switch (hit.transform.name)
                    {
                        case "Anser1":

                            if (sLighter1.active == false)
                            {
                                sLighter1.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter1.active == true)
                            {
                                sLighter1.SetActive(false);
                                worngAnserCounter--;

                            }

                            break;
                        case "Anser2":
                            if (sLighter2.active == false)
                            {
                                sLighter2.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter2.active == true)
                            {
                                sLighter2.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser3":
                            if (sLighter3.active == false)
                            {
                                sLighter3.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter3.active == true)
                            {
                                sLighter3.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser4":
                            if (sLighter4.active == false)
                            {
                                sLighter4.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter4.active == true)
                            {
                                sLighter4.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser5":
                            if (sLighter5.active == false)
                            {
                                sLighter5.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter5.active == true)
                            {
                                sLighter5.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser6":
                            if (sLighter6.active == false)
                            {
                                sLighter6.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter6.active == true)
                            {
                                sLighter6.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser7":
                            if (sLighter7.active == false)
                            {
                                sLighter7.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter7.active == true)
                            {
                                sLighter7.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser8":
                            if (sLighter8.active == false)
                            {
                                sLighter8.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter8.active == true)
                            {
                                sLighter8.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser9":
                            if (sLighter9.active == false)
                            {
                                sLighter9.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter9.active == true)
                            {
                                sLighter9.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser10":
                            if (sLighter10.active == false)
                            {
                                sLighter10.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter10.active == true)
                            {
                                sLighter10.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser11":
                            if (sLighter11.active == false)
                            {
                                sLighter11.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter11.active == true)
                            {
                                sLighter11.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser12":
                            if (sLighter12.active == false)
                            {
                                sLighter12.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter12.active == true)
                            {
                                sLighter12.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser13":
                            if (sLighter13.active == false)
                            {
                                sLighter13.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter13.active == true)
                            {
                                sLighter13.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser14":
                            if (sLighter14.active == false)
                            {
                                sLighter14.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter14.active == true)
                            {
                                sLighter14.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser15":
                            if (sLighter15.active == false)
                            {
                                sLighter15.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (sLighter15.active == true)
                            {
                                sLighter15.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser16":
                            if (lighter16.active == false)
                            {
                                lighter16.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (lighter16.active == true)
                            {
                                lighter16.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;
                        case "Anser17":
                            if (lighter17.active == false)
                            {
                                lighter17.SetActive(true);
                                worngAnserCounter++;
                            }
                            else if (lighter17.active == true)
                            {
                                lighter17.SetActive(false);
                                worngAnserCounter--;

                            }
                            break;

                        case "Shipment":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(true);
                            wayBillYes.gameObject.SetActive(false);
                            stickerYes.gameObject.SetActive(false);

                            break;
                        case "WayBill":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(false);
                            wayBillYes.gameObject.SetActive(true);
                            stickerYes.gameObject.SetActive(false);

                            break;
                        case "Sticker":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(false);
                            wayBillYes.gameObject.SetActive(false);
                            stickerYes.gameObject.SetActive(true);


                            break;
                        case "Anser18":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(false);
                            wayBillYes.gameObject.SetActive(false);
                            stickerYes.gameObject.SetActive(true);


                            break;


                    }
                }
                if (hit.transform.tag == "CorrectAnser")
                {
                    switch (hit.transform.name)
                    {
                       
                        case "Anser1":
                            totleCorrectAnser++;
                            if (sLighter1.active == false)
                            {
                                sLighter1.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter1.active == true)
                            {
                                sLighter1.SetActive(false);
                                totleCorrectAnser--;

                            }

                            break;
                        case "Anser2":
                            if (sLighter2.active == false)
                            {
                                sLighter2.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter2.active == true)
                            {
                                sLighter2.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser3":
                            if (sLighter3.active == false)
                            {
                                sLighter3.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter3.active == true)
                            {
                                sLighter3.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser4":
                            if (sLighter4.active == false)
                            {
                                sLighter4.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter4.active == true)
                            {
                                sLighter4.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser5":
                            if (sLighter5.active == false)
                            {
                                sLighter5.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter5.active == true)
                            {
                                sLighter5.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser6":
                            if (sLighter6.active == false)
                            {
                                sLighter6.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter6.active == true)
                            {
                                sLighter6.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser7":
                            if (sLighter7.active == false)
                            {
                                sLighter7.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter7.active == true)
                            {
                                sLighter7.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser8":
                            if (sLighter8.active == false)
                            {
                                sLighter8.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter8.active == true)
                            {
                                sLighter8.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser9":
                            if (sLighter9.active == false)
                            {
                                sLighter9.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter9.active == true)
                            {
                                sLighter9.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser10":
                            if (sLighter10.active == false)
                            {
                                sLighter10.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter10.active == true)
                            {
                                sLighter10.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser11":
                            if (sLighter11.active == false)
                            {
                                sLighter11.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter11.active == true)
                            {
                                sLighter11.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser12":
                            if (sLighter12.active == false)
                            {
                                sLighter12.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter12.active == true)
                            {
                                sLighter12.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser13":
                            if (sLighter13.active == false)
                            {
                                sLighter13.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter13.active == true)
                            {
                                sLighter13.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser14":
                            if (sLighter14.active == false)
                            {
                                sLighter14.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter14.active == true)
                            {
                                sLighter14.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser15":
                            if (sLighter15.active == false)
                            {
                                sLighter15.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (sLighter15.active == true)
                            {
                                sLighter15.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;

                        case "Anser16":
                            if (lighter16.active == false)
                            {
                                lighter16.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (lighter16.active == true)
                            {
                                lighter16.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;
                        case "Anser17":
                            if (lighter17.active == false)
                            {
                                lighter17.SetActive(true);
                                totleCorrectAnser++;
                            }
                            else if (lighter17.active == true)
                            {
                                lighter17.SetActive(false);
                                totleCorrectAnser--;

                            }
                            break;

                        case "Shipment":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(true);
                            wayBillYes.gameObject.SetActive(false);
                            stickerYes.gameObject.SetActive(false);

                            break;
                        case "WayBill":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(false);
                            wayBillYes.gameObject.SetActive(true);
                            stickerYes.gameObject.SetActive(false);

                            break;
                        case "Sticker":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(false);
                            wayBillYes.gameObject.SetActive(false);
                            stickerYes.gameObject.SetActive(true);


                            break;

                        case "Anser18":
                            Time.timeScale = 0;
                            AskingBar();
                            shipmentYes.gameObject.SetActive(false);
                            wayBillYes.gameObject.SetActive(false);
                            stickerYes.gameObject.SetActive(true);


                            break;



                    }
                        

                    
                }

            } 
        }
        StageComplect();
        Debug.Log("boxComplection: "+PlayerPrefs.GetInt("boxComplection"));


    }
    
    public void getPackageVariables()
    {

        sLighter1 = GameObject.Find("Cube/ShipmentInFormation/Anser1/lighting");
        sLighter1.SetActive(false);
        Debug.Log("sLighter1:"+sLighter1.name); 
        sLighter2 = GameObject.Find("Cube/ShipmentInFormation/Anser2/lighting");
        sLighter2.SetActive(false);
        Debug.Log("sLighter2:" + sLighter2.name);

        sLighter3 = GameObject.Find("Cube/ShipmentInFormation/Anser3/lighting");
        sLighter3.SetActive(false);
        sLighter4 = GameObject.Find("Cube/ShipmentInFormation/Anser4/lighting");
        sLighter4.SetActive(false);
        sLighter5 = GameObject.Find("Cube/ShipmentInFormation/Anser5/lighting");
        sLighter5.SetActive(false);
        sLighter6 = GameObject.Find("Cube/ShipmentInFormation/Anser6/lighting");
        sLighter6.SetActive(false);
        sLighter7 = GameObject.Find("Cube/ShipmentInFormation/Anser7/lighting");
        sLighter7.SetActive(false);
        sLighter8 = GameObject.Find("Cube/ShipmentInFormation/Anser8/lighting");
        sLighter8.SetActive(false);
        sLighter9 = GameObject.Find("Cube/ShipmentInFormation/Anser9/lighting");
        sLighter9.SetActive(false);

        sLighter10 = GameObject.Find("Cube/WayBillInfo/Anser10/lighting");
        sLighter10.SetActive(false);
        sLighter11 = GameObject.Find("Cube/WayBillInfo/Anser11/lighting");
        sLighter11.SetActive(false);
        sLighter12 = GameObject.Find("Cube/WayBillInfo/Anser12/lighting");
        sLighter12.SetActive(false);
        sLighter13 = GameObject.Find("Cube/WayBillInfo/Anser13/lighting");
        sLighter13.SetActive(false);
        sLighter14 = GameObject.Find("Cube/WayBillInfo/Anser14/lighting");
        sLighter14.SetActive(false);
        sLighter15 = GameObject.Find("Cube/WayBillInfo/Anser15/lighting");
        sLighter15.SetActive(false);
        lighter16 = GameObject.Find("Cube/WayBillInfo/Anser16/lighting");
        lighter16.SetActive(false);
        lighter17 = GameObject.Find("Cube/WayBillInfo/Anser16/lighting");
        lighter17.SetActive(false); 

        positionLighter1 = GameObject.Find("Cube/ShipmentInFormation/Shipment/lighting");
        positionLighter1.SetActive(false);
        positionLighter2 = GameObject.Find("Cube/WayBillInfo/WayBill/lighting");
        positionLighter2.SetActive(false);
        positionLighter3=GameObject.Find("Cube/Sticker/lighting");
        positionLighter3.SetActive(false);
        positionLighter4 = GameObject.Find("Cube/Anser18/lighting");
        positionLighter4.SetActive(false);

        totleCorrectAnser = 0;
        worngAnserCounter = 0;

    }

    public void Submition()
    {
        
        if(totleCorrectAnser == OfferCorrectAnser)
        {
            if (worngAnserCounter == 0)
            {
                point = +5;
                PlayerPrefs.SetInt("boxComplection", +1);
                PlayerPrefs.SetInt("TotleScore", +5);
            }
            else
            {
                LPController.MissSubmition();
            }
        }
        else
        {
            LPController.MissSubmition();
        }
    }

    public void StageComplect()
    {
        if(PlayerPrefs.GetInt("boxComplection")== allBox)
        {
            stageComplectUI.SetActive(true);
        }
    }

    public void AskingBar()//control the qustion bar qustion
    {
        
        if (positionLighter1.active == true)//will add more position lighter
        {
            askingBarQ.text = "Do you want to cancel the poisition selection?";

        }
        else if (positionLighter2.active == true)
        {
            askingBarQ.text = "Do you want to cancel the poisition selection?";

        }else if (positionLighter3.active == true)
        {
            askingBarQ.text = "Do you want to cancel the poisition selection?";
        }
        else if (positionLighter4.active == true)
        {
            askingBarQ.text = "Do you want to cancel the poisition selection?";
        }

        else if(positionLighter1.active ==false)
        {
            askingBarQ.text = "Select for wrong position?";
        }
        else if (positionLighter2.active == false)
        {
            askingBarQ.text = "Select for wrong position?";
        }
        else if (positionLighter3.active == false)
        {
            askingBarQ.text = "Select for wrong position?";
        }
        else if (positionLighter4.active == false)
        {
            askingBarQ.text = "Select for wrong position?";
        }
        askingBar.SetActive(true);
    }

    public void WrongShipmentPositionYes()
    {
        askingBar.SetActive(false);
        if (askingBarQ.text =="Do you want to cancel the poisition selection?")
        {
            positionLighter1.SetActive(false);
            if (positionLighter1.tag == "WrongAnser")
            {

                worngAnserCounter--;
            }
            else if (positionLighter1.tag == "CorrectAnser")
            {
                totleCorrectAnser--;
            }
        }
        if(askingBarQ.text == "Select for wrong position?")
        {
            positionLighter1.SetActive(true);
            if (positionLighter1.tag == "WrongAnser")
            {

                worngAnserCounter++;
            }
            else if (positionLighter1.tag == "CorrectAnser")
            {
                totleCorrectAnser++;
            }
           

        }
         Debug.Log("totleCorrectAnse: " + totleCorrectAnser);
        Time.timeScale = 1;


    }
    public void WrongWayBillPositionYes()
    {
        askingBar.SetActive(false);
        if (askingBarQ.text == "Do you want to cancel the poisition selection?")
        {
            positionLighter2.SetActive(false);
            if (positionLighter2.tag == "WrongAnser")
            {

                worngAnserCounter--;
            }
            else if (positionLighter2.tag == "CorrectAnser")
            {
                totleCorrectAnser--;
            }
        }
        if (askingBarQ.text == "Select for wrong position?")
        {
            positionLighter2.SetActive(true);
            if (positionLighter2.tag == "WrongAnser")
            {

                worngAnserCounter++;
            }
            else if (positionLighter2.tag == "CorrectAnser")
            {
                totleCorrectAnser++;
            }
            
            

        }
        Debug.Log("totleCorrectAnse: "+totleCorrectAnser);
        Time.timeScale = 1;

    }
    public void StickerPositionYes()
    {
        askingBar.SetActive(false);
        if (askingBarQ.text == "Do you want to cancel the poisition selection?")
        {
            positionLighter3.SetActive(false);
            if (positionLighter3.tag == "WrongAnser")
            {

                worngAnserCounter--;
            }
            else if (positionLighter3.tag == "CorrectAnser")
            {
                totleCorrectAnser--;
            }
        }
        if (askingBarQ.text == "Select for wrong position?")
        {
            positionLighter3.SetActive(true);
            if (positionLighter3.tag == "WrongAnser")
            {

                worngAnserCounter++;
            }
            else if (positionLighter3.tag == "CorrectAnser")
            {
                totleCorrectAnser++;
            }

        }
        Debug.Log("totleCorrectAnse: " + totleCorrectAnser);
        Time.timeScale = 1;

    }


    public void WrongPositionNO()
    {
        askingBar.SetActive(false);
        Time.timeScale = 1;


    }
    
    
 }