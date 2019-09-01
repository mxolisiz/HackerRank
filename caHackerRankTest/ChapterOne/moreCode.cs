using System.Diagnostics;

namespace caMcsdPractice.ChapterOne
{
    class moreCode: IMoreCode, IStringCode
    {
        public moreCode()
        {
            //initCode();
        }

        public void initCode()
        {
            Person person = new Person();
            int age = 50;
            PassValueTypeByRef(person, ref age);
            Debug.WriteLine($"{person.name} , {age}");
            PassValueTypeByRef(person, age);
            Debug.WriteLine($"{person.name} , {age}");
        }

        public void PassValueTypeByRef(Person val, ref int Age)
        {
            val.name = "Mxolisi";
            Age += 650;
        }

        public override string ToString()
        {
            return "Wenzani?";
        }

        public void PassValueTypeByRef(Person val, int Age)
        {
            val.name = "New Name";
            Age -= 650;
        }

        /*void IMoreCode.PassValueTypeByRef(Person val, ref int Age)
        {
            throw new System.NotImplementedException();
        }*/
    }

    interface IMoreCode
    {
        //
        void PassValueTypeByRef(Person val, ref int Age);
        void PassValueTypeByRef(Person val, int Age);
        
    }

    interface IStringCode
    {
        string ToString();//useless, all objects already implement ToString

    }
}
