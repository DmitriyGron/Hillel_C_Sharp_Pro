using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_2_2
{
    public class MusicInstrument
    {
        private string name;
        private string description;
        private string history;

        public MusicInstrument(string name, string description, string history)
        {
            this.name = name;
            this.description = description;
            this.history = history;
        }

        public void Sound()
        {
            Console.WriteLine($"Звук музичного інструменту '{name}': звук");
        }

        public void Show()
        {
            Console.WriteLine($"Назва музичного інструменту: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Опис музичного інструменту '{name}': {description}");
        }

        public void History()
        {
            Console.WriteLine($"Історія створення музичного інструменту '{name}': {history}");
        }
    }

    public class Violin : MusicInstrument
    {
        public Violin(string name, string description, string history) : base(name, description, history) 
        {
            
        }
    }

    public class Trombone : MusicInstrument
    {
        public Trombone(string name, string description, string history) : base(name, description, history) 
        {
            
        }
    }

    public class Ukulele : MusicInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        { 
            
        }
    }

    public class Cello : MusicInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history) 
        {
            
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Скрипка", "Духовий струнний музичний інструмент", "Ранні прототипи скрипки можна знайти в різних культурах. Деякі з них включають стародавні інструменти, такі як римський самбук, грецька ребека та давньоєгипетська кемена");
            Trombone trombone = new Trombone("Тромбон", "Духовий музичний інструмент", "Історія тромбону багата і насичена, і його розвиток простягається протягом кількох століть");
            Ukulele ukulele = new Ukulele("Укулеле", "Струнний музичний інструмент", "Його історія пов'язана із Гавайськими островами.");
            Cello cello = new Cello("Віолончель", "Струнний музичний інструмент", "Цей музичний інструмент має глибокі корені і розвивався протягом багатьох століть");

            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();
            Console.WriteLine();

            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();
            Console.WriteLine();

            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc();
            ukulele.History();
            Console.WriteLine();

            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();

        }
    }
}
