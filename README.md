# SmartHomeDesignPatterns
Projekt med Observer, Command, Strategy och Facade
# Smart Home – Designmönster

Det här är ett skolprojekt där jag försökte lära mig hur olika designmönster funkar i C#.  
Jag är fortfarande ganska ny på det här, så jag har försökt göra det så enkelt som möjligt och förstå vad varje mönster gör.

Projektet handlar om en lampa som kan styras på olika sätt. Jag använde fyra designmönster:

## Observer
Här ville jag att lampan skulle kunna “säga till” andra klasser när den tänds eller släcks.  
Jag gjorde två observers: en dashboard och en logger.  
När lampan ändras får båda ett meddelande.  
Det tog lite tid att förstå, men när jag såg utskrifterna i konsolen fattade jag grejen.

## Command
Här gjorde jag kommandon för att tända och släcka lampan.  
Det som var nytt för mig var att man kan lägga kommandon i en kö och köra dem i ordning.  
Man kan också spela upp de senaste kommandona igen.  
Det kändes faktiskt rätt smart när det väl funkade.

## Strategy
Jag gjorde tre olika “modes”: Normal, Eco och Party.  
Varje mode bestämmer om lampan får tändas eller inte.  
Det här mönstret gjorde att jag förstod hur man kan byta beteende utan att ändra själva koden i lampan.

## Facade
Till slut gjorde jag en SmartHomeFacade som samlar allt i ett enda gränssnitt.  
Det gör att man slipper anropa alla klasser direkt.  
Det här var nog det enklaste mönstret att förstå.

---

Jag är fortfarande inte expert, men jag har lärt mig mycket av att bygga det här projektet.
