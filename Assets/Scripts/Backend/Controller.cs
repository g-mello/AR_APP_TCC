using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Controller : MonoBehaviour
{
    //UI Interface
    //public Text DebugText;
    public Transform MainMenu_Title;
    public Transform Plant_Description;
    public Transform Soil_Description;
    public Transform Water_Description;
    public Transform Sun_Description;



    //Vumark 
    private VuMarkManager mVuMarkManager;
   
    //private DataService ds;


    void Start()
    {
        mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
        //ds = new DataService("tempDatabase.db");
        StartSync();

        
    }


    void FixedUpdate()
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
            Debug.Log("Popular Name: " + plant.Nome_Popular);


            //Debug UI
            //ToConsole(plant.ToString());

            // Write to UI Elements
            WriteMainMenuTitle(plant);
            WritePlantInfo(plant);
            WriteSoilInfo(plant);
            WriteSunInfo(plant);
            WriteWaterInfo(plant);
           
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
        
        Debug.Log(msg);
    }


    private void WriteMainMenuTitle(Plants p)
    {
        Text title = MainMenu_Title.GetComponent<Text>();
        title.text =" " + p.Nome_Popular + " ";
    }

    //Write to the Plant Info UI the info collected from the DB related to the Plant
    private void WritePlantInfo(Plants p)
    {
        Text descricao = Plant_Description.GetComponent<Text>();

        descricao.text = "\n<b>Nome Popular: </b>" + p.Nome_Popular + "\n\n" +
                         "<b>Nome Científico: </b>" + p.Nome_Cientifico + "\n\n" +
                         "<b>Família: </b>" + p.Familia + "\n\n" +
                         "<b>Origem: </b>" + p.Origem + "\n\n" +
                         "<b>Altura: </b>" + p.Altura +  "\n\n" +
                         "<b>Floração: </b>" + p.Floracao + "\n\n" +
                         "<b>Ciclo de Vida: </b>" + p.Ciclo_Vida + "\n";

    }

    //Write to the Soil Info UI the info collected from the DB related to the Soil
    private void WriteSoilInfo(Plants p)
    {
        Text descricao = Soil_Description.GetComponent<Text>();

        descricao.text = "\n<b>Substrato Ideal: </b>" + p.Substrato + "\n\n" +
                         "<b>Tipo de Adubo: </b>" + p.Adubo + "\n\n" +
                         "<b>Período de Adubagem: </b>" + p.Periodo_Adubo + "\n";
            
    }

    //Write to the Water Info UI the info collected from the DB related to the Water
    private void WriteWaterInfo(Plants p)
    {
        Text descricao = Water_Description.GetComponent<Text>();

        descricao.text = "\n<b>Quantidade de Regas: </b>" + p.Qtd_Regas;
        
    }

    //Write to the Sun Info UI the info collected from the DB related to the Luminosity
    private void WriteSunInfo(Plants p)
    {
        Text descricao = Sun_Description.GetComponent<Text>();

        descricao.text = "\n<b>Luminosidade: </b>" + p.Luminosidade + "\n\n" +
                         "<b>Clima: </b>" + p.Clima + "\n";

    }

}
