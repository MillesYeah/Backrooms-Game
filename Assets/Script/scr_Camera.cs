using UnityEngine;

public class scr_Camera : MonoBehaviour
{
    [SerializeField] private Transform alvo;
    [SerializeField] private float altura = 5f;
    [SerializeField] private float distancia = 10f;
    [SerializeField] private float suavizacao = 0.1f;
    [SerializeField] private float suavizacaoRotacao = 0.1f;
    [SerializeField] private float angulo = 0f;
    //Bazinga
    void LateUpdate()
    {
        Vector3 posicaoDesejada = alvo.position - (alvo.forward * distancia) + (Vector3.up * altura);
        transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao * Time.deltaTime);
        Quaternion rotacaoDesejada = Quaternion.LookRotation(alvo.position + Vector3.up * altura - transform.position);
        rotacaoDesejada *= Quaternion.Euler(angulo, 0f, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacaoDesejada, suavizacaoRotacao * Time.deltaTime);
    }
}