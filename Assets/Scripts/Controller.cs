using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Controller : MonoBehaviour
{

    private VuMarkManager mVuMarkManager;
    private int targetID;


    void Start()
    {
        mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
    }


    void Update()
    {

        //Get the current Target ID from the target has been tracked
        foreach (var vmark in mVuMarkManager.GetActiveBehaviours())
        {

            targetID = System.Convert.ToInt32(vmark.VuMarkTarget.InstanceId.NumericValue);

            Debug.Log(message: "Target ID: " + targetID);
        }



    }
}
