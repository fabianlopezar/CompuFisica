using UnityEngine;

public class Puntos : MonoBehaviour
{
    public static Puntos Instance { get; private set; }
    
    public int _puntos { get; set; }
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
}
