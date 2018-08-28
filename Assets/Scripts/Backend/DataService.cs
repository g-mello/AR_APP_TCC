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
                Periodo_Adubo = "Adubações Periódicas a cada 15 dias",
                Luminosidade = "Ambiente com luz difusa, meia sombra",
                Clima = "Não tolera seca ou sol e calor intenso",
                Qtd_Regas = "Frequentes cerca de 3 vezes por semana"

            },
            new Plants{
                Id = 2,
                Nome_Popular = "Cravina",
                Nome_Cientifico = "<i>Dianthus chinensis</i>",
                Familia = "Caryophyllaceae",
                Origem = "Ásia, Europa",
                Altura = "0.1 a 0.3 metros",
                Floracao = "Anual",
                Ciclo_Vida = "Bienal, Perene",
                Substrato = "Solo Fértil, bem drenável e enriquecido com matéria orgânica",
                Adubo = "Orgânico ou NPK 15-10-10",
                Periodo_Adubo = "Adubações Periódicas a cada 15 dias",
                Luminosidade = "Deve ser cultivada em sol pleno, minímo de 3 horas de sol.",
                Clima = "Preferência por clima frio.",
                Qtd_Regas = "Regas regulares de 3 vezes por semana."
            },
            new Plants{
                Id = 3,
                Nome_Popular = "Crisântemo",
                Nome_Cientifico = "<i>Chrysanthemum morifolium</i>",
                Familia = "Asteraceae",
                Origem = "Ásia, China, Japão",
                Altura = "0.3 a 0.4 metros",
                Floracao = "Inverno",
                Ciclo_Vida = "Perene",
                Substrato = "Solo Fértil, bem drenável e enriquecido com matéria orgânica",
                Adubo = "Orgânico ou NPK 10-15-10",
                Periodo_Adubo = "Adubações Periódicas a cada 15 dias",
                Luminosidade = "Deve ser cultivada a meia sombra.",
                Clima = "Se adapta bem ao clima de diversas regiões.",
                Qtd_Regas = "Regas regulares de 3 vezes por semana."
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
