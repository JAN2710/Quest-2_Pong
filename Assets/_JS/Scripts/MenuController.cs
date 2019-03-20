using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button Play_Button;
    public Button Quit_Button;
    public Button Reset_Button;
    public Button Exit_Button;
    public Button Option_Button;



    public void Play_Game () 
    {
        SceneManager.LoadScene (1);
    }
    
    public void Quit_Game ()
    {
        Application.Quit ();
    }

    public void Reset_Game()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit_Game()
    {
        SceneManager.LoadScene(0);
    }

    public void Option_Game()
    {
        SceneManager.LoadScene(4);
    }

}
