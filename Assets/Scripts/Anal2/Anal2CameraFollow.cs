using UnityEngine;

public class Anal2CameraFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;        // Ide húzd be a Player-t az Inspectorban
    public float smoothSpeed = 0.125f; // Mennyire "puhán" kövesse (kisebb = lassabb)

    // Ezt állítsd be olyan magasra, ahol a kamerát alapból látni szeretnéd
    public float fixedY = 0f;

    void LateUpdate()
    {
        if (target != null)
        {
            // Csak az X tengelyt vesszük át a célponttól, az Y marad fix
            Vector3 desiredPosition = new Vector3(target.position.x, fixedY, transform.position.z);

            // Simított mozgás (opcionális, de szebb)
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = smoothedPosition;
        }
    }
}
