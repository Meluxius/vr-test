using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class Playstyle : MonoBehaviour
{
    [SerializeField] GameObject ground;
    [SerializeField] TeleportationProvider tpProvider;
    [SerializeField] ActionBasedSnapTurnProvider snapTurnProvider;
    [SerializeField] ActionBasedContinuousMoveProvider continuousMoveProvider;
    [SerializeField] ActionBasedContinuousTurnProvider continuousTurnProvider;
    [SerializeField] Toggle tpToggle;
    [SerializeField] Toggle continuousToggle;

    private void Awake()
    {
        ChangePlaystyleUI();
    }

    public void SetPlaystyleTeleport()
    {
        tpProvider.enabled = true;
        snapTurnProvider.enabled = true;
        continuousMoveProvider.enabled = false;
        continuousTurnProvider.enabled = false;
        tpToggle.isOn = true;
        continuousToggle.isOn = false;
        ChangePlaystyleUI();
    }

    public void SetPlaystyleContinuous()
    {
        tpProvider.enabled = false;
        snapTurnProvider.enabled = false;
        continuousMoveProvider.enabled = true;
        continuousTurnProvider.enabled = true;
        tpToggle.isOn = false;
        continuousToggle.isOn = true;
        ChangePlaystyleUI();
    }

    public void ChangePlaystyleUI()
    {
        if(tpProvider.enabled && snapTurnProvider.enabled)
        { 
            tpToggle.isOn = true;
            continuousToggle.isOn = false;
        }
        else
        {
            tpToggle.isOn = false;
            continuousToggle.isOn = true;
        }
    }
}