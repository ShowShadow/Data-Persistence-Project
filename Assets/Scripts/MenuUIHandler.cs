using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuUIHandler : MonoBehaviour
{
    public InputField nameInputField;
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadBestScore();
        bestScoreText.text = "Best Score:" + GameManager.Instance.Name + ":" + GameManager.Instance.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.Instance.PlayerName = nameInputField.GetComponent<InputField>().text;
        SceneManager.LoadScene("main");
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
