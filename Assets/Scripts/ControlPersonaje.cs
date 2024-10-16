using System.Collections;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public GameObject[] topos;      // Array de diferentes topos en la mesa

    public GameObject[] toposSkinACmabiar;
    public GameObject[] skins;  
    
    // Array de diferentes skins para los topos
    public int randomValue = 0;
    public bool shouldStop = false;  // Para controlar si se debe detener el ciclo

    void Start()
    {
        randomValue = Random.Range(0, topos.Length);  // Selecciona un topo al azar
        StartCoroutine(LanzarTopo());
    }

    IEnumerator LanzarTopo()
    {
        while (!shouldStop) // Corre mientras no deba detenerse
        {
            // Elige un topo aleatorio
            GameObject topo = toposSkinACmabiar[randomValue];

            // Asigna una skin aleatoria al topo que va a aparecer
            CambiarSkin(topo);

            // Muestra el topo con su nueva skin
            topo.GetComponent<Diglett>().Mostrar();
            yield return new WaitForSeconds(1);

            // Esconde el topo
            topo.GetComponent<Diglett>().Esconder();
            yield return new WaitForSeconds(1);

            // Selecciona un nuevo topo aleatorio
            randomValue = Random.Range(0, topos.Length);
        }

        Debug.Log("Se ha detenido LanzarTopo.");
    }

    // Función para cambiar la skin de un topo
    public void CambiarSkin(GameObject topo)
    {
        // Selecciona una skin aleatoria
        int nuevaSkinIndex = Random.Range(0, skins.Length);

        // Busca el MeshRenderer o SkinnedMeshRenderer del topo y cambia su mesh/material
        var renderer = topo.GetComponentInChildren<MeshRenderer>(); // O usa SkinnedMeshRenderer si es un modelo animado
        if (renderer != null)
        {
            // Cambia el material o mesh del topo al de la nueva skin
            renderer.material = skins[nuevaSkinIndex].GetComponentInChildren<MeshRenderer>().material;
        }

        Debug.Log("Skin cambiada a: " + skins[nuevaSkinIndex].name + " para el topo: " + topo.name);
    }

    public void DetenerLanzarTopo()
    {
        shouldStop = true;  // Activa la condición para detener el ciclo
    }
}
