using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set;}

    [SerializeField] private GameObject[] characters;

    private int _charIndex;
    public int CharIndex {
        get { return _charIndex; }
        set { _charIndex = value; }
    }

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    //Called when game obejct is enabled
    private void OnEnable() {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    //Called when game obejct is disabled
    private void OnDisable() {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    
    // Custom function
    void OnLevelFinishedLoading (Scene scene, LoadSceneMode mode){
        if (scene.name == "Gameplay")
            Instantiate(characters[CharIndex]);
    }
}
