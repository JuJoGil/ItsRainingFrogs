using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSavingObjects : MonoBehaviour {

    [SerializeField] private ColorBoton color;

    private void Start() {
        Load();
    }

    public void Save() {
        JsonManager.SaveGame(color);
    }

    public void Load() {
        JsonManager.LoadGame(color);
    }

}
