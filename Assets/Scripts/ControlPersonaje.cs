using System.Collections;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public GameObject[] topos;
    public int randomValue = 0;
    public bool shouldStop = false;  // Nueva variable para controlar el ciclo

    void Start()
    {
        randomValue = Random.Range(0, topos.Length);
        StartCoroutine(LanzarTopo());
    }

    IEnumerator LanzarTopo()
    {
        while (!shouldStop) // Solo corre mientras no deba detenerse
        {
            topos[randomValue].GetComponent<Diglett>().Mostrar();
            yield return new WaitForSeconds(1);

            topos[randomValue].GetComponent<Diglett>().Esconder();
            yield return new WaitForSeconds(1);

            randomValue = Random.Range(0, topos.Length);
        }

        Debug.Log("Se ha detenido LanzarTopo.");
    }

    public void DetenerLanzarTopo()
    {
        shouldStop = true;  // Activa la condición para detener el ciclo
    }
}
