using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="State")]

//this is a scriptable object. different from monobehavior which needs to be added as a component to a game object
public class State : ScriptableObject
{
    //for adding a text box to the unity inspector
    [TextArea(10,14)] [SerializeField] string storyText;

    //create a serialized array of data type state
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates; 
    }
}
