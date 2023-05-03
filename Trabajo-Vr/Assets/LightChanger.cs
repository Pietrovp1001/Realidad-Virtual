using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
   public Light luzSalaInicial;
   
   
   public void ChangeLight()
   {
       luzSalaInicial.color = Color.green;
   }
}
