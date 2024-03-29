using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolItem
{
    public GameObject prefab;
    public int amount;
    public bool expandable;
}
public class Pool : MonoBehaviour
{
    
    public List<PoolItem> items;
    public List<GameObject> pooledItems;
    int aux;

    public static Pool singleton;

    private void Awake()
    {
        singleton = this;   
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Rock") == 1)
        {
            aux = 2;
        }
        pooledItems = new List<GameObject>();

        foreach(PoolItem item in items)
        {
            for(int i=0; i<item.amount+aux; i++)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Get(string tag)
    {
        for (int i = 0; i < pooledItems.Count; i++)
        {
            if (!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[i];
            }
        }
        return null;
    }

}
