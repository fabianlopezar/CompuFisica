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
        if (_puntajeTMP != null)
        {
            _puntajeTMP.text = GameManager.Instance._puntos + "pts";
        }

    }
    public void FindObjectName()
    {
            GameObject objetoEncontrado = GameObject.Find("puntosTMP");
        _puntajeTMP = objetoEncontrado ? objetoEncontrado.GetComponent<TMP_Text>() : null;
    }    
    private void OnEnable()
    {
        // Suscribirse al evento de escena cargada
        SceneManager.sceneLoaded += HandleSceneLoaded;
    }

    private void OnDisable()
    {
        // Aseg�rate de desuscribirte cuando el objeto se desactive o sea destruido
        SceneManager.sceneLoaded -= HandleSceneLoaded;
    }

    // Este m�todo se ejecutar� cada vez que se cargue una nueva escena
    private void HandleSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Puedes agregar aqu� el c�digo que deseas ejecutar cuando cambie de escena
        FindObjectName();
        SetValuesUI();
        //      Debug.Log("Cambio de escena detectado. Se carg� la escena: " + scene.name);
    }    
}