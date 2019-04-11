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
    


    public void Play_Game() 
    {
        //SceneManager.LoadScene (1);
        NvpEventController.InvokeEvent(NvpGameEvents.OnGameStarted, this, null);
        
    }

    
    //public void Play_Again()
    //{
        
    //}

    public void Quit_Game ()
    {
        Application.Quit ();
    }

    public void Reset_Game()
    {
        //SceneManager.LoadScene(1);
        NvpEventController.InvokeEvent(NvpGameEvents.OnResetGame, this, null);
    }

    public void Exit_Game()
    {
        //SceneManager.LoadScene(0);
        NvpEventController.InvokeEvent(NvpGameEvents.OnExitGame, this, null);

    }

    public void Option_Game()
    {
        //SceneManager.LoadScene(4);
        NvpEventController.InvokeEvent(NvpGameEvents.OnOptionGame, this, null);
    }

    public void Exit_Option()
    {
        NvpEventController.InvokeEvent(NvpGameEvents.OnExitOption, this, null);
    }

    public void Bloom_Off()
    {
        PlayerPrefs.SetInt("Bloom",0); 
    }
    
    

}
