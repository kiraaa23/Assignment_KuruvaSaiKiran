using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainScreenUI : MonoBehaviour
{
    public Button StartBtn;
    public TextMeshProUGUI HighScore;


    private void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        StartBtn.onClick.AddListener(StartGame);
    }


    void StartGame() {


        SceneManager.LoadScene("GameScene");
    
    }
}
