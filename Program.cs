//Astronomy Final - Creative Project
//Habitable Zone Calculator
//Life of a Star Simulator

//start main

//Welcome Message
System.Console.WriteLine("Welcome to the Astronomy program! Please choose from the menu options below...");

System.Console.WriteLine(@"         _.._");
System.Console.WriteLine(@"       .' .-'`");
System.Console.WriteLine(@"      /  /");
System.Console.WriteLine(@"      |  |");
System.Console.WriteLine(@"      \  \");
System.Console.WriteLine(@"       '._'-._");
System.Console.WriteLine(@"           ```");

int userChoice = GetUserChoice(); // priming read
while (userChoice != 4){ // condition check 
    RouteChoice(userChoice);
    userChoice = GetUserChoice(); // update read
}
// end main 

//***METHODS***//
static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0; // returning a number so int.Parse
}

static void DisplayMenu(){ // display the menu choice
    //Console.Clear();
    System.Console.WriteLine("1)  Habitability Calculator\n2)  Star Life Cycle Simulation\n3)  Red Shift Calculator\n4)  Exit");
    
}

static bool IsValidChoice(string userInput){ // checks to see if the user choice was valid to run
    if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4"){
        return true;
    }
    return false;
}

static void RouteChoice(int userChoice){ // routes the users choice to what they wanna do
    if(userChoice == 1){
        HabitableZoneCalculator();
    }
    else if(userChoice == 2){
        StarLifeSimulator();
    }
    else if(userChoice == 3){
        RedShiftCalculator();
    }
    else if(userChoice != 4){
        SayInvalid();
    }
}

static void SayInvalid(){ // states invalid if choice enetered is able to run
    System.Console.WriteLine("Invalid");
    PauseAction();
}

static void PauseAction(){ // pauses the console for the user to be able to see what the computer outputs
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void HabitableZoneCalculator()
{

    // Check if the planet is at the right distance from its star
    System.Console.WriteLine("Please enter how far your planet is from it's star in AU:");
    double distanceFromStar = double.Parse(Console.ReadLine());

    if (distanceFromStar >= 0.75 && distanceFromStar <= 1.5)
    {
        // Check if the planet's surface temperature is within the habitable range
        System.Console.WriteLine("Please enter the surface temperature of your planet in degrees Celsius:");
        int surfaceTemperature = int.Parse(Console.ReadLine());
        if (surfaceTemperature >= -10 && surfaceTemperature <= 50)
        {
            // Check if there is liquid water on the planet
            System.Console.WriteLine("Please enter the percent of your planet that is covered in water as a decimal:");
            double waterPresence = double.Parse(Console.ReadLine());
            if (waterPresence > 0.5)
            {
                // Check if the planet has a breathable atmosphere
                System.Console.WriteLine("Does your planet have Oxygen in its atmosphere (Y/N):");
                bool hasOxygen;
                try{
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        hasOxygen = true;
                    }
                    else
                    {
                        hasOxygen = false;
                    }
                    
                }
                catch{
                    System.Console.WriteLine("Invalid Response.");
                    System.Console.WriteLine("Does your planet have Oxygen in its atmosphere (Y/N):");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        hasOxygen = true;
                    }
                    else
                    {
                        hasOxygen = false;
                    }

                }
                if (hasOxygen)
                {
                    // The planet is habitable
                    System.Console.WriteLine("Huzzah! This planet is likely habitable! Let's go!");
                    System.Console.WriteLine();
                    PauseAction();
                }
                else
                {
                    System.Console.WriteLine("This planet is likely unhabitable :(");
                    System.Console.WriteLine();
                    PauseAction();
                }
            }
            else
            {
                System.Console.WriteLine("This planet is likely unhabitable :(");
                System.Console.WriteLine();
                PauseAction();
            }
        }
        else
        {
            System.Console.WriteLine("This planet is likely unhabitable :(");
            System.Console.WriteLine();
            PauseAction();
        }
    }
    else
    {
        System.Console.WriteLine("This planet is likely unhabitable :(");
        System.Console.WriteLine();
        PauseAction();
    }

}

static void StarLifeSimulator()
{
    //goes through the life of a star and shows descriptions/visuals of what’s happening within the star 

    // Prompt the user for the initial mass of the star
    Console.WriteLine("Enter the initial mass of the star (in solar masses):");
    double mass = double.Parse(Console.ReadLine());

    // Perform the different stages of the star's life
    Console.Clear();
    Console.WriteLine("Beginning main sequence stage...");
    MainSequence(mass);

    //from here I call the methods from within eachother because they branch different ways depending on mass

    PauseAction();
    System.Console.WriteLine();
    Console.WriteLine("Star has completed its life cycle.");
    System.Console.WriteLine();
    PauseAction();
}

static void MainSequence(double mass) {

    PauseAction();
    System.Console.WriteLine("The main sequence star is fusing hydrogen atoms into helium in its core, releasing a ton of energy in the process. " + 
    "This energy causes the star to shine brightly and generates enough pressure to counteract the force of gravity, maintaining the star's " + 
    "stable size and shape. As the star continues to burn through its hydrogen fuel, its core will eventually shrink and heat up, causing the outer layers " +
    "to expand and cool.");

    PauseAction();

    RedGiant(mass);
}

