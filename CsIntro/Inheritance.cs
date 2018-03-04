using System;

namespace CsIntro
{
    class Inheritance
    {
        public void InheritanceSamples()
        {
            // We will use the classes below in this file to show the inheritance points discussed in the theory.
            var son = new Son();
            Console.WriteLine("Son's height is {0}", son.Height); // Notice that Height only exists in the Mother class
            son.CookTortillaDePatatas();

            var mother = new Mother();
            Console.WriteLine("Mother's height is {0}", mother.Height); // Notice that it was not affected by the Son setting a different thing
            mother.CookTortillaDePatatas();

            Console.WriteLine("Son's height still is {0}", son.Height);
        }
    }

    class Mother
    {
        protected double height;

        public double Height => this.height;

        public Mother()
        {
            this.height = 1.67;
        }

        public virtual void CookTortillaDePatatas()
        {
            Console.WriteLine("I fry the potatoes in a pan");
        }
    }

    class Son : Mother
    {
        public Son()
        : base() // this invokes the base constructor
        {

            base.height = 1.80; // we could use "this." height, but as the property is in the Base class, "base." is more semantic. This line only modifies the value for the current Son instance.
        }

        public override void CookTortillaDePatatas()
        {
            Console.WriteLine("If you ask my mom, this is what she would tell you:");
            // usually base methods do something that is requried for all its derived ones and we call it right in the beginning, but it is not mandatory. 
            // If the derived does not share anything with the base one you might want to consider using the new Modifier.
            base.CookTortillaDePatatas();
            Console.WriteLine("But I fry the potatoes in the microwave with little olive oil.");
        }
    }
}
