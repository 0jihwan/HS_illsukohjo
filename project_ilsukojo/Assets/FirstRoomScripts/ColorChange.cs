using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;
    private bool select = false;

    void Start()
    {
        button = this.transform.GetComponent<Button>();
        if ( button != null)
        {
            button.onClick.AddListener(ButtonColorChanged);
        }
    }
    public void ButtonColorChanged()
    {
        ColorBlock colorBlock = button.colors;

        select = !select;

        colorBlock.normalColor = select ? new Color32(0, 0, 0, 255) : Color.white;
        colorBlock.highlightedColor = select ? new Color32(0, 0, 0, 255) : Color.white;
        colorBlock.selectedColor = select ? new Color32(0, 0, 0, 255) : Color.white;

        button.colors = colorBlock;
    }
}
