using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;           // Referencia al Player
    public Vector3 offset = new Vector3(0, 5, -10); // Offset para la posici�n de la c�mara
    public float Speed = 0.125f; // Suavidad del movimiento
 

    private void LateUpdate()
    {
        // Posici�n objetivo de la c�mara
        Vector3 desiredPosition = player.position + offset;

        // Movimiento suave hacia la posici�n objetivo
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Speed);
        transform.position = smoothedPosition;

        // Hacer que la c�mara mire hacia donde se mueve el Player
        Vector3 direction = player.position - transform.position; // Direcci�n desde la c�mara al player
    }
}
