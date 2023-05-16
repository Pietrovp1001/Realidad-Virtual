using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
   public Light luzSalaInicial;
   public Light luzSecundaria1,luzSecundaria2,luzSecundaia3,luzSecundaria4,luzSecundaria5;
   
   
   public void ChangeLight()
   {
       luzSalaInicial.color = Color.green;
       luzSecundaria1.color = Color.green;
       luzSecundaria2.color = Color.green;
       luzSecundaia3.color = Color.green; 
       luzSecundaria4.color = Color.green;
       luzSecundaria5.color = Color.green;
   }
}
