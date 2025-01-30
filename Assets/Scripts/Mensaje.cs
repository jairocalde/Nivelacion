using UnityEngine;
using TMPro;

public class Mensaje : MonoBehaviour
{
    public TextMeshProUGUI winMessage;

    private void OnTriggerEnter(Collider other)
    {
        // Si el Player toca la meta, muestra el mensaje
        if (other.CompareTag("Player"))
        {
            ShowWinMessage();
        }

    }
    private void ShowWinMessage()
    {
        winMessage.gameObject.SetActive(true);
        Debug.Log("¡Ganaste!");
        
    }
}
