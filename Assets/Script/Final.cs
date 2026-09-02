using UnityEngine;
using UnityEngine.SceneManagement;
public class Final : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entrou na zona de finalização!");
            SceneManager.LoadScene("BSOD");
        }
    }
}