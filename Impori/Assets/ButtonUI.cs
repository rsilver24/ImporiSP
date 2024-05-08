using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    //[SerializeField] private string newGameLevel = "MainGame";

    public void NewGameButton()
    {
		SceneController.counter += 1;
        SceneManager.LoadScene(0);
    }
}
