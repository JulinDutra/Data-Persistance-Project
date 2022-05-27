using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public static MenuUI Instance;

    public TMP_InputField inputField;
    public string newName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        newName = inputField.text;
    }

    public void NewName(string newName)
    {
        MenuUI.Instance.newName = inputField.text;
    }

    public void StartNew()
    {
        NewName(newName);
        SceneManager.LoadScene(1);
    }

}
