using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public FruitSpawner fruitSwapner;
    public GameObject SnakeParent;
    public GameObject SnakeTilePrefab;
    public float offset;
    public TextMeshProUGUI ScoreCount;
    public TextMeshProUGUI FinalScore;
    public GameObject GameOverPopUp;
    public Button OkBtn;

    private void Start()
    {
        ScoreCount.text = "0";
        if (PlayerPrefs.HasKey("HighScore") == false) {

            PlayerPrefs.SetInt("HighScore",0);
        }
        OkBtn.onClick.AddListener(OnOkBtn);
    }

    public void OnFruitHit(int points) {
        int tempscore = 0;
        if (ScoreCount.text.Length > 0) {
            tempscore = int.Parse(ScoreCount.text)+points;

        }
        else
        {
            tempscore = points;
        }
        ScoreCount.text = tempscore.ToString();

        if (tempscore>PlayerPrefs.GetInt("HighScore")) {

            PlayerPrefs.SetInt("HighScore", tempscore);

        }

        fruitSwapner.GenerateFruit();
        AddTail();
    
    }

    public void OnBoundaryHit()
    {

        SnakeParent.SetActive(false);
        GameOverPopUp.SetActive(true);
        FinalScore.text = ScoreCount.text;

    }

    public void AddTail() {

        var Tail = Instantiate(SnakeTilePrefab, SnakeParent.transform);
        Tail.GetComponent<SphereCollider>().enabled=false;
        Tail.transform.localPosition = new Vector3(SnakeParent.transform.childCount* offset, 1,0);
        Tail.GetComponent<SphereCollider>().enabled = true;

    }

    void OnOkBtn() {


        SceneManager.LoadScene("MenuScene");
    }
   
}
