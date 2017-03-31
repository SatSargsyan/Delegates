# Delegates

```C#
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
            if (dels!= null) dels(this);
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
            s.Register(new Del(ObsB.See));//( is calling by name class, because the method is static )

            s.OOPS(); 
            Console.ReadKey();
        }
    }
}
```

[About delegates](https://github.com/SatSargsyan/Delegates/blob/master/Delegates/Delegates_explaintation.md)

![ev3](https://cloud.githubusercontent.com/assets/20840005/22307921/57292fda-e35e-11e6-9e7b-99d24d95feea.gif)
