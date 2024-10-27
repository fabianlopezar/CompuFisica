using UnityEngine;
using UnityEngine.SceneManagement; // Importa el espacio de nombres para la gestión de escenas
public class Botones : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a cargar al final del segundo temporizador


    public void CambiarNivel()
    {
        // Carga la nueva escena
        if (!string.IsNullOrEmpty(sceneToLoad)) // Verifica que la variable no esté vacía
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("El nombre de la escena no está establecido.");
        }
    }
}
