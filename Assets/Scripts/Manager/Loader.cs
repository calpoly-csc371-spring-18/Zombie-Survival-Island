﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Loader : NetworkBehaviour
{
    public GameObject gameManager;
    public GameObject spawner;

    [ServerCallback]
    void Awake()
    {
        if (GameManager.instance == null)
        {
            Instantiate(gameManager);
        }
        if (Spawner.instance == null)
        {
            Instantiate(spawner);
        }
    }

}
