using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDesttoy : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip background;



    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }


    void Update()
    {
        
    }
}
