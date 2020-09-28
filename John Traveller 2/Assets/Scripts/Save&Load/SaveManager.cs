using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;


public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    public PlayerData data;
    string dataFile = "data.jd";
    public static PlayerMovement _playerMovement;
    public GameObject[] prefabs;
    void Awake()
    { 
        /*
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != null)
            Destroy(this);*/
        
    }

    private void Start()
    {
        _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void Load()
    {
        
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(filePath))
        {
            FileStream file = File.Open(filePath, FileMode.Open);
            PlayerData loaded = (PlayerData)bf.Deserialize(file);

            ///////////////
            GameObject clone = Instantiate(prefabs[loaded.ID]) as GameObject;
            DontDestroyOnLoad(clone);
            SceneManager.LoadScene(loaded.currentScene);
            
            _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            _playerMovement.moveSpeed = loaded.speed;
            _playerMovement.hp = loaded.hp;
            _playerMovement.hpMax = loaded.hpMax;
            _playerMovement.damage = loaded.damage;
            data = loaded;

            Vector3 position;
            position.x = loaded.position[0];
            position.y = loaded.position[1];
            position.z = loaded.position[2];

            _playerMovement.transform.position = position;
            ///////////////

            file.Close();
        }
        else
            Debug.Log("Save file does not exist");
    }

    public void Save()
    {
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        data = new PlayerData();
        bf.Serialize(file, data);
        file.Close();
    }

}

[System.Serializable]
public class PlayerData
{
    public int currentScene;
    public float speed;
    public float hp;
    public float hpMax;
    public float damage;
    public float[] position;
    public int ID;
    //PlayerMovement _playerMovement;

    public PlayerData()
    {
       
        currentScene = SceneManager.GetActiveScene().buildIndex;
        speed = SaveManager._playerMovement.moveSpeed;
        hp = SaveManager._playerMovement.hp;
        hpMax = SaveManager._playerMovement.hpMax;
        damage = SaveManager._playerMovement.damage;
        ID = SaveManager._playerMovement.id;

        position = new float[3];
        position[0] = SaveManager._playerMovement.transform.position.x;
        position[1] = SaveManager._playerMovement.transform.position.y;
        position[2] = SaveManager._playerMovement.transform.position.z;
    }
}
