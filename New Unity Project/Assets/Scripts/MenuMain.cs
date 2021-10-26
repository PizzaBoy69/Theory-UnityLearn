using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuMain : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = "Player: " + SceneDataSaver.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
