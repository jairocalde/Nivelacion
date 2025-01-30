using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;           // Referencia al Player
    public Vector3 offset = new Vector3(0, 5, -10); // Offset para la posición de la cámara
    public float Speed = 0.125f; // Suavidad del movimiento
 

    private void LateUpdate()
    {
        // Posición objetivo de la cámara
        Vector3 desiredPosition = player.position + offset;

        // Movimiento suave hacia la posición objetivo
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Speed);
        transform.position = smoothedPosition;

        // Hacer que la cámara mire hacia donde se mueve el Player
        Vector3 direction = player.position - transform.position; // Dirección desde la cámara al player
    }
}
