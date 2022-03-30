using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    public float xvalue;
    public float yvalue;
    public float zvalue;
    public GameObject camera;

    public void Moveleft()
    {
        xvalue = xvalue - 10f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveright()
    {
        xvalue = xvalue + 10f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveforward()
    {
        zvalue = zvalue + 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Movebackward()
    {
        zvalue = zvalue - 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveup()
    {
        yvalue = yvalue + 10f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Movedown()
    {
        yvalue = yvalue - 10f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Rotateleft() {
        camera.transform.Rotate(0, 10f, 0);
    }

    public void Rotateright()
    {
        camera.transform.Rotate(0, -10f, 0);
    }

    public void Resetcamera()
    {
        xvalue = 940f;
        yvalue = 718f;
        zvalue = 110f;
        camera.transform.position = new Vector3(xvalue,yvalue,zvalue);
        camera.transform.rotation = Quaternion.Euler(52.048f, 0, 0);
       
    }
}
