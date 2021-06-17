using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager _instance = null;

    public static GameManager instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    public int maxLives = 3;
    public int Health = 3;
    public int minHealth = 1;
    public AudioSource bgAudio;

    int _score = 0;
    public int score
    {
        get { return _score; }
        set 
        { 
            _score = value;
            Debug.Log("Current Score Is: " + _score);
        }
    }


    int _lives;
    public int lives
    {
        get { return _lives; }
        set
        {
            if (_lives > value)
            {
                Respawn();
            }
            _lives = value;

            if (_lives > maxLives)
            {
                _lives = maxLives;
            }
            else if (_lives < 0)
            {
                //game over code goes here
            }

            Debug.Log("Current Lives Are: " + _lives);
        }
    }

    public GameObject playerInstance;
    public GameObject playerPrefab;
    public LevelManager currentLevel;
    
    void Start()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

    {
//      audioSource.Play();
    }
}

    void Update()
    {
        /*
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    if (SceneManager.GetActiveScene().name == "gameover")
                        SceneManager.LoadScene("mainmenu");
                    else if (SceneManager.GetActiveScene().name == "mainmenu")
                        SceneManager.LoadScene("level_1");

                }
        */

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "gameover")
                SceneManager.LoadScene("mainmenu");
            if (SceneManager.GetActiveScene().name == "mainmenu")
                SceneManager.LoadScene("level_1");
            if (SceneManager.GetActiveScene().name == "level_1")
                SceneManager.LoadScene("mainmenu");
            if (SceneManager.GetActiveScene().name == "credits")
                SceneManager.LoadScene("mainmenu");
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
//          QuitGame();
            SceneManager.LoadScene("mainmenu");
        }

        if (Health <= minHealth)
        {
            SceneManager.LoadScene("gameover");
        }

    }//End of Update

    public void QuitGame()
    {
/*
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
*/
//        if (SceneManager.GetActiveScene().name != "gameover" || SceneManager.GetActiveScene().name != "mainmenu")
//                SceneManager.LoadScene("mainmenu");
    }

    public void SpawnPlayer(Transform spawnLocation)
    {

        CameraFollow mainCamera = FindObjectOfType<CameraFollow>();

        if (mainCamera)
        {
            mainCamera.player = Instantiate(playerPrefab, spawnLocation.position, spawnLocation.rotation);
            playerInstance = mainCamera.player;
        }
        else
        {
            SpawnPlayer(spawnLocation);
        }

    }

    public void Respawn()
    {
        playerInstance.transform.position = currentLevel.spawnLocation.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "OutBounds")
        {
//            GameManager.Health - 99999;
            
        }

    }

    //End
}
