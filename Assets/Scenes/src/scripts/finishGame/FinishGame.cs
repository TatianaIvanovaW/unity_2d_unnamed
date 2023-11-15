using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using static tags;
using static scenes;

public class FinishGame : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == tags.player)
        {
            SceneManager.LoadScene(scenes.village);
        }
    }
}
