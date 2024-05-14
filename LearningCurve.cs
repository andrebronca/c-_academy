using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //propriedades do mainCamera do objeto atual (v�nculo do script)
    public Transform CamTransform;

    //obter propriedades de outros objetos sem v�nculo com esse script
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
        //este script est� vinculado ao MainCamera, ent�o � f�cil saber a posi��o
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //localizando um outro objeto no cen�rio do jogo
        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log (LightTransform.localPosition);
        //poderia ser uma chamada encadeada: (evitar linhas longas, preferir legibilidade)
        LightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
