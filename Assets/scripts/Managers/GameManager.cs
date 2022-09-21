using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Days{ MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY };
    public enum Time{ MORNING, MIDDAY, EVENING, NIGHT};

    public Days day;
    public Time time;

    public GameObject[] MondayMorning;
    public GameObject[] MondayMidday;
    public GameObject[] MondayEvening;
    public GameObject[] MondayNight;
    
    public GameObject[] TuesdayMorning;



    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeState(Days.TUESDAY, Time.NIGHT);
        }
    }



    private void ChangeState(Days _day, Time _time)
    {
        day = _day;
        time = _time;

        
       
    }
}
