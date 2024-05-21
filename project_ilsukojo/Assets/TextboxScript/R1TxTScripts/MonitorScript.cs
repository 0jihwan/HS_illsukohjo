using UnityEngine;

public class MonitorScript : MonoBehaviour
{
    public R1Q1TextBox R1Q1TextBox;
    public R1Q2TextBox R1Q2TextBox;
    public R1Q3TextBox R1Q3TextBox;
    public R1Q4TextBox R1Q4TextBox;
    public GameObject hintTriggerObject;

    void Update()
    {
        if (R1Q1TextBox.isdone && R1Q2TextBox.isdone && R1Q3TextBox.isdone && R1Q4TextBox.isdone)
        {
            hintTriggerObject.SetActive(true);
            enabled = false;
        }
    }
}
