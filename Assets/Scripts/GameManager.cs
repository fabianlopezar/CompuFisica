using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public int _puntos { get; set; }
    public string _namePlayer;
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
    }
    public void SumarPuntos()
    {
        _puntos += 100;
        UpdateUI.Instance.SetValuesUI();        
    }
    public void ObtenerNombrePlayer(string nombrePlayer)
    {
        GameManager.Instance._namePlayer = nombrePlayer;
    }
}
