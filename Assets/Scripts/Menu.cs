using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadNewGame());
    }

    IEnumerator LoadNewGame()
    {
        yield return new WaitForSecondsRealtime(5);

        SceneManager.LoadScene(1);
    }
}
