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
    

    public void LoadInfoPlant()
    {

        mainMenu.gameObject.SetActive(false);
        infoPlant.gameObject.SetActive(true);

    }


    

	
}
