using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private Text textPoints;

    public int cantidadPuntos;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        cantidadPuntos = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Puntos")
        {
            points += cantidadPuntos;
            textPoints.text = points.ToString();

            PlayerPrefs.SetInt("Points", points);
        }
        if (points > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", points);
        }
    }
}
