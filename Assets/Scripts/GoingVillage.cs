using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoingVillage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Village");
    }
}
