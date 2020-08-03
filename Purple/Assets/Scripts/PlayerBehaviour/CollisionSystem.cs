using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CollisionSystem : MonoBehaviour
{
    [SerializeField] private string _paintedObjectTag = "Placeholder";
    [SerializeField] private Material _purpleVisible;
    
    private MeshRenderer _playerMeshRenderer;
    private ParticleSystem _playerParticleSystem;

    private void Start()
    {
        _playerMeshRenderer = GetComponent<MeshRenderer>();
        _playerParticleSystem = GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _playerMeshRenderer.material = _purpleVisible;
            gameObject.GetComponent<TrailRenderer>().material = _purpleVisible;
            gameObject.GetComponent<ParticleSystemRenderer>().material = _purpleVisible;
            _paintedObjectTag = "Purple";
            PlayerSwitch.WinLevel();
        }
        else if (!other.gameObject.CompareTag("Unpaintable") && !other.gameObject.CompareTag(_paintedObjectTag))
        {
            _playerParticleSystem.Play();
            other.gameObject.GetComponent<MeshRenderer>().material = _playerMeshRenderer.material;
            other.gameObject.tag = _paintedObjectTag;
        }
        
        
    }
}
