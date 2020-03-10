using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatesky : MonoBehaviour
{
    public float rotatespeed = 4f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotatespeed);
    }


}
