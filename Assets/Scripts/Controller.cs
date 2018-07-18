using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Controller : MonoBehaviour
{
    //UI Interface
    public Text DebugText;

    //Vumark 
    private VuMarkManager mVuMarkManager;
   
    //private DataService ds;


    void Start()
    {
        mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
        //ds = new DataService("tempDatabase.db");
        StartSync();
    }


    void Update()
    {

        var ds = new DataService("tempDatabase.db"); //Start a connection with the DB
        Plants plant;
        int targetID;

        //Get the current Target ID from the target has been tracked
        // Get the information of the plant based on the tracked Target ID
        foreach (var vmark in mVuMarkManager.GetActiveBehaviours())
        {

            targetID = System.Convert.ToInt32(vmark.VuMarkTarget.InstanceId.NumericValue);

            plant = ds.GetPlantByID(targetID);

            // Debug Data
            Debug.Log(message: "Target ID: " + targetID);
            Debug.Log( "Plant ID: " + System.Convert.ToString(plant.Id));
            Debug.Log("Plant Name: " + plant.Name);

            //Debug UI
            //ToConsole(plant.ToString());
           
        }



    }


    private void StartSync()
    {
        //Creates and initialize the DB
        var ds = new DataService("tempDatabase.db");
        ds.CreateDB();
        ds.CreatePlants();

        //Debug Get 
        var plants = ds.GetPlants();
        ToConsole(plants);

    }

    private void ToConsole(IEnumerable<Plants> plants)
    {
        foreach (var plant in plants)
        {
            ToConsole(plant.ToString());
        }
    }

    private void ToConsole(string msg)
    {
        DebugText.text = System.Environment.NewLine + msg;
        Debug.Log(msg);
    }
}
