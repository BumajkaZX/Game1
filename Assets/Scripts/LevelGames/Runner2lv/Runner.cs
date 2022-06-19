using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public GameObject StartInt;
    public GameObject ExitInt;
    public GameObject CamMain;
    public GameObject CamGame;
    public void RunStart()
    {
        StartInt.SetActive(false);
        ExitInt.SetActive(false);
    }
    public void RunExit()
    {
        CamGame.SetActive(false);
        CamMain.SetActive(true);       
    }
}
