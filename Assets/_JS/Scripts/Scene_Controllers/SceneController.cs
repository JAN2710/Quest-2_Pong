using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        Debug.Log("Start called");
        NvpEventController.SubscribeToEvent(NvpGameEvents.OnMainStarted, OnMainStarted);
        NvpEventController.SubscribeToEvent(NvpGameEvents.OnGameStarted, OnGameStarted);
        NvpEventController.SubscribeToEvent(NvpGameEvents.OnPlayer1Wins, OnPlayer1Wins);
        NvpEventController.SubscribeToEvent(NvpGameEvents.OnPlayer2Wins, OnPlayer2Wins);
    }


    void OnDisable()
    {
        Debug.Log("Disable called");
        NvpEventController.UnsubscribeFromEvent(NvpGameEvents.OnMainStarted, OnMainStarted);
    }



    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void OnMainStarted(object sender, object eventargs)
    {
        Debug.Log("OnMainStart");
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }
    private void OnGameStarted(object sender, object eventarges)
    {
        //if (SceneManager.GetSceneAt(0) == Scene.
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(0);
        SceneManager.UnloadSceneAsync(2);
        SceneManager.UnloadSceneAsync(3);
        

    }
    private void OnPlayer1Wins(object sender, object eventrags)
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
    }
    private void OnPlayer2Wins(object sender, object eventrags)
    {
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
    }
}      
