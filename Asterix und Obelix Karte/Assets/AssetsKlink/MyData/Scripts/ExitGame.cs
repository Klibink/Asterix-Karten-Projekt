﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Beendet die Anwendung
public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Spiel beendet");
    }
}
