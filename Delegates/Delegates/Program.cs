using System;

namespace Delegates
{

    public delegate void Del(object о);

    class Subj
    {
        Del dels;

        public void Register(Del d)
        {
            dels += d;
        }
        public void OOPS()
        {
            //Console.WriteLine("O----OOPS!");
            if (dels != null) dels(this);
        }

    }


    class ObsA
    {
        public void Do(object о)
        {
            Console.WriteLine("I see, that OOPS!");
        }
    }

    class ObsB
    {
        public static void See(object о)
        {
            Console.WriteLine("I see too, that OOPS!");
        }
    }
    class Program
    {
        static void Main()
        {
            Subj s = new Subj();

            ObsA o1 = new ObsA();
            ObsA o2 = new ObsA();

            s.Register(new Del(o1.Do));
            s.Register(new Del(o2.Do));
            s.Register(new Del(ObsB.See));//( is calling by name class, because method is static )

            s.OOPS();
            Console.ReadKey();
        }
    }
}
