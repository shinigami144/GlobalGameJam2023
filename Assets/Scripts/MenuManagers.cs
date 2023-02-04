using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagers : MonoBehaviour
{
    public static MenuManagers Instance { get; private set; }

    public static bool[] finishedLevels; 

    private void Awake()
    {
        if (Instance != this)
        {
            Instance= this;
            finishedLevels = new bool[3];
            finishedLevels[0] = false;
            finishedLevels[1] = false; 
            finishedLevels[2] = false;  
        }
    }

    
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void GoToLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }

    public void FinishedLevel(int level)
    {
        finishedLevels[level] = true;
        for (int i = 0; i < finishedLevels.Length; i++)
        {
            if (!finishedLevels[i])
            {
                GoToLevel(i);
            }
        }
        GoToMenu();
    }

#if UNITY_EDITOR

    public void DebugButton()
    {
        Debug.Log("Clicked on btn");
    }
#endif
}
