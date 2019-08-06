using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    [SerializeField] private int startScreenIndex;
    private int currentSceneIndex;
    [SerializeField] private string gameScreenName;
    [SerializeField] private string splashScreenName;
    [SerializeField] private int secondsToWaitAndLoad;

    private void Start()
    {
        //Obtener indice de la la escena actual al iniciarla
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Si esta escena es la pantalla de carga, se espera 6 ssegundos para avanzar
        if (currentSceneIndex.Equals(1)) StartCoroutine(WaitForTime());
    }

    private IEnumerator WaitForTime()
    {
        //Esperar y cargar
        yield return new WaitForSeconds(secondsToWaitAndLoad);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
