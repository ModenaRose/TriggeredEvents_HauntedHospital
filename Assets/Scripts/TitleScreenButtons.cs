using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButtons : MonoBehaviour
{
    public GameObject credits;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        credits.SetActive(!credits.activeInHierarchy);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
