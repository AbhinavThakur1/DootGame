using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiHandler : MonoBehaviour
{
    bool pauseorplay = false;
    public float connected = 0;
    public float numberofpoints;
    float time;
    [SerializeField] GameObject play;
    [SerializeField] GameObject pause;
    [SerializeField] TMPro.TMP_Text percentage;
    [SerializeField] TMPro.TMP_Text connectedoutoff;
    [SerializeField] TMPro.TMP_Text timedisplay;
    [SerializeField] GameObject replayornext;
    float connectmore;
    bool z = true;

    private void Start()
    {
        Application.targetFrameRate = 200;
    }
    public void PausePlayClicked()
    {
        if (!pauseorplay)
        {
            play.SetActive(true);
            pause.SetActive(false);
            pauseorplay = true;
            Time.timeScale = 0;
        }
        else
        {
            play.SetActive(false);
            pause.SetActive(true);
            pauseorplay = false;
            Time.timeScale = 1f;
        }
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        var k = FindObjectsByType<ButtonClickHandler>(FindObjectsSortMode.None);
        if (z)
        {
            connectmore = 0;
            for (int i = 0; i <= k.Length - 1; i++)
            {
                connectmore += k[i].valuet;
            }
            if (connectmore % 2 == 0)
            {
                connected = connectmore / 2;
            }
            connectmore = 0;
        }
        percentage.text = (Mathf.Round((100 / numberofpoints) * connected)).ToString() + "%";
        connectedoutoff.text = connected.ToString() + "/" + numberofpoints.ToString();
        timedisplay.text = string.Format("{0:0.00}", time) + "s";
        if(connected == numberofpoints)
        {
            replayornext.SetActive(true);
        }
        else
        {
            time += Time.deltaTime;
        }
        if (!Input.mousePresent)
        {
            foreach (ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
            {
                if (i.on)
                {
                    foreach (GameObject j in i.images)
                    {
                        j.SetActive(false);
                    }
                    i.images.Clear();
                    i.on = false;
                    Dataclass.start = false;
                }
            }
        }
    }
}
