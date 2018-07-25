using SQLite4Unity3d;
using UnityEngine;
#if !UNITY_EDITOR
using System.Collections;
using System.IO;
#endif
using System.Collections.Generic;

public class DataService  {

	private SQLiteConnection _connection;

	public DataService(string DatabaseName){

#if UNITY_EDITOR
            var dbPath = string.Format(@"Assets/StreamingAssets/{0}", DatabaseName);
#else
        // check if file exists in Application.persistentDataPath
        var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

        if (!File.Exists(filepath))
        {
            Debug.Log("Database not in Persistent path");
            // if it doesn't ->
            // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID 
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
		
#elif UNITY_STANDALONE_OSX
		var loadDb = Application.dataPath + "/Resources/Data/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
	var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
	// then save to Application.persistentDataPath
	File.Copy(loadDb, filepath);

#endif

            Debug.Log("Database written");
        }

        var dbPath = filepath;
#endif
            _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
            Debug.Log("Final PATH: " + dbPath);     

	}


    // ========= DB =========================================== 

	public void CreateDB(){
		_connection.DropTable<Plants> ();
		_connection.CreateTable<Plants> ();

		
	}

    //============== CRUD ================================
  
    //Create
    public void CreatePlants()
    {
        _connection.InsertAll(new[]{
            new Plants{
                Id = 1,
                Nome_Popular = "Impatiens",
                Nome_Cientifico = "<i>Impatiens Hawkeri</i>",
                Familia = "Balsaminaceae",
                Origem = "África",
                Altura = "0.3 a 0.4 metros",
                Floracao = "Anual",
                Ciclo_Vida = "Perene",
                Substrato = "Fértil, bem drenável e enriquecido com matéria orgânica",
                Adubo = "Orgânico ou NPK 10-10-10",
                Periodo_Adubo = "Adubações Periódicas cada 15 dias",
                Luminosidade = "Ambiente com luz difusa, meia sombra",
                Clima = "Não tolera seca ou sol e calor intenso",
                Qtd_Regas = "Frequentes cerca de 3 vezes por semana"

            },
            new Plants{
                Id = 1,
                Nome_Popular = "YYY",
                Nome_Cientifico = "YYY",
                Familia = "YYY",
                Origem = "YYY",
                Altura = "YYY",
                Floracao = "XXX",
                Ciclo_Vida = "YYY",
                Substrato = "YYY",
                Adubo = "YYY",
                Periodo_Adubo = "YYY",
                Luminosidade = "YYY",
                Clima = "YYY",
                Qtd_Regas = "YYY"
            }
        });
       
    }

    //Get
    public IEnumerable<Plants> GetPlants(){
		return _connection.Table<Plants>();
	}

    public Plants GetPlantByID(int id)
    {
        Plants p = new Plants(); 
        foreach(  Plants plant in GetPlants())
        {
            if (plant.Id == id)
            {
                p = plant;
                break;
            }
            else
                continue;
        }

        return p;
    }

	//Update

    //Delete
}
