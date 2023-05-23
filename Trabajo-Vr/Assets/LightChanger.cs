using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Interactables.Interactables;
using UnityEngine;
using UnityEngine.UIElements;
using Unity.UI;
using Image = UnityEngine.UI.Image;

public class LightChanger : MonoBehaviour
{
   public Light luzSalaInicial;
   public Light luzSecundaria1,luzSecundaria2,luzSecundaia3,luzSecundaria4,luzSecundaria5;
   [SerializeField] private Image spritePuertsIzquierda, spritePuertaDerecha;
   [SerializeField] private Sprite  nuevospriteIzquierda, nuevoSpriteDerecha;   
   public InteractableFacade puertaIzquierda, puertaDerecha;
   public void ChangeLight()
   {
       luzSalaInicial.color = Color.green;
       luzSecundaria1.color = Color.green;
       luzSecundaria2.color = Color.green;
       luzSecundaia3.color = Color.green; 
       luzSecundaria4.color = Color.green;
       luzSecundaria5.color = Color.green;
       spritePuertaDerecha.color = Color.green;
       spritePuertsIzquierda.color = Color.green;
       spritePuertsIzquierda.sprite = nuevospriteIzquierda;
       spritePuertaDerecha.sprite = nuevoSpriteDerecha;
       puertaIzquierda.enabled = true;
       puertaDerecha.enabled = true;
   }
}
