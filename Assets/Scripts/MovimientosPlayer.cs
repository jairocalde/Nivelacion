using UnityEngine;

public class MovimientosPlayer : MonoBehaviour 
{
    public float moveSpeed = 5f; // Velocidad de movimiento
    private Rigidbody rb;
    private Vector3 initialPosition;

    private void Start()
    {
        // Guarda la posición inicial del Player
        initialPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con una pared, regresa a la posición inicial
        if (collision.gameObject.CompareTag("Wall"))
        {
            transform.position = initialPosition;
            Debug.Log("Colisión con pared. Reiniciando posición.");
        }
    }

    private void Update()
    {
        // Obtener entradas del teclado (W, A, S, D)
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");  

        // Movimiento en funcion de las teclas presionadas
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // Aplicar el movimiento al transform del objeto
        transform.Translate(movement, Space.World);

    }
}

