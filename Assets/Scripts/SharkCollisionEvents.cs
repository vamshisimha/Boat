using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkCollisionEvents : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat"))
        {
            other.GetComponent<Animator>().SetTrigger("CollidedWithIsland");
            Invoke("gameover", 2);
            
        }
    }
    public void gameover()
    {
        SceneManager.LoadScene(0);
    }
}
