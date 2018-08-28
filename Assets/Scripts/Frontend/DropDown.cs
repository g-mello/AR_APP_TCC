using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDown : MonoBehaviour {

    //State 
    public UnityEngine.UI.Dropdown dropdown_state;
    List<string> states = new List<string>() { "Estado", "Acre", "Alagoas","Amapá", "Amazonas", "Bahia",
                                               "Ceará", "Distrito Federal", "Goiás", "Maranhão", "Mato Grosso",
                                               "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná",
                                               "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte",
                                               "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo",
                                               "Sergipe", "Tocantins"
                                                };
    
    // City
    public UnityEngine.UI.Dropdown dropdown_city;
    List<string> cities_sp = new List<string>() { "Cidade","Araraquara", "Barretos", "Batatais", "Bauru",
                                                "Campinas", "Campos do Jordão", "Cedral", "Diadema", "Dracena", "Dumont",
                                                "Embu", "Franca", "Francisco Morato","Guará","Guaíra", "Holambra", "Hortolândia",
                                               "Ibitinga", "Indaiatuba", "Igarapaga","Jaboticabal", "Jadinópolis", "Jaú",
                                               "Leme", "Marília", "Matão", "Osasco", "Piracicaba", "Presidente Prudente",
                                               "Ribeirão Preto", "Rio Claro", "Santos", "São Carlos", "São Paulo", "Taubaté"}; 

    // Garden Center
    public UnityEngine.UI.Dropdown dropdown_garden_center;
    List<string> garden_centers = new List<string>() { "Estabelecimento", "Exemplo TCC" };

    //Selected Values
    private static string selected_state;
    private static string selected_city;
    private static string selected_garden_center;

    //Button
    public Transform button;

    private void Start()
    {

        // State Dropdown
        dropdown_state.ClearOptions();
        dropdown_state.AddOptions(states);

        // City Dropdown
        dropdown_city.ClearOptions();
        dropdown_city.AddOptions(cities_sp);

        // Garden Centers Dropdown
        dropdown_garden_center.ClearOptions();
        dropdown_garden_center.AddOptions(garden_centers);
    }

    
   public void DropdownSelectedState(int index)
    {
        selected_state = states[index];
        Debug.Log(selected_state);
    }

    public void DropdownSelectedCity(int index)
    {
        selected_city = cities_sp[index];
        Debug.Log(selected_city);
    }

    public void DropdownSelectedGardenCenter(int index)
    {
        selected_garden_center = garden_centers[index];
        Debug.Log(selected_garden_center);
    }

    public void SearchPlant()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

}
