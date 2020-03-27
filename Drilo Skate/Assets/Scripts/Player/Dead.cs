using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject respawn;
    public GameManager gameManager;
    public Canvas canvasMuerte;
    public Canvas canvasPrincipal;

    private void Start()
    {
        respawn = GameObject.Find("RespawnPoint");

        canvasMuerte.enabled = false;
        canvasPrincipal.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dead")
        {
            HasPerdido();
        }
    }

    private void HasPerdido()
    {
        //canvasPrincipal.enabled = false;
        //canvasMuerte.enabled = true;
        //Time.timeScale = 0;
        SceneManager.LoadScene("Dead");
    }

    public void Continuas()
    {
        canvasPrincipal.enabled = true;
        canvasMuerte.enabled = false;
        transform.position = respawn.transform.position;
        Time.timeScale = 1;
    }
}
