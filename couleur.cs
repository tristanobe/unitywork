using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Déclaration d'une variable pour stocker la nouvelle couleur
    public Color newColor;

    // Cette méthode est appelée au démarrage du jeu
    void Start()
    {
        // Obtenir le composant Renderer de l'objet pour accéder à son matériau
        Renderer renderer = GetComponent<Renderer>();
        
        // Changer la couleur du matériau à la nouvelle couleur
        renderer.material.color = newColor;
    }
}
