using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPulsado : MonoBehaviour
{
    public void cambioEscena()
    {
        Datos.contador = 123;
        SceneManager.LoadScene("Escena2");
    }
}