static void RedGiant(double mass) {

    Console.Clear();

    Console.WriteLine("Beginning red giant stage...");

    System.Console.WriteLine("The main sequence star has exhausted the hydrogen fuel in its core and begins to fuse helium into heavier elements. This causes the core to "+
    "shrink and heat up, while the outer layers expand and cool, resulting in the star's size increasing a lot. The star becomes much brighter and redder.");

    PauseAction();

    //checking mass to determine path
    if (mass > 8)
    {
        SuperGiant(mass);
    }
    else
    {
        PlanetaryNebula(mass);
    }


}

static void SuperGiant(double mass) {

    Console.Clear();

    System.Console.WriteLine("Beggining supergiant phase...");

    PauseAction();

    System.Console.WriteLine("The red giant star has exhausted its core hydrogen fuel and has begun fusing heavier elements. This causes the star's outer layers to expand and " +
    "cool, making it much larger and brighter than before. Supergiants can be many times larger than our sun and are some of the brightest objects in the universe.");

    PauseAction();

    // Send star to core collapse supernova
    CCSN(mass);
}

static void PlanetaryNebula(double mass) {

    Console.Clear();

    System.Console.WriteLine("Beggining planetary nebula phase...");

    PauseAction();

    System.Console.WriteLine("The red giant's outer layers begin to expand and cool, while its core contracts and heats up, producing intense energy. As a " +
    "result, the star's outer layers are ejected into space, forming a glowing cloud of gas and dust known as a planetary nebula.");

    // calling white dwarf
    WhiteDwarf(mass);
}

static void CCSN(double mass) {

    Console.Clear();

    System.Console.WriteLine("Beggining core collapse supernova phase...");

    PauseAction();

    System.Console.WriteLine("The supergiant's core has depleted all of its fuel and can no longer generate enough energy to counterbalance its own gravity. This causes the core to collapse, "+
    "releasing a shockwave that causes the star to explode. The explosion produces a bright flash of light that can outshine an entire galaxy "+
    "and can leave behind a dense, highly energetic object such as a neutron star or black hole.");

    System.Console.WriteLine();

    System.Console.WriteLine("What is the mass of the remnant star in Solar Masses?");
    mass = double.Parse(Console.ReadLine());

    //checking mass to decide where to send ot
    if (mass > 3)
    {
        BlackHole();
    }
    else
    {
        NuetronStar();
    }
}


static void WhiteDwarf(double mass) {

    Console.Clear();

    System.Console.WriteLine("Beggining white dwarf phase...");

    PauseAction();
    
    Console.WriteLine("The star has exhausted most of its nuclear fuel and collapsed down to a very small and dense size, about the size of the Earth but with a mass similar to that of the Sun. It no longer "+
    "generates energy through fusion and instead radiates away its remaining heat over billions of years, gradually cooling down to become a cold black dwarf.");

    // Prompt the user for a choice that will affect the star's evolution
    Console.WriteLine("Is the white dwarf in a binary star system? (Y/N)");
    char choice = char.Parse(Console.ReadLine().ToUpper());
    switch (choice) {
        case 'Y':
            //using random to get a 1/25 chance if its in a binary star system
            var rnd = new Random();
            int chance = rnd.Next(0,24);
            
            if(chance == 0)
            {
                WDSN(mass);
            }
            else
            {
                NuetronStar();
            }
            break;
        case 'N':
            // Send star to Nuetron Star
            NuetronStar();
            break;
    }

}

static void WDSN(double mass) {

    Console.Clear();

    System.Console.WriteLine("Beggining white dwarf supernova phase...");

    PauseAction();

    // Display visuals of what's happening within the star
    System.Console.WriteLine("The white dwarf has reached critical mass, leading to a runaway fusion reaction that causes the star to explode. The resulting explosion can outshine entire "+
    "galaxies and leave behind a remnant that may be either a neutron star or a black hole.");

}

static void NuetronStar() {

    Console.Clear();

    System.Console.WriteLine("Beggining nuetron star phase...");

    PauseAction();

    // Display visuals of what's happening within the star
    System.Console.WriteLine("The star has exhausted its nuclear fuel and has collapsed. The star's core collapsed under the force of gravity, "+
    "forming a highly dense object made mostly of neutrons. Neutron stars are incredibly hot and have strong magnetic fields, which can lead to intense radiation emissions "+
    "and the formation of funky matter.");

}

static void BlackHole() {

    Console.Clear();

    System.Console.WriteLine("Beggining black hole phase...");

    PauseAction();

    // Display visuals of what's happening within the star
    System.Console.WriteLine("The star has become so dense that its escape velocity exceeds the speed of light. This creates the event horizon, beyond which "+
    "nothing can escape. Anything that crosses the event horizon is pulled towards the black hole, an infinitely dense point at the center of the black hole where"+
    "the laws of physics as we know them break down. If you were to be pulled in you would become spaghettified!!!");

}

static void RedShiftCalculator()
{

    // Distance and redshift of a celestial object
    Console.WriteLine("Enter the distance to the celestial object (in light-years):");
    double distance = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the redshift of the celestial object:");
    double redshift = double.Parse(Console.ReadLine());

    // Calculate the speed of the celestial object based on its redshift
    double speed = redshift * 299792.458;

    // Output the distance and speed of the celestial object
    Console.WriteLine($"The celestial object is {distance} light-years away.");
    Console.WriteLine($"It is moving away from us at a speed of {speed} km/s.");

}