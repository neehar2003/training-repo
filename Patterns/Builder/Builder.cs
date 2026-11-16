// Builder pattern
// Problem: if an object has many optional things, the constructor gets confusing,
// like new Omelette(true, false, false) - which one is oil, which is onion or chilly.
// In builder we add the things we want one by one and then call Build().

class Omelette
{
    public bool Oil;
    public bool Onion;
    public bool Chilly;
}

class OmeletteBuilder
{
    private Omelette omelette = new Omelette();

    public void AddOil()
    {
        omelette.Oil = true;
    }

    public void AddOnion()
    {
        omelette.Onion = true;
    }
    public void AddChilly()
    {
        omelette.Chilly = true;
    }

    // returns the omelette we made
    public Omelette Build()
    {
        return omelette;
    }
}

// Usage:

// var builder = new OmeletteBuilder();

// builder.AddOil();
// builder.AddOnion();
// builder.AddChilly();

// Omelette myOmelette = builder.Build();   // omelette with oil, onion , chilly
