namespace VehicleManagement;

class Program
{
    static void Main(string[] args)
    {
        var ui = new UserInterface();
        ui.Run();
    }
}


//--- Answers to Questions ---
// F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
// A: Du kommer att få ett kompileringsfel.  En lista av Motorcycle kan endast innehålla Motorcycle-objekt.
//    Car är en annan typ, även om båda ärver från Vehicle.

// F: Vilken typ bör en lista vara för att rymma alla fordonstyper?
// A: List<Vehicle>.  Eftersom alla fordonstyper ärver från Vehicle, kan en lista av typen Vehicle referera
//    till objekt av vilken som helst av dessa subklasser.

// F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
// A: Nej, man kan inte direkt komma åt Clean() från en List<Vehicle>. Vehicle vet inte om Clean(). Man måste
//    casta objektet till ICleanable först (med "as" eller "is") för att komma åt metoden.

// F: Vad är fördelarna med att använda ett interface här istället för arv?
// A: En klass kan implementera flera interface, vilket ger mer flexibilitet än enkelarv. En Car kan vara ICleanable och något annat.
//    Interface definierar ett kontrakt (metoder som måste implementeras) utan att tvinga en specifik arvshierarki.
//    Arv skapar en "is-a" relation (en Car *är* en Vehicle), medan ett interface skapar en "can-do" relation (en Car *kan* rengöras).

