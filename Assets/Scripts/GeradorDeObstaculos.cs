using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {

    [SerializeField]
    // variável que controla quanto tempo cada obstáculo irá demorar para ser gerado
    private float tempoParaGerar;
    [SerializeField]
    //variável do tipo GameObjetct para receber um prefab
    private GameObject modeloObstaculo;
    //variável para eu saber quanto tempo já passou para que eu saiba se já é hora
    //de criar outro obstáculo
    private float cronometro;

    private void Awake()
    {
        //quando meu objeto for criado, o cronometro será igual ao tempo que configuramos
        //para ser gerado cada objeto, assim ele pode começar a contagem regressiva
        this.cronometro = this.tempoParaGerar;    
    }
    

    void Update () {
	      // O cronometro será diminuido de acordo com o tempo que passou de uma chamada
	      // do Update para outra chamada
        this.cronometro -= Time.deltaTime;
        //Quando o cronometro chegar em zero,
        if(this.cronometro < 0)
        {
	        //Instancia um novo objeto, aceitando quando parâmetro, qual objeto, onde instanciar e
	        //se eu quero usar a rotação
           GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
          //Quando o cronometro chega em zero, volta para o tempo inicial e reinicia a contagem  
           this.cronometro = this.tempoParaGerar;
        }

    }
}
