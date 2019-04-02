using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        Debug.Log("Start called");
        NvpEventController.SubscribeToEvent(NvpGameEvents.OnMainStarted, OnMainStarted);
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
    }
}
