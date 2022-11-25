using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool alive;

    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI gameOverTxt;

    public GameObject gameOverSound;
    public GameObject song;


    public void GameOver()
    {
        StartCoroutine(Lose());
    }

    IEnumerator Lose()
    {
        print("Game Over!");

        alive = false;

        song.SetActive(false);
        gameOverSound.SetActive(true);

        scoreTxt.gameObject.SetActive(false);
        gameOverTxt.gameObject.SetActive(true);

        yield return new WaitForSecondsRealtime(3);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}