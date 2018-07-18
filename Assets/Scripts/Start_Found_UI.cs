using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Start_Found_UI : MonoBehaviour {

    public Transform scanFound;
    public Transform mainMenu;
    //protected bool active;

	// Use this for initialization
	void Start () {

        //active = false;
        //scanFound.gameObject.SetActive(true);

        scanFound.gameObject.SetActive(true);
        StartCoroutine(my_Coroutine());

    }
	
	public IEnumerator my_Coroutine()
    {
        Debug.Log(message: "Start Coroutine");

        yield return new WaitForSeconds(10f);
        scanFound.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);

        Debug.Log(message: "End Coroutine");
    }
}
