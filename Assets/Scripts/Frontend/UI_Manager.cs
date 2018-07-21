using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UI_Manager : MonoBehaviour {

    //UI_APP
    public Transform scanFound;
    public Transform mainMenu;
    public Transform infoPlant;
    public Transform infoSoil;
    public Transform infoSun;
    public Transform infoWater;
   

    //UI_How_To_Plant
    public Transform step1;
    public Transform step2;
    public Transform step3;
    public Transform step4;
    public Transform step5;

    //Active UI
    private string active;



    // UI APP Methods
    public void LoadInfoPlant()
    {

        mainMenu.gameObject.SetActive(false);
        infoPlant.gameObject.SetActive(true);
        active = "Plant";
    }

    public void LoadInfoSoil()
    {

        mainMenu.gameObject.SetActive(false);
        infoSoil.gameObject.SetActive(true);
        active = "Soil";
    }

    public void LoadInfoWater()
    {

        mainMenu.gameObject.SetActive(false);
        infoWater.gameObject.SetActive(true);
        active = "Water";
    }

    public void LoadInfoSun()
    {

        mainMenu.gameObject.SetActive(false);
        infoSun.gameObject.SetActive(true);
        active = "Sun";
    }

    public void LoadMainMenu()
    {
        if (active == "Plant")
        {
            infoPlant.gameObject.SetActive(false);
        }
        else if ( active  == "Soil")
        {
            infoSoil.gameObject.SetActive(false);
        }
        else if (active == "Water")
        {
            infoWater.gameObject.SetActive(false);
        }
        else if( active == "Sun")
        {
            infoSun.gameObject.SetActive(false);
        }
        else if( active == "step1")
        {
            step1.gameObject.SetActive(false);
        }
        else if (active == "step2")
        {
            step2.gameObject.SetActive(false);
        }
        else if (active == "step3")
        {
            step3.gameObject.SetActive(false);
        }
        else if (active == "step4")
        {
            step4.gameObject.SetActive(false);
        }
        else
        {
            step5.gameObject.SetActive(false);
        }

        mainMenu.gameObject.SetActive(true);
    }

    public void initMainMenu()
    {
        scanFound.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
     
    }


    //UI How to Plant Methods

    public void Load_How_To_Plant()
    {
        mainMenu.gameObject.SetActive(false);
        step1.gameObject.SetActive(true);
        active = "step1";

    }
    
    public void From_Step1_to_Step2() {
        step1.gameObject.SetActive(false);
        step2.gameObject.SetActive(true);
        active = "step2";
    }
    public void From_Step2_to_Step1(){
        step1.gameObject.SetActive(true);
        step2.gameObject.SetActive(false);
        active = "step1";
    }

    public void From_Step2_to_Step3() {
        step2.gameObject.SetActive(false);
        step3.gameObject.SetActive(true);
        active = "step3";
    }
    public void From_Step3_to_Step2(){
        step3.gameObject.SetActive(false);
        step2.gameObject.SetActive(true);
        active = "step2";
    }

    public void From_Step3_to_Step4()
    {
        step3.gameObject.SetActive(false);
        step4.gameObject.SetActive(true);
        active = "step4";
    }
    public void From_Step4_to_Step3()
    {
        step3.gameObject.SetActive(true);
        step4.gameObject.SetActive(false);
        active = "step3";
    }

    public void From_Step4_to_Step5()
    {
        step4.gameObject.SetActive(false);
        step5.gameObject.SetActive(true);
        active = "step5";
    }

    public void From_Step5_to_Step4()
    {
        step4.gameObject.SetActive(true);
        step5.gameObject.SetActive(false);
        active = "step5";
    }



}// End Class
