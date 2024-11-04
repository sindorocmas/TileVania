using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersist : MonoBehaviour
{
   void Awake()
    {
        int numScenePesists = FindObjectsOfType<ScenePersist>().Length;
        if (numScenePesists > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void RestScenePersist()
    {
        Destroy(gameObject);
    }
}
