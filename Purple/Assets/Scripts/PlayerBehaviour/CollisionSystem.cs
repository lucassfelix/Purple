﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CollisionSystem : MonoBehaviour
{
    [SerializeField] private string _paintedObjectTag = "Placeholder";

    private Material _playerMaterial;
    private ParticleSystem _playerParticleSystem;

    private void Start()
    {
        _playerMaterial = GetComponent<MeshRenderer>().material;
        _playerParticleSystem = GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
        }
        else if (!other.gameObject.CompareTag("Unpaintable") && !other.gameObject.CompareTag(_paintedObjectTag))
        {
            _playerParticleSystem.Play();
            other.gameObject.GetComponent<MeshRenderer>().material = _playerMaterial;
            other.gameObject.tag = _paintedObjectTag;
        }
        
        
    }
}
