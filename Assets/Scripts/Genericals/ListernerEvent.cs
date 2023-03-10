using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<GameObject> { }
public class ListernerEvent : MonoBehaviour
{
    public Event gEvent;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unregister(this);
    }

    public void OnEventOccurs(GameObject go)
    {
        response.Invoke(go);
    }
    // Start is called before the first frame update
    
}
