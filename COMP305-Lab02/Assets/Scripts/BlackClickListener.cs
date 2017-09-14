using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackClickListener : MonoBehaviour {

    //Sprites for different shirts
    public Sprite blackShirt;
    public Sprite redShirt;
    public Sprite blueShirt;

    //GameObject = pixel me
    public GameObject person;

    //SpriteRenderer is a component that renders the sprite...
    SpriteRenderer rend;

    void Start()
    {
        //first get the SpriteRenderer of the pixel person
        rend = person.GetComponent<SpriteRenderer>();
    }

    //method to change sprite of the pixel person (different shirt colours)
    void OnMouseDown()
    {
        rend.sprite = blackShirt;
    }
}
