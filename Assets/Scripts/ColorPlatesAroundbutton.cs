using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ColorPlatesAroundbutton : MonoBehaviour
{
    [SerializeField] GameObject Image;
    [SerializeField] Button btn;

    public void Colorchange()
    {
        Image.GetComponent<Image>().color = btn.GetComponent<Image>().color;
    }

    void Update()
    {
        if (Dataclass.start)
        {
            if (Input.mousePosition.x <= transform.position.x + 50f && Input.mousePosition.x >= transform.position.x - 50f &&
        Input.mousePosition.y <= transform.position.y + 50f && Input.mousePosition.y >= transform.position.y - 50f)
            {
                if (!Image.activeSelf && Image.GetComponent<Image>().color == Dataclass.Clr)
                {
                    Image.SetActive(true);
                    foreach (ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
                    {
                        if (i.on)
                        {
                            i.images.Add(Image);
                        }
                    }
                }
                else if (Image.GetComponent<Image>().color == Dataclass.Clr)
                {
                    Image.SetActive(true);
                    foreach (ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
                    {
                        if (i.on)
                        {
                            i.images.Add(Image);
                        }
                    }
                }
                else
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
    }
}
