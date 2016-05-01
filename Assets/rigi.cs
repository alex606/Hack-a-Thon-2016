using UnityEngine;
using System.Collections;

public class rigi : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
