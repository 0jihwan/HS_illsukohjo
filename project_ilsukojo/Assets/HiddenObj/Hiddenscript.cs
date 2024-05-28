using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Hiddenscript : MonoBehaviour
{
    // Start is called before the first frame update
    Image hidden01;
    Image hidden02;
    Image hidden03;
    Image hidden04;
    public bool h1find = false;
    public bool h2find = false;
    public bool h3find = false;
    public bool h4find = false;
    void Start()
    {
        hidden01 = GameObject.Find("phone").GetComponent<Image>();
        hidden02 = GameObject.Find("knife").GetComponent<Image>();
        hidden03 = GameObject.Find("bottle").GetComponent<Image>();
        hidden04 = GameObject.Find("gloves").GetComponent<Image>();

        hidden01.color = new Color(hidden01.color.r, hidden01.color.g, hidden01.color.b, 0f);
        hidden02.color = new Color(hidden02.color.r, hidden02.color.g, hidden02.color.b, 0f);
        hidden03.color = new Color(hidden03.color.r, hidden03.color.g, hidden03.color.b, 0f);
        hidden04.color = new Color(hidden04.color.r, hidden04.color.g, hidden04.color.b, 0f);

        LoadHiddenStates();
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.transform.gameObject.name == "HiddenObj01")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hit.transform.gameObject);
                    hidden01.color = new Color(hidden01.color.r, hidden01.color.g, hidden01.color.b, 175f / 255f);
                    h1find = true;
                }
            }
            else if(hit.transform.gameObject.name == "HiddenObj02")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hit.transform.gameObject);
                    hidden02.color = new Color(hidden02.color.r, hidden02.color.g, hidden02.color.b, 175f / 255f);
                    h2find = true;
                }
            }
            else if(hit.transform.gameObject.name == "HiddenObj03")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hit.transform.gameObject);
                    hidden03.color = new Color(hidden03.color.r, hidden03.color.g, hidden03.color.b, 175f / 255f);
                    h3find = true;
                }
            }
            else if(hit.transform.gameObject.name == "HiddenObj04")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hit.transform.gameObject);
                    hidden04.color = new Color(hidden04.color.r, hidden04.color.g, hidden04.color.b, 175f / 255f);
                    h4find = true;
                }
            }
        }
                  //게임오브젝트에 좌클릭시
                  //그 오브젝트 없어지고 UI 생성
    }
    private void OnDisable()
    {
        SaveHiddenStates();
        Debug.Log("히든 저장완료.");
    }

    public void SaveHiddenStates()
    {
        PlayerPrefs.SetInt("Hidden01_found", h1find ? 1 : 0);
        PlayerPrefs.SetInt("Hidden02_found", h2find ? 1 : 0);
        PlayerPrefs.SetInt("Hidden03_found", h3find ? 1 : 0);
        PlayerPrefs.SetInt("Hidden04_found", h4find ? 1 : 0);
        PlayerPrefs.Save();
    }

    // Crossroad 씬으로 돌아왔을 때 호출되는 메소드
    void LoadHiddenStates()
    {
        h1find = PlayerPrefs.GetInt("Hidden01_found", 0) == 1;
        h2find = PlayerPrefs.GetInt("Hidden02_found", 0) == 1;
        h3find = PlayerPrefs.GetInt("Hidden03_found", 0) == 1;
        h4find = PlayerPrefs.GetInt("Hidden04_found", 0) == 1;

        if (h1find)
            hidden01.color = new Color(hidden01.color.r, hidden01.color.g, hidden01.color.b, 175f / 255f);
        else
            hidden01.color = new Color(hidden01.color.r, hidden01.color.g, hidden01.color.b, 0f);

        if (h2find)
            hidden02.color = new Color(hidden02.color.r, hidden02.color.g, hidden02.color.b, 175f / 255f);
        else
            hidden02.color = new Color(hidden02.color.r, hidden02.color.g, hidden02.color.b, 0f);

        if (h3find)
            hidden03.color = new Color(hidden03.color.r, hidden03.color.g, hidden03.color.b, 175f / 255f);
        else
            hidden03.color = new Color(hidden03.color.r, hidden03.color.g, hidden03.color.b, 0f);

        if (h4find)
            hidden04.color = new Color(hidden04.color.r, hidden04.color.g, hidden04.color.b, 175f / 255f);
        else
            hidden04.color = new Color(hidden04.color.r, hidden04.color.g, hidden04.color.b, 0f);
    }

    public bool AreAllHiddenObjectsFound()
    {
        return h1find && h2find && h3find && h4find;
    }
}
