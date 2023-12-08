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

    //Valores iniciais de emoção
    private float disposicao = 0.5f;
    private float tedio = 0.5f;
    private float felicidade = 0.5f;

    //Ajusta a sensibilidade dos sliders conforme necessário
    private float sensibilidadeSlider = 100f;

    void Start()
    {
        //Métodos de callback para os eventos de alteração dos sliders
        disposicaoSlider.onValueChanged.AddListener(AtualizarDisposicao);
        tedioSlider.onValueChanged.AddListener(AtualizarTedio);
        felicidadeSlider.onValueChanged.AddListener(AtualizarFelicidade);

        disposicaoSlider.value = disposicao;
        tedioSlider.value = tedio;
        felicidadeSlider.value = felicidade;

        // Chamar a função de atualização do comportamento inicial do personagem
        AtualizarComportamento();
    }

    //Funções para atualizar os sentimentos
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

    //Função para atualizar o comportamento baseado nas emoções
    void AtualizarComportamento()
    {
        //Combinação 1: Tranquilidade
        if (disposicao <= 50 && (tedio >= 50 && tedio < 70) && felicidade <= 50)
        {
            personagem.AtualizarAnimacao(0);
            // Lógica para ação de Tranquilidade
            Debug.Log("Tranquilidade");
        }
        //Combinação 2: Agitação
        else if (disposicao >= 80 && tedio <= 50 && felicidade >= 50)
        {
            personagem.AtualizarAnimacao(1);
            // Lógica para ação de Agitação
            Debug.Log("Agitação");
        }
        //Combinação 3: Entusiasmo
        else if (disposicao >= 70 && tedio <= 30 && felicidade >= 80)
        {
            personagem.AtualizarAnimacao(2);
            // Lógica para ação de Entusiasmo
            Debug.Log("Entusiasmo");
        }
        //Combinação 4: Tristeza
        else if (disposicao <= 30 && tedio >= 80 && felicidade <= 20)
        {
            personagem.AtualizarAnimacao(3);
            // Lógica para ação de Tristeza
            Debug.Log("Tristeza");
        }
        //Combinação 5: Malandragem
        else if (disposicao >= 50 && tedio <= 50 && felicidade >= 80)
        {
            personagem.AtualizarAnimacao(4);
            Debug.Log("Malandragem");
        }
        else
        {
            Debug.Log("Comportamento padrão");
        }
    }
}