using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UI_Manager : MonoBehaviour {

    public Transform scanFound;
    public Transform mainMenu;
    public Transform infoPlant;
    public Transform infoSoil;
    public Transform infoSun;
    public Transform infoWater;
    private string activeInfo;
    

    public void LoadInfoPlant()
    {

        mainMenu.gameObject.SetActive(false);
        infoPlant.gameObject.SetActive(true);
        activeInfo = "Plant";
    }

    public void LoadInfoSoil()
    {

        mainMenu.gameObject.SetActive(false);
        infoSoil.gameObject.SetActive(true);
        activeInfo = "Soil";
    }

    public void LoadInfoWater()
    {

        mainMenu.gameObject.SetActive(false);
        infoWater.gameObject.SetActive(true);
        activeInfo = "Water";
    }

    public void LoadInfoSun()
    {

        mainMenu.gameObject.SetActive(false);
        infoSun.gameObject.SetActive(true);
        activeInfo = "Sun";
    }

    public void LoadMainMenu()
    {
        if (activeInfo == "Plant")
        {
            infoPlant.gameObject.SetActive(false);
        }
        else if (activeInfo == "Soil")
        {
            infoSoil.gameObject.SetActive(false);
        }
        else if (activeInfo == "Water")
        {
            infoWater.gameObject.SetActive(false);
        }
        else
        {
            infoSun.gameObject.SetActive(false);
        }

        mainMenu.gameObject.SetActive(true);
    }

    public void initMainMenu()
    {
        scanFound.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

}
