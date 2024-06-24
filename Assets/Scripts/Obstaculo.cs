


using System.Collections;

using System.Collections.Generic;

using UnityEngine;
 
public class Obstaculo : MonoBehaviour
{

    [SerializeField]

    private float velocidade = 0.6f;

    [SerializeField]

    private float variacaoDaPosicaoY;



    private Vector3 posiçãoPassaro;

    private bool pontuei;

    private UASCRIPT scriptDaUI;

    private void Awake()

    {

        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));

    }

    private void Start()

    {

        this.posiçãoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;

        this.scriptDaUI = GameObject.FindObjectOfType<UASCRIPT>();

    }

    private void Update()

    {

        if (!this.pontuei && this.transform.position.x < posiçãoPassaro.x)

        {

            Debug.Log("Pontuou");

            this.pontuei = true;

            this.scriptDaUI.adicionarPontos();

        }

        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D outro)

    {

        this.Destruir();

    }

    public void Destruir()

    {

        Destroy(this.gameObject);

    }

}