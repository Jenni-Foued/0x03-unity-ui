using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start the game when Play button is pressed from the main menu
    public void PlayMaze()
    {
        SceneManager.LoadScene("Maze");
    }

    // Quit the game when Quit button is pressed from the main menu
    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
