using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{

    private List<ListernerEvent> listeners = new List<ListernerEvent>();


    public void Register(ListernerEvent listener)
    {
        listeners.Add(listener);
    }
    
    public void Unregister(ListernerEvent listener)
    {
        listeners.Remove(listener);
    }
    public void Ocurred(GameObject go)
    {
        for(int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventOccurs(go);
        }
    }
}
