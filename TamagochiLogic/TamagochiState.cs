using System;

namespace TamagochiLogic
{
    //part of memento
    public class TamagochiState
    {
        public int Bellyful { get; set; }
        public int Intellect { get; set; }
        public int Hapiness { get; set; }
        public int Health { get; set; }
        public int Water { get; set; }
        public string Name { get; set; }
        public long Age { get; set; }
        //Для отримання стану з обєкту тамагочі 
        public TamagochiState(int bellyful, int intellect, int happiness, int health, int water, string name, long age)
        {
            Bellyful = bellyful;
            Intellect = intellect;
            Hapiness = happiness;
            Health = health;
            Water = water;
            Name = name;
            Age = age;
        }
        //Для отримання стану з файлу а диску
        public TamagochiState()
        {
        }
    }
}

