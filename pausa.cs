using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{

    [SerializeField]
    GameObject pause;

    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void PauseOff()
    {
        pause.SetActive(false );
        Time.timeScale = 1;
    }

    public void Again()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
