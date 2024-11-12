
    class Drob
    {
        private int chislitel;
        private int znamenatel;

        public Drob()
        {
            this.chislitel = 0;
            this.znamenatel = 1;
        }

        public Drob(int chislitel, int znamenatel)
        {
            this.chislitel = chislitel;
            this.znamenatel = znamenatel;
        }
        public Drob(int chislitel)
        {
            this.chislitel = chislitel;
            this.znamenatel = 1;
        }


        public int Chislitel { get => chislitel; set => chislitel = value; }
        public int Znamenatel { get => znamenatel; set => znamenatel = value; }

        static public Drob umnojenie(Drob drob1, Drob drob2)
        {
            Drob newDrob = new Drob(drob1.Chislitel * drob2.Chislitel, drob1.Znamenatel * drob2.Znamenatel);
            return sykrashtavam(newDrob);
        }

        static private Drob reciprocal(Drob drob)
        {
            return new Drob(drob.Znamenatel, drob.Chislitel);
        }

        static public Drob delenie(Drob drob, Drob drob2)
        {
            return umnojenie(drob, reciprocal(drob2));
        }

        static public void print(Drob drob)
        {
            Console.WriteLine(drob.Chislitel + "/" + drob.Znamenatel);
        }

        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int buff = b;
                b = a % b;
                a = buff;
            }
            return Math.Abs(a);
        }
        static int NOK(int a, int b)
        {
            return Math.Abs(a * b) / NOD(a, b);
        }
        static public Drob sum(Drob drob1, Drob drob2)
        {
            int nok = NOK(drob1.Znamenatel, drob2.Znamenatel);
            return new Drob((drob1.Chislitel * (nok / drob1.Znamenatel)) + (drob2.Chislitel * (nok / drob2.Znamenatel)), nok);
        }

        static public Drob minus(Drob drob1, Drob drob2)
        {
            int nok = NOK(drob1.Znamenatel, drob2.Znamenatel);
            return new Drob((drob1.Chislitel * (nok / drob1.Znamenatel)) - (drob2.Chislitel * (nok / drob2.Znamenatel)), nok);
        }

        static public Drob sykrashtavam(Drob drob)
        {
            for (int i = 2; i <= Math.Min(drob.Chislitel, drob.Znamenatel); i++)
            {
                if (drob.Chislitel % i == 0 && drob.znamenatel % i == 0)
                {
                    drob.Chislitel = drob.Chislitel / i;
                    drob.Znamenatel = drob.Znamenatel / i;
                    i = 2;
                }
            }
            return new Drob(drob.Chislitel, drob.Znamenatel);
        }
    }
