using UnityEngine;

public class figure_movement : MonoBehaviour
{
    // Diese Funktion wird von Unity automatisch aufgerufen, 
    // wenn mit der Maus auf den Collider des Objekts geklickt wird.
    private void OnMouseDown()
    {
        // Gibt den Namen des Objekts aus, auf das geklickt wurde
        Debug.Log("Klick auf: " + gameObject.name);
        
        // Oder gib die Position aus, um dein Koordinatensystem zu prüfen
        Debug.Log("Position des Feldes: " + transform.position);
    }
}