using TMPro;
using UnityEngine;

public class UIFinal : MonoBehaviour
{
    public TMP_Text _puntajeAlto;
    public TMP_Text _nombre;

    public void MostrarPuntajesAltos()
    {
        Debug.Log("deberi");
        _puntajeAlto.text = "" + GameManager.Instance._puntos;
        _nombre.text = "" + GameManager.Instance._namePlayer;
    }
}
