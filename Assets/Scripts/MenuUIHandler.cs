using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{

    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void StartNew()
    {
        Debug.Log(nameInput.text);
        SceneManager.LoadScene(1);
        NameManager.Instance.playerName = nameInput.text;
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
