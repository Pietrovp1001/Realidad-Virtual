using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonsSequence : MonoBehaviour
{
        public int[] correctSequence; 
        public List<int> playerSequence; 
        public Light redLight; 
        public float lightDuration = 2f; 
        public GameObject capsule;
        public Material materialCapsule;
    
        private bool isCheckingSequence = false; 
        
        public void AddColorToSequence(int color)
        {
            if (isCheckingSequence) return; 
    
            playerSequence.Add(color);
    
           
            if (playerSequence.Count == correctSequence.Length)
            {
                StartCoroutine(CheckSequence());
            }
        }
        
        IEnumerator CheckSequence()
        {
            isCheckingSequence = true;
            
            bool isCorrect = true;
            for (int i = 0; i < correctSequence.Length; i++)
            {
                if (playerSequence[i] != correctSequence[i])
                {
                    isCorrect = false;
                    break;
                }
            }
            if (isCorrect)
            {
                OpenGunCapsule(); 
            }
            else
            {
                ShowError();
            }
            
            playerSequence.Clear();
            yield return new WaitForSeconds(lightDuration);
            HideLight();
    
            isCheckingSequence = false;
        }
        
        void OpenGunCapsule()
        {
            Debug.Log("Secuencia correcta");
            LeanTween.value(materialCapsule.color.a, 0f, 1f).setEaseInSine().setOnComplete(HideCapsule);
        }
        
        void ShowError()
        {
            Debug.Log("Secuencia mala");
            redLight.gameObject.SetActive(true);
        }
        void HideLight()
        {
            redLight.gameObject.SetActive(false);
        }

        void HideCapsule()
        {
            capsule.GetComponent<BoxCollider>().enabled = false;
            capsule.SetActive(false);
        }
        
}
