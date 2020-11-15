using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoingIce : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("WinterScene 1");
    }
}
