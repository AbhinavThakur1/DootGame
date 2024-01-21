using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonColor1 : MonoBehaviour
{
    [Header("ButtonImages")]
    [SerializeField] Image bt1;
    [SerializeField] Image btt1;

    void Start()
    {
        bt1.color = Color.blue;
        btt1.color = Color.blue;
        if(bt1.color == Color.blue)
        {
            foreach(ColorPlatesAroundbutton i in FindObjectsByType<ColorPlatesAroundbutton>(FindObjectsSortMode.None))
            {
                i.Colorchange();
            }
        }
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
