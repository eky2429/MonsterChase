using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //If you want to add a parameter to this, you can only add 1?
    public void PlayGame() {
        //How to get name of object clicked
        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.CharIndex = selectedCharacter;
        SceneManager.LoadScene("Gameplay");
    }
}
