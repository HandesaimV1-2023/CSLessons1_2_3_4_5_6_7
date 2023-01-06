using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2
{
    internal class Group
    {
        Person[] parr = new Person[10];
        public void Add(Person p)
        {
            //....
        }

        // רוצה לקבל משתנה שיודע להשוות בין שני אנשים ולהחזיר  את התוצאה
        public void SortByName()
        {
            for (int i = 0; i < parr.Length; i++)
            {
                for (int j = i; j < parr.Length; j++)
                {
                    if(parr[i].Name >parr[j].Name ) // השוואה בין שני ערכים
                    {
                        // החלפה
                    }
                }
            }
        }
        public void Sort(string field)  // זה לא הגיוני לחשוב מראש ולכתוב את כל האפשרויות
        {
            for (int i = 0; i < parr.Length; i++)
            {
                for (int j = i; j < parr.Length; j++)
                {
                    if (field=="Name") // אז תשווה לפי השם וכן הלאה
                    if (parr[i].Name > parr[j].Name) // השוואה בין שני ערכים
                    {
                        // החלפה
                    }
                }
            }
        }
         
        public void CorrectSort(Comparison<Person> func)  // פונקציה שיודעת להשוות בין שני אנשים
        {
            for (int i = 0; i < parr.Length; i++)
            {
                for (int j = i; j < parr.Length; j++)
                {
                   
                        if (func (parr[i] , parr[j])>0) // השוואה בין שני ערכים
                        {

                            // החלפה
                        }
                }
            }
        }
    }
}
