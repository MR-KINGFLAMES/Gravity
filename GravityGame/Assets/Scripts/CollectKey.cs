using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "key")
        Destroy(other.gameObject);
        if (GameObject.FindGameObjectsWithTag("key").Length == 0)
        {
            if ((other.gameObject.tag == "door"))
            {
                int y = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(y + 1);
                Debug.Log("Change Levels");
            }
        }
    }
}
