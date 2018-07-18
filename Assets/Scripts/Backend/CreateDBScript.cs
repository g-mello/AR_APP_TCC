using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CreateDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		StartSync();
	}

    private void StartSync()
    {
        //Creates and initialize the DB
        var ds = new DataService("tempDatabase.db");
        ds.CreateDB();
        ds.CreatePlants();
        
        //Debug Get 
        var plants = ds.GetPlants ();
        ToConsole (plants);

        
    }
	
	private void ToConsole(IEnumerable<Plants> plants){
		foreach (var plant in plants) {
			ToConsole(plant.ToString());
		}
	}
	
	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
        DebugText.text += System.Environment.NewLine + "Hello World";
		Debug.Log (msg);
	}
}
