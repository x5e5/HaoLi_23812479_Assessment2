using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void Moveleft()
    {
        value = value - 1f;
        human.transform.position = new Vector3(value, 560.2552f, 197.8f);
    }
    public void Rotateleft()
    {
        human.transform.Rotate(0,0,20f);
    }
    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChange;
    }
    public void ResetHuman()
    {
        human.transform.position = new Vector3(812.5577f, 560.2552f, 197.8f);
        human.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }
}