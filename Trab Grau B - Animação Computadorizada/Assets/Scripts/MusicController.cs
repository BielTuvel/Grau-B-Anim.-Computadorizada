using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] _audioClips = null;

    private AudioSource _audioSource;

    [SerializeField]
    private _animationController _animationController;

    private int _currentIndex = 0;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>(); 
    }

    //Função para selecionar a música correta e dar play.
    public void ChangeClip(int index)
    {
        _currentIndex = index;
        _audioSource.clip = _audioClips[index];
        _audioSource.Play();
    }
}
