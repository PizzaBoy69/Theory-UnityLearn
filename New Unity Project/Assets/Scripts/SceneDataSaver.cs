using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDataSaver : MonoBehaviour
{
    public static SceneDataSaver Instance;
    public string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
