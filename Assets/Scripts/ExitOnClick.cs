using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Exit Button geklickt - Spiel wird beendet");
        Application.Quit();
    }
}
