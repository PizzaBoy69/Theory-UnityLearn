using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuMain : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI buildingsScoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = "Player: " + SceneDataSaver.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        buildingsScoreText.text = "Last selected building: " + Building.objectName;
    }
}
