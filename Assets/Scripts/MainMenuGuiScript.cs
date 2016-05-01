using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class MainMenuGuiScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200));
        GUILayout.FlexibleSpace();

        if (GUILayout.Button("Start Game"))
        {
            StartGame();
        }

        if (GUILayout.Button("Press or Press EXC anytime during game to exit "))
        {
            EndGame();
        }
        GUILayout.FlexibleSpace();
        GUILayout.EndArea();
    }

    void StartGame()
    {
     
        SceneManager.LoadScene(1);
    }

    void EndGame()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }

}
