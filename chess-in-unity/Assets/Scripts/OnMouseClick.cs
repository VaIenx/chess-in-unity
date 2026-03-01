using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDetector : MonoBehaviour
{
    int press = 1;
    GameObject ActiveFigure;

    void Update()
    {
        // Wir prüfen nur einmal pro Frame, ob geklickt wurde
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

            if (press == 1)
            {
                // SCHRITT 1: Figur auswählen
                Collider2D hit = Physics2D.OverlapPoint(mousePos);

                if (hit != null)
                {
                    ActiveFigure = hit.gameObject;
                    Debug.Log("Figur ausgewählt: " + ActiveFigure.name);
                    press = 2; // Bereit für den zweiten Klick
                }
            }
            else if (press == 2)
            {
                // SCHRITT 2: Figur bewegen
                if (ActiveFigure != null)
                {
                    ActiveFigure.transform.position = new Vector3(((int)mousePos.x) + 0.5f , ((int)mousePos.y) +0.5f, ActiveFigure.transform.position.z);
                    Debug.Log("Figur bewegt nach: " + (int)mousePos.x + (int)mousePos.y);
                    
                    ActiveFigure = null; // Auswahl aufheben
                }
                
                press = 1; // Zurück zum Anfang
            }
        }
    }
}