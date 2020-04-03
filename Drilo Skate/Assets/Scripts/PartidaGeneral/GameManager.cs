using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool pausa;

    public Canvas canvasPrincipal;
    public Canvas canvasPausa;

    public Text musicOn;
    public Text musicOff;

    public AudioListener mainAudio;
    public AudioSource audioButton;

    public bool musicOnOff;

    // Start is called before the first frame update
    void Start()
    {
        audioButton = GetComponent<AudioSource>();
        pausa = false;
        if(SceneManager.GetActiveScene().name == "Game")
        {
            //mainAudio.enabled = false;
            MusicOn();
        }
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
        canvasPrincipal.enabled = !canvasPrincipal.enabled;
        canvasPausa.enabled = !canvasPausa.enabled;
    }

    public void Reintentar()
    {
        audioButton.Play();
        StartCoroutine(EsperarJugar());
    }

    public void Menu()
    {
        audioButton.Play();
        StartCoroutine(EsperarMenu());
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void MusicOn()
    {
        Camera.main.GetComponent<AudioSource>().volume = 0.4f;
        //mainAudio.enabled = !mainAudio.enabled;
        musicOff.color = Color.white;
        musicOn.color = Color.red;

        musicOnOff = true;
    }

    public void MusicOff()
    {
        Camera.main.GetComponent<AudioSource>().volume = 0f;
        //mainAudio.enabled = !mainAudio.enabled;
        musicOff.color = Color.red;
        musicOn.color = Color.white;

        musicOnOff = false;
    }

    public void Web()
    {
        Application.OpenURL("http://www.lapandilladedrilo.com");
    }

    IEnumerator EsperarJugar()
    {
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene("Game");
        PlayerPrefs.DeleteKey("Points");
    }

    IEnumerator EsperarMenu()
    {
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene("Menu");
        PlayerPrefs.DeleteKey("Points");
    }
}
