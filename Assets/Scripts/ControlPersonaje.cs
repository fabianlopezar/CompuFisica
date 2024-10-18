using System.Collections;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public GameObject[] topos;
    public ChangePrefabTopo cambiarSkinsTopos; // Referencia al script CambiarSkinsTopos
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
            // Muestra el topo
            topos[randomValue].GetComponent<Diglett>().Mostrar();
            yield return new WaitForSeconds(1);

            // Esconde el topo
            topos[randomValue].GetComponent<Diglett>().Esconder();
            yield return new WaitForSeconds(1);
                        
            randomValue = Random.Range(0, topos.Length);   // Selecciona otro topo aleatoriamente
            cambiarSkinsTopos.CambiarPrefab(randomValue);  // Aquí llamas a CambiarSkins

        }

        //Debug.Log("Se ha detenido LanzarTopo.");
    }

    public void DetenerLanzarTopo()
    {
        shouldStop = true;  // Activa la condición para detener el ciclo
    }
}
