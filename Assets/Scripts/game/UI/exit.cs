using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public GameObject Menu;
    public GameObject player;
    // Start is called before the first frame update
    private void Start()
    {
        Menu.SetActive(false);
    }
    public void menu()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);
        gameObject.SetActive(false);
        player.SetActive(false);
        player.GetComponent<PlayerMove>().variableJoystick.gameObject.SetActive(false);
        player.GetComponent<PlayerMove>().Stone.gameObject.SetActive(false);

    }
    public void goon()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        player.GetComponent<PlayerMove>().variableJoystick.gameObject.SetActive(true);
        player.GetComponent<PlayerMove>().Stone.gameObject.SetActive(true);
        gameObject.SetActive(true);
    }
    public void OnExitGame() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("home");
    }
}
