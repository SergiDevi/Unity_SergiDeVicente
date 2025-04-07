using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Se llama antes de que empiece el primer frame
    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Se llama después de que la cámara y los objetos se hayan actualizado
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}