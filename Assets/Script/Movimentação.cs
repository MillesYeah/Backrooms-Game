using UnityEngine;

public class Movimentação : MonoBehaviour{
    [SerializeField] private float velocidade = 10f;
    [SerializeField] private float velocidade_giro = 10f;
    [SerializeField] private KeyCode teclaCima = KeyCode.W;
    [SerializeField] private KeyCode teclaBaixo = KeyCode.S;
    [SerializeField] private KeyCode teclaEsquerda = KeyCode.A;
    [SerializeField] private KeyCode teclaDireita = KeyCode.D;
    void Update(){
        float andarLados = 0f;
        float andarFrente = 0f;
        if (Input.GetKey(teclaDireita)) andarLados = 1f;
        if (Input.GetKey(teclaEsquerda)) andarLados = -1f;
        if (Input.GetKey(teclaCima)) andarFrente = 1f;
        if (Input.GetKey(teclaBaixo)) andarFrente = -1f;

        transform.Rotate(Vector3.up, andarLados * velocidade_giro * Time.deltaTime);
        transform.Translate(Vector3.forward * andarFrente * velocidade * Time.deltaTime);
    }
}