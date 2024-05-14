using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //propriedades do mainCamera do objeto atual (vínculo do script)
    public Transform CamTransform;

    //obter propriedades de outros objetos sem vínculo com esse script
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
        //este script está vinculado ao MainCamera, então é fácil saber a posição
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //localizando um outro objeto no cenário do jogo
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
