using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spiner : MonoBehaviour
{
    public GameObject blade;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, 120 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
