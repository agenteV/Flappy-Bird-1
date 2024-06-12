using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UASCRIPT : MonoBehaviour
{
    private int pontos;
    private Label textoPontuacao;

    public void adicionarPontos()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
    }
}
