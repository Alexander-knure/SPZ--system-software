/*Варіант 3. Профіль студента університету
У проекті передбачити розділення інтерфейсу та логіки типів, що створювалися під час виконання завдання. 
Передбачити створення виключень під час введення некоректних значень.
Дані типу:
•	ПІБ студента: не може бути порожнім рядком або містити цифри;
•	номера залікової книжки: не може містити пробіли;
•	курс: тільки ціле число;
•	середній бал: дійсне число, залежить від оцінок з предметів;
•	оцінки за 10 предметів за 100-бальною шкалою.
Методи типу:
•	ініціалізуючий конструктор;
•	встановлення оцінки за індексом предмета;
•  отримання значення оцінки за значенням предмета: всі предмети представляються у 
    перерахуванні з 10 елементів, у масиві предметів не може бути однакових елементів;
•	перевизначення методу ToString;
•	порівняння 2 студентів за оцінками: у результаті порівняння повертається масив різниці балів у предметах.*/

using System;
using System.Text;
using System.Collections.Generic;

namespace Lab1_var3
{
    public enum Subjects
    {
        Subject1, Subject2, Subject3, Subject4, Subject5,
        Subject6, Subject7, Subject8, Subject9, Subject10
    }
    class Student
    {
        private string Fullname;
        private string NumberGradebook;
        private int Course;
        private float AvgMark {
            get {
                float m = 0;
                foreach (var k in Marks.Values)
                    m += k;
                m /= Marks.Count;
                return m;
            }
        }
        private Dictionary<Subjects, int> Marks = new Dictionary<Subjects, int>();

        //Consruction
        public Student(string _Fullname, string _NumberGradebook, int _Course)
        {
            if (_Fullname.Length == 0)
                throw new ArgumentException("A fullname is empty!");

            for (int i = 0; i < _Fullname.Length; i++)
                if (char.IsDigit(_Fullname[i]))
                    throw new ArgumentException("A fullname contains digits!");
         
            Fullname = _Fullname;

            for (int i = 0; i < _NumberGradebook.Length; i++)
                if (char.IsWhiteSpace(_NumberGradebook[i]))
                    throw new ArgumentException("A number of gadebook contains space!");

            NumberGradebook = _NumberGradebook;

            if(_Course >= 1 && _Course <=6)
                Course = _Course;
            
            else
                throw new ArgumentException("A number of course is wrong!");
            

            var subjects = Enum.GetValues(typeof(Subjects));
        }
        
        public void SetMark(Subjects subject, int mark)
        {
            if (mark > 0 && mark <= 100)
            {
                this.Marks[subject] = mark;
                
            }
            else
                throw new Exception("A mark is wrong!");
        }

        public void SetMarks(Dictionary<Subjects, int> _marks)
        {
            this.Marks = _marks;
        }

        public int GetMark(Subjects subject)
        {
            return Marks[subject];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Lastname, name, patronomyc: ");
            sb.Append(Fullname);
            sb.Append("\nNumber of gradebook: ");
            sb.Append(NumberGradebook);
            sb.Append("\nCourse: ");
            sb.Append(Course);
            sb.Append("\nAverage mark: ");
            sb.Append(AvgMark);
            sb.Append("\n");
            Console.WriteLine(sb);
            return sb.ToString();
        }

        public int[] Compare(Student st)
        {
            var subjects = Enum.GetValues(typeof(Subjects));
            int[] array = new int[subjects.Length];
            int i = 0;

            foreach (Subjects sub in subjects)
            {
               
                if(this.Marks[sub] >= st.Marks[sub])
                array[i] = this.Marks[sub] - st.Marks[sub];
                else
                    array[i] = st.Marks[sub] - this.Marks[sub];
                i++;
            }

            return array;
        }
    }



    class StudentTest
    {
        static void Main()
        {
            Dictionary<Subjects, int> Marks1 = new Dictionary<Subjects, int>();
            Marks1.Add(Subjects.Subject1, 66);
            Marks1.Add(Subjects.Subject2, 74);
            Marks1.Add(Subjects.Subject3, 66);
            Marks1.Add(Subjects.Subject4, 88);
            Marks1.Add(Subjects.Subject5, 60);
            Marks1.Add(Subjects.Subject6, 100);
            Marks1.Add(Subjects.Subject7, 94);
            Marks1.Add(Subjects.Subject8, 79);
            Marks1.Add(Subjects.Subject9, 81);
            Marks1.Add(Subjects.Subject10, 85);

            Dictionary<Subjects, int> Marks2 = new Dictionary<Subjects, int>();
            Marks2.Add(Subjects.Subject1, 76);
            Marks2.Add(Subjects.Subject2, 84);
            Marks2.Add(Subjects.Subject3, 62);
            Marks2.Add(Subjects.Subject4, 100);
            Marks2.Add(Subjects.Subject5, 70);
            Marks2.Add(Subjects.Subject6, 60);
            Marks2.Add(Subjects.Subject7, 61);
            Marks2.Add(Subjects.Subject8, 67);
            Marks2.Add(Subjects.Subject9, 91);
            Marks2.Add(Subjects.Subject10, 95);

            Student st1 = new Student("Ivanov Aleksey Petrivoch", "AB2032", 5);
            st1.SetMarks(Marks1);
            st1.ToString();

            Student st2 = new Student("Romanov Ivan Borisovich", "AA1198", 2);
            st2.SetMarks(Marks2);
            st2.ToString();



            //Student test0 = new Student("", "BA5678", 3, Marks1);
            //Student test1 = new Student("12345", "BA5678", 3, Marks1);
            //Set mark
            st1.SetMark(Subjects.Subject1, 90);

            //Get mark
            int CheckMark1 = 0;
            CheckMark1 = st1.GetMark(Subjects.Subject3);
            Console.WriteLine("Subject3 mark: {0}", CheckMark1);
            st1.ToString();

            //Compare 
            int[] arr = new int[10];
            arr = st1.Compare(st2);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Subject {0}: {1}", i+1, arr[i]);
            Console.Read();
        }
    }
}


