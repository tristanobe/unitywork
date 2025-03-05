using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    // Déclaration d'une variable pour contrôler la vitesse de rotation
    public float rotationSpeed = 50f;

    // Cette méthode est appelée à chaque frame
    void Update()
    {
        // Faire tourner l'objet autour de l'axe Y à la vitesse définie
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
