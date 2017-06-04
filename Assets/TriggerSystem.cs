using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerSystem : MonoBehaviour
{
  EventsAll playobjects = new EventsAll(); // Экземпляр класса с эвентами
   public Animator krishka;
  public Text messagesuse;
  
  public string[] textmessage = new string[] {
      "" , "Чтобы открыть сундук нажмите клавишу (Действие)"

  };

    delegate void EventGaming(Animator objectstest); // Главный делегат управления эвентами ( в данном случае это анимации ) ( сделаю рефакторинг на GameObject позже ) более универсальное )
    event EventGaming manager = null; // На эту хрень подписываем эвенты

  


    void Start()
    {
      
        
    }


   
    

    public void OnTriggerStay(Collider lol) // Делаем проверку строго по Тэгу
    {

        if (lol.CompareTag("Player") )
        {
            messagesuse.text = textmessage[1];
            manager += playobjects.OpenSundukAnimation; // Подписываемся на эвент открытия крышки
            if (Input.GetKey(KeyCode.Space))
            {
                manager.Invoke(krishka); // Вызываем 1 раз
                
            }
            









        }
    }



    public void OnTriggerExit(Collider lol)
    {
        if (lol.CompareTag("Player"))
        {
            messagesuse.text = textmessage[0];


            playobjects.CloseSundukAnimation(krishka); // Закрытие крышки
                manager -= playobjects.OpenSundukAnimation; // отписываемся от эвента , чтобы вне коллайдера его не юзать.
   ;









        }

    }
  















}
    





    



	
	
