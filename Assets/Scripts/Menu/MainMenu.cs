using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame ()
    {        
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void QuitGame ()
    {



#if UNITY_EDITOR
        Debug.Log("Unity Editor");
        UnityEditor.EditorApplication.isPlaying = false;

#endif


#if UNITY_STANDALONE_WIN
        Debug.Log("Stand Alone Windows");
        Debug.Log("Se ha cerrado");
        Application.Quit();
#endif    
        

    }
}
