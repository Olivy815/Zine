using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageChanger : MonoBehaviour
{
    public Image image; // Reference to the Image component
    public Sprite[] sprites; // Array of sprites to choose from

    public void ChangeImage()
    {
        int randomIndex = Random.Range(0, sprites.Length); // Generate a random index within the sprite array
        image.sprite = sprites[randomIndex]; // Change the sprite of the Image component to the randomly selected sprite
    }
}
