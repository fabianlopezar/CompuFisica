using UnityEngine;

public class ChangePrefabTopo : MonoBehaviour
{
    // Arrays de topos y prefabs de topos con diferentes skins
    public GameObject[] topos;         // Referencias a los topos actuales
    public GameObject[] prefabsDeTopos; // Prefabs con diferentes skins

    // Funci�n para cambiar el prefab de un solo topo (sin destruir el GameObject)
    public void CambiarPrefab(int numeroTopo)
    {
        // Asegurarse que el �ndice del topo es v�lido
        if (numeroTopo < 0 || numeroTopo >= topos.Length)
        {
            Debug.LogWarning("�ndice de topo fuera de rango.");
            return;
        }

        // Asegurarse que el topo actual no es nulo
        GameObject topoActual = topos[numeroTopo];
        if (topoActual == null)
        {
            Debug.LogWarning("El topo en esa posici�n es null.");
            return;
        }

        // Selecciona un prefab aleatorio
        GameObject nuevoPrefab = prefabsDeTopos[Random.Range(0, prefabsDeTopos.Length)];

        // Guardar la jerarqu�a (parent) del topo actual
        Transform parentOriginal = topoActual.transform.parent;

        // Crear una nueva instancia del prefab en la misma posici�n, rotaci�n y jerarqu�a que el topo actual
        GameObject nuevoTopo = Instantiate(nuevoPrefab, topoActual.transform.position, topoActual.transform.rotation, parentOriginal);

        // Opcional: Copiar otras propiedades si es necesario, como escala
        nuevoTopo.transform.localScale = topoActual.transform.localScale;

        // Desactivar o eliminar el antiguo topo
        topoActual.SetActive(false); // O puedes usar Destroy(topoActual);

        // Actualizar el array de topos para reflejar el cambio
        topos[numeroTopo] = nuevoTopo;


    }
}
