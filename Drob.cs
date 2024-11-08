namespace IntroToCs;

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
    public int Znamenatel { get => znamenatel; set => znamenatel = value;}

    static public Drob umnojenie(Drob drob1, Drob drob2)
    {
        int newChislite = drob1.Chislitel * drob2.Chislitel;
        int newZnamenate = drob1.Znamenatel * drob2.Znamenatel;
        Drob toReturn = new Drob();
        toReturn.Chislitel = newChislite;
        toReturn.Znamenatel = newZnamenate;
        
        return toReturn;
    }

    private Drob reciprocal(Drob drob)
    {
        return new Drob();
    }

    public Drob delenie(Drob drob, Drob drob2)
    {
        umnojenie(drob, reciprocal(drob2));
        return new Drob();
    }

    public void print()
    {
        Console.WriteLine(chislitel + "/" + znamenatel);
    }

    private void sykrashtavam()
    {
        // TODO: EUCLID
    }

    public Drob sum()
    {
        // TODO: LCD
        return new Drob();
    }

    public Drob minus()
    {
        return new Drob();
    }
}

