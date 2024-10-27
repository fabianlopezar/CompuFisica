using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UpdateUI : MonoBehaviour
{
    public static UpdateUI Instance { get; set; }

    [Header("TMP")]        
    public TMP_Text _puntajeTMP;
   
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        FindObjectName();
    }
    public void Start()
    {
        SetValuesUI();
    }
  
    public void SetValuesUI()
    {
        _puntajeTMP.text =  GameManager.Instance._puntos+"pts";     
    }
    public void FindObjectName()
    {
            GameObject objetoEncontrado = GameObject.Find("puntosTMP");
            if (objetoEncontrado != null)
            {
                _puntajeTMP = objetoEncontrado.GetComponent<TMP_Text>();//Le asigno el valor a la variable encontrada.
            }        
    }    
    private void OnEnable()
    {
        // Suscribirse al evento de escena cargada
        SceneManager.sceneLoaded += HandleSceneLoaded;
    }

    private void OnDisable()
    {
        // Asegúrate de desuscribirte cuando el objeto se desactive o sea destruido
        SceneManager.sceneLoaded -= HandleSceneLoaded;
    }

    // Este método se ejecutará cada vez que se cargue una nueva escena
    private void HandleSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Puedes agregar aquí el código que deseas ejecutar cuando cambie de escena
        FindObjectName();
        SetValuesUI();
        //      Debug.Log("Cambio de escena detectado. Se cargó la escena: " + scene.name);
    }    
}