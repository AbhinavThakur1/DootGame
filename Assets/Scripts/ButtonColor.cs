using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    [Header("ButtonImages")]
    [SerializeField] Image bt1;
    [SerializeField] Image btt1;
    [SerializeField] Image bt2;
    [SerializeField] Image btt2;
    [SerializeField] Image bt3;
    [SerializeField] Image btt3;
    [SerializeField] Image bt4;
    [SerializeField] Image btt4;

    void Start()
    {
        bt1.color = Color.blue;
        btt1.color = Color.blue;
        bt2.color = Color.red;
        btt2.color = Color.red;
        bt3.color = Color.cyan;
        btt3.color = Color.cyan;
        bt4.color = Color.yellow;
        btt4.color = Color.yellow;
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
