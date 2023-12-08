using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaEmocoes : MonoBehaviour
{
    [SerializeField]
    public _animationController personagem;

    public Slider disposicaoSlider;
    public Slider tedioSlider;
    public Slider felicidadeSlider;

    //Valores iniciais de emo��o
    private float disposicao = 0.5f;
    private float tedio = 0.5f;
    private float felicidade = 0.5f;

    //Ajusta a sensibilidade dos sliders conforme necess�rio
    private float sensibilidadeSlider = 100f;

    void Start()
    {
        //M�todos de callback para os eventos de altera��o dos sliders
        disposicaoSlider.onValueChanged.AddListener(AtualizarDisposicao);
        tedioSlider.onValueChanged.AddListener(AtualizarTedio);
        felicidadeSlider.onValueChanged.AddListener(AtualizarFelicidade);

        disposicaoSlider.value = disposicao;
        tedioSlider.value = tedio;
        felicidadeSlider.value = felicidade;

        // Chamar a fun��o de atualiza��o do comportamento inicial do personagem
        AtualizarComportamento();
    }

    //Fun��es para atualizar os sentimentos
    void AtualizarDisposicao(float valor)
    {
        disposicao = valor * sensibilidadeSlider;
        AtualizarComportamento();
    }

    void AtualizarTedio(float valor)
    {
        tedio = valor * sensibilidadeSlider;
        AtualizarComportamento();
    }

    void AtualizarFelicidade(float valor)
    {
        felicidade = valor * sensibilidadeSlider;
        AtualizarComportamento();
    }

    //Fun��o para atualizar o comportamento baseado nas emo��es
    void AtualizarComportamento()
    {
        //Combina��o 1: Tranquilidade
        if (disposicao <= 50 && (tedio >= 50 && tedio < 70) && felicidade <= 50)
        {
            personagem.AtualizarAnimacao(0);
            // L�gica para a��o de Tranquilidade
            Debug.Log("Tranquilidade");
        }
        //Combina��o 2: Agita��o
        else if (disposicao >= 80 && tedio <= 50 && felicidade >= 50)
        {
            personagem.AtualizarAnimacao(1);
            // L�gica para a��o de Agita��o
            Debug.Log("Agita��o");
        }
        //Combina��o 3: Entusiasmo
        else if (disposicao >= 70 && tedio <= 30 && felicidade >= 80)
        {
            personagem.AtualizarAnimacao(2);
            // L�gica para a��o de Entusiasmo
            Debug.Log("Entusiasmo");
        }
        //Combina��o 4: Tristeza
        else if (disposicao <= 30 && tedio >= 80 && felicidade <= 20)
        {
            personagem.AtualizarAnimacao(3);
            // L�gica para a��o de Tristeza
            Debug.Log("Tristeza");
        }
        //Combina��o 5: Malandragem
        else if (disposicao >= 50 && tedio <= 50 && felicidade >= 80)
        {
            personagem.AtualizarAnimacao(4);
            Debug.Log("Malandragem");
        }
        else
        {
            Debug.Log("Comportamento padr�o");
        }
    }
}