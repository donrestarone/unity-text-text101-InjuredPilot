using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use Text as a data type you need to import this
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //by having serialize field, we have access to it in the inspector
    //you can access text component as a reference
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        //take the textComponent and modify its text property.
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }

        textComponent.text = state.GetStateStory();
    }
}