/*У проекті передбачити розділення інтерфейсу та логіки типів, що створювалися під час виконання завдання. 
 * Передбачити створення виключень під час введення некоректних значень.
Дані типу:
•	ПІБ власника: не може бути порожнім, тільки літери;         +
•	номер рахунку: 8 символів, тільки цифри, немає пробілів;    +
•	масив депозитів: депозит – перерахунок із 3-4 найменувань із різною відсотковою ставкою; +
•	сума на рахунку: тільки дійсні числа.                       +

Методи типу:
•	ініціалізуючий конструктор;                                 +
•	відкриття депозиту: додавання нового депозиту до масива;    +
•	нарахування відсотків по депозиту за рік;                   
•	поповнення рахунку;                                         +
•	зняття коштів з рахунку;                                    +
•	розірвання виділеного депозиту: видалення депозиту;         +
•	визначення загальної кількості коштів на депозитах;         
•	перевизначення методу ToString.
*/



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace СПЗ_1
//{
//    enum dep_name { classic, universal, alternative, premium };

//    class BANK_ACCOUNT
//    {
//        private string fio;
//        private string account;
//        private float balance;


//       public Dictionary<dep_name, float> depozits = new Dictionary<dep_name, float>();


//        public BANK_ACCOUNT(string _fio, string _account, float _balance)
//        {
//            if (_fio.Length == 0)
//                throw new Exception("your fio is empty");

//            foreach (char symbol in _fio)
//            {
//                if (char.IsDigit(symbol))
//                {
//                    throw new Exception("there is a numbers in your fio");
//                }
//            }
//            fio = _fio;
//            /////////////////////////////////
//            if (_account.Length == 0)
//                throw new Exception("your account number is empty");

//            if (_account.Length > 8)
//                throw new Exception("your account must contain no more than 8 symbols ");

//            foreach (char symbol in _account)
//            {
//                if (!char.IsDigit(symbol))
//                {
//                    throw new Exception("there is a letter in your account number");
//                }
//            }

//            for (int i = 0; i < _account.Length; i++)
//            {
//                if (_account[i] == ' ')
//                {
//                    throw new Exception("there is space in your account number");
//                }
//            }
//            account = _account;
//            ///////////////////////////////////
//            if (_balance < 0)
//                throw new Exception("your balance belowe than zero");
//            balance = _balance;

//            Print();
//        }

//        public void depozit_add(dep_name name, float money)
//        {
//            if (depozits.Count > 3)
//                Console.WriteLine("you have more than 3 depozit");
//            depozits.Add(name, money);

//        }

//        public void depozit_rem(dep_name name)
//        {
//            depozits.Remove(name);
//        }

//        public void year_proc(dep_name name, float value)
//        {
//            float var;
//            switch (name)
//            {

//                case dep_name.classic:
//                    var = 10;
//                    Console.WriteLine(value * var * 12);
//                    break;

//                case dep_name.universal:
//                    var = 11;
//                    Console.WriteLine(value * var * 12);
//                    break;

//                case dep_name.alternative:
//                    var = 12;
//                    Console.WriteLine(value * var * 12);
//                    break;

//                case dep_name.premium:
//                    var = 13;
//                    Console.WriteLine(value * var * 12);
//                    break;
//            }

//        }

//        public void Print()
//        {
//            Console.WriteLine("FIO:" + fio);
//            Console.WriteLine("Account:" + account);
//            Console.WriteLine("Balance:" + balance);
//            foreach (KeyValuePair<dep_name, float> kvp in depozits)
//            {
//                Console.WriteLine("depozit={0},depozit balance={1}", kvp.Key, kvp.Value);
//            }

//            /*foreach (KeyValuePair<DateTime, string> kvp in dictionary)
//    {
//        //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
//        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
//    }*/
//        }

//        public void Balance_add(float value)
//        {
//            balance += value;
//        }

//        public void Balance_diff(float value)
//        {
//            balance -= value;
//        }


//    }


//    class Program
//    {
//        public static void Main(string[] args)
//        {

//            BANK_ACCOUNT a = new BANK_ACCOUNT("Kutsyn V.U", "12345678", 6000);
//            Console.WriteLine();
//            BANK_ACCOUNT b = new BANK_ACCOUNT("Tereschenko A.V.", "87654321", 7000);
//            Console.WriteLine();
//            int add = 500;
//            int diff = 700;
//            Console.ReadKey();
//            Console.Clear();
//            a.Balance_add(add);
//            b.Balance_diff(diff);
//            a.Print();
//            Console.WriteLine();
//            b.Print();
//            Console.ReadKey();
//            Console.Clear();
//            Console.WriteLine("depozits:classic(10%),universal(11%),alternative(12%),premium(13%)");
//            a.depozit_add(dep_name.classic, 20000);
//            a.depozit_add(dep_name.alternative, 30000);
//            a.Print();
//            a.depozit_rem(dep_name.classic);
//            Console.WriteLine();
//            a.Print();
//            a.year_proc(dep_name.alternative, a.depozits[dep_name.alternative]);


//            Console.ReadKey();
//        }
//    }
//}

