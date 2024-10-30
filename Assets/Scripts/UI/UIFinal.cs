using TMPro;
using UnityEngine;

public class UIFinal : MonoBehaviour
{
    public TMP_Text _puntajeAlto;
    public TMP_Text _nombre;

    public void MostrarPuntajesAltos()
    {   
        _puntajeAlto.text = "" + GameManager.Instance._puntos;
        _nombre.text = "" + GameManager.Instance._namePlayer;
    }

    public void SaveDataFunction()
    {
        SaveData.instance.SaveDataToJson(GameManager.Instance._namePlayer, GameManager.Instance._puntos);
    }

}
