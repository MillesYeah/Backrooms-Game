using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int pontos=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            Debug.Log("Coletável coletado!");
            pontos++;
            
            Destroy(gameObject);
            
        }
    }
}

