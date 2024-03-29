﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] private float projectileSpeed = 1f;



    private void Start()
    {
        Destroy(gameObject, 0.5f);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * projectileSpeed);
    }
}
