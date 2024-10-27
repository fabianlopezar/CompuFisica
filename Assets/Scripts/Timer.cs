using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Importa el espacio de nombres para la gesti�n de escenas

public class Timer : MonoBehaviour
{
    public float firstTimerDuration = 10f; // Duraci�n del primer temporizador en segundos
    public float secondTimerDuration = 5f; // Duraci�n del segundo temporizador en segundos
    private float remainingTime;
    private bool isTimerRunning = false;

    public TMP_Text timerTMP; // Referencia al objeto TMP_Text
    public ControlPersonaje controllerTopos; // Referencia al script de los topos

    private bool stopTopos = false; // Nueva variable para detener los topos
    public string sceneToLoad; // Nombre de la escena a cargar al final del segundo temporizador

    void Start()
    {
        StartTimer(firstTimerDuration);
    }

    public void StartTimer(float duration)
    {
        remainingTime = duration;
        isTimerRunning = true;
        StartCoroutine(TimerCoroutine());
    }

    private IEnumerator TimerCoroutine()
    {
        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1f); // Espera 1 segundo
            remainingTime--;
            timerTMP.text = remainingTime.ToString("F0"); // Actualiza el texto con el tiempo restante            
        }

        TimerFinished();
    }

    private void TimerFinished()
    {
        isTimerRunning = false;
        timerTMP.text = "0"; // Establece el texto a 0 cuando el temporizador termina        

        // Aqu� puedes iniciar otro temporizador
        if (remainingTime == 0 && firstTimerDuration > 0)
        {
            
            firstTimerDuration = 0; // Marcamos que el primer temporizador ya ha terminado
            // Aqu� puedes agregar otra l�gica cuando ambos temporizadores terminen
            stopTopos = true;  // Marcamos que los topos deben detenerse
            controllerTopos.DetenerLanzarTopo();  // Detenemos la l�gica de topos
            StartTimer(secondTimerDuration); // Inicia el segundo temporizador
        }
        else
        {            
            // Carga la nueva escena
            if (!string.IsNullOrEmpty(sceneToLoad)) // Verifica que la variable no est� vac�a
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.LogError("El nombre de la escena no est� establecido.");
            }
        }
    }
}
