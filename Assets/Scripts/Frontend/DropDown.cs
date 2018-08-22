using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDown : MonoBehaviour {

    //State 
    public UnityEngine.UI.Dropdown dropdown_state;
    List<string> states = new List<string>() { "Estado", "São Paulo", "Rio de Janeiro","Minas Gerais", "Espirito Santo" };
    
    // City
    public UnityEngine.UI.Dropdown dropdown_city;
    List<string> cities = new List<string>() { "Cidade", "Batatais", "Franca", "Ribeirão Preto" };

    // Garden Center
    public UnityEngine.UI.Dropdown dropdown_garden_center;
    List<string> garden_centers = new List<string>() { "Estabelecimento", "Floricultura XYZ", "Garden Center TCC" };

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
        dropdown_city.AddOptions(cities);

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
        selected_city = cities[index];
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
