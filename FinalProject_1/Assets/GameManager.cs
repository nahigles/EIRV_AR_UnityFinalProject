using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static private GameManager _instance;
    static public GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != Instance)
        {
            Destroy(this);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void DesertMenu()
    {
        SceneManager.LoadScene("DesertMenu");
    }

    public void ForestMenu()
    {
        SceneManager.LoadScene("ForestMenu");
    }

    public void TropicalMenu()
    {
        SceneManager.LoadScene("TropicalMenu");
    }

    public void ArticMenu()
    {
        SceneManager.LoadScene("ArticMenu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
