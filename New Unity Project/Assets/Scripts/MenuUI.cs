using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{
    private TMP_InputField playerNameInput;

    // Start is called before the first frame update
    void Start()
    {
        playerNameInput = transform.Find("Name Input Field").GetComponent<TMP_InputField>();
    }

    public void StartGame()
    {
        SceneDataSaver.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }
}
