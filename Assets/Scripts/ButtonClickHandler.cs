using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public ArrayList images = new ArrayList();
    public bool on = false;
    [SerializeField] ButtonClickHandler btn1;
    [SerializeField] ButtonClickHandler btn2;
    public bool connected = false;
    public float valuet;

    public void Buttonclick()
    {
        if (!connected)
        {
            on = true;
            Dataclass.start = true;
            connected = true;
            Dataclass.Clr = GetComponent<Image>().color;
        }
        else
        {
            btn1.connected = false;
            btn2.connected = false;
            foreach (GameObject i in btn1.images)
            {
                i.SetActive(false);
            }
            foreach (GameObject i in btn2.images)
            {
                i.SetActive(false);
            }
            btn1.images.Clear();
            btn2.images.Clear();
            connected = true;
            on = true;
            Dataclass.start = true;
        }
    }

    private void Update()
    {

        if (btn1.connected && btn2)
        {
            valuet = 1;
        }
        else
        {
            valuet = 0;
        }

        if (Input.mousePosition.x <= transform.position.x + 50f && Input.mousePosition.x >= transform.position.x - 50f &&
        Input.mousePosition.y <= transform.position.y + 50f && Input.mousePosition.y >= transform.position.y - 50f)
        {
            if (GetComponent<Image>().color != Dataclass.Clr)
            {
                Dataclass.start = false;
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
                        i.connected = false;
                    }
                }
            }
            else
            {
                foreach (ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
                {
                    if (i.on)
                    {
                        if (!connected)
                        {
                            connected = true;
                            i.on = false;
                            Dataclass.start = false;
                        }
                        images = i.images;
                    }
                }
            }
        }
    }
}