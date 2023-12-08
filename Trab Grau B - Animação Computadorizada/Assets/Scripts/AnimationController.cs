using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _animationController : MonoBehaviour
{
    //ENUM com as animações
    public enum Estado_animacao
    {
        Idle,
        Hiphop,
        Rock,
        Love,
        Pop
    }

    public Estado_animacao estadoAtual;

    [SerializeField]
    private Animator _anim;

    [SerializeField]
    private MusicController _musicController;

    private int _currentState;
    void Start()
    {
        
    }

    public void AtualizarAnimacao(int dance)
    {
        Estado_animacao estadoAtual = (Estado_animacao)dance;
        //Switch case para determinar qual animação deve ser reproduzida

        if (estadoAtual != (Estado_animacao)_currentState)
        {
            switch (estadoAtual)
            {
                case Estado_animacao.Idle:
                    _anim.SetInteger("Style", 0);
                    _musicController.ChangeClip(dance);
                    _currentState = (int)estadoAtual;
                    break;

                case Estado_animacao.Hiphop:
                    _anim.SetInteger("Style", 1);
                    _musicController.ChangeClip(dance);
                    _currentState = (int)estadoAtual;
                    break;

                case Estado_animacao.Rock:
                    _anim.SetInteger("Style", 2);
                    _musicController.ChangeClip(dance);
                    _currentState = (int)estadoAtual;
                    break;

                case Estado_animacao.Love:
                    _anim.SetInteger("Style", 3);
                    _musicController.ChangeClip(dance);
                    _currentState = (int)estadoAtual;
                    break;

                case Estado_animacao.Pop:
                    _anim.SetInteger("Style", 4);
                    _musicController.ChangeClip(dance);
                    _currentState = (int)estadoAtual;
                    break;
            }
        }
        
    }


}
