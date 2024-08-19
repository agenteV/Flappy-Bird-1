using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class ControladorMenu : MonoBehaviour
{
    private UIDocument document;
    private Button botao;

    private void Awake()
    {
       document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("jogar");
        botao.RegisterCallback<ClickEvent>(onPlay);

    }
    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }
}
