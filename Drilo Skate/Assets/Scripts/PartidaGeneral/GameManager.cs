using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool pausa;
    // Start is called before the first frame update
    void Start()
    {
        pausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pausa)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;
    }

    public void Pausa()
    {
        pausa = !pausa;
    }

    public void Reintentar()
    {
        SceneManager.LoadScene("Game");
        PlayerPrefs.DeleteKey("Points");
    }
}
