using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    public void ExitApp()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
