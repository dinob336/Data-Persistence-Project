using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;//What happens if i use public GameObject PlayerNameInput; instead?

   

    public void SetPlayerName()
    {
        GameManager.Instance.PlayerName = PlayerNameInput.text;
        

    }

    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
