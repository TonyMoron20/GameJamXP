using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private string[] _objetos = { "Animales", "Muebles", "Personas" };
    private string[] _accesorios = { "Accesorios", "Asquerosidades", "Situaciones incovenientes", "Armas" };
    public string objeto;
    public string accesorio;

    public TMP_Text textoCarta;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        objeto = _objetos[Random.Range(0, _objetos.Length)];
        accesorio = _accesorios[Random.Range(0, _accesorios.Length)];

        textoCarta.text = $"Buenas noches comediante.\r\nLe contamos que el público de esta noche le agrada la temática de {objeto} , y de {accesorio}";
    }

    public void HideTitleScreen()
    {
        titleScreen.SetActive(false);
    }
}
