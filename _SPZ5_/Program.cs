using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentList
{
    static class Program
    {
        //Варіант 4. Додаток зберігає інформацію про предметах, студентів та їх 
        //оцінках.Через Діалогове вікно можна редагувати списки студентів 
        //(додавання, видалення, зміна прізвища) і предметів (додавання, зміна назви, 
        //видалення), додавання оцінок. Реалізувати сортування списку за прізвищем 
        //студента або назвою предмета. Реалізувати сортування по успішності студентів.
 
         [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new MainForm() );
        }
    }
}
