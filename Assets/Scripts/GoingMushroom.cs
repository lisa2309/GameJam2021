using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoingMushroom : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("MushroomScene");
    }
}
