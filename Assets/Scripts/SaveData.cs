using TMPro;
using UnityEngine;
using System.IO;

[SerializeField]
public class Data
{
    public string _nombre;
    public int _puntaje;
}
public class SaveData : MonoBehaviour


{
    public static SaveData instance { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = new SaveData();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public TMP_Text _nombreTMP;
    public TMP_Text _puntajeTMP;
    private string dataFilePath = "Assets/DataJSON.json";

    public void SaveDataToJson(string nombre, int puntaje)
    {
        Data data = new Data();
        data._nombre = nombre;
        data._puntaje = puntaje;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(dataFilePath, jsonData);
    }
    public void LoadDataFrom()
    {
        if (File.Exists(dataFilePath))
        {
            string jsonData = File.ReadAllText(dataFilePath);
            Data data = JsonUtility.FromJson<Data>(jsonData);

            _nombreTMP.text =""+data._nombre;
            _puntajeTMP.text = ""+data._puntaje;
        }
        else
        {
            Debug.Log("No se encontro datos");
        }
    }
}
