using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabLoading : MonoBehaviour
{
    public List<GameObject> prefabsToLoad;

    void Start()
    {


        //Load each prefab in the game
        foreach (GameObject prefab in prefabsToLoad)
        {
            Instantiate(prefab);
        }
    }
}
