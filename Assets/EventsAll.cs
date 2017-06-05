using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventsAll : MonoBehaviour {
    







    public void TestDebugLogEvent() // Данный метод используем для тестов и проверки всякой хуени
    {
        Debug.Log("Ты вызвал меня TestDebugLogEvent");
    }
    public void OpenSundukAnimation(GameObject krishka)
    {
        
       
          krishka.GetComponent<Animator>().SetBool("status", true);
      
        


    }
    public void CloseSundukAnimation(GameObject krishka)
    {
        krishka.GetComponent<Animator>().SetBool("status", false);



    }


























}
