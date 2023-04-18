//Astronomy Final - Creative Project
//Habitable Zone Calculator
//Life of a Star Simulator

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
while (userChoice != 4){ // condition check // pretest loop(testing before)
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
    System.Console.WriteLine("1)  Habitability Calculator\n2)  Star Life Cycle Simulation\n3)  Red Shift Calculator\n4:  Exit");
    
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
    /***
    For a star of a certain temperature and luminosity, what is the range of distances a planet would 
    need to be from the star to be in the “habitable zone” where it might have the right temperature 
    for liquid water on its surface? You could imagine inputting the values for the star, and having 
    it tell you those distances. Even better, there are public database of all known planets — it would 
    be fantastic to have a program that goes through those and tells you if any are in the habitable zone!
    ***/

    //get the luminosity
    Console.WriteLine("Enter the planet's luminosity:");
    double luminosity = double.Parse(Console.ReadLine());

    if (luminosity >= 0.1 && luminosity <= 5.0) {
      Console.WriteLine("This planet is likely habitable.");
    } else {
      Console.WriteLine("This planet is not habitable.");
    }

    //Console.ReadKey();


}

static void StarLifeSimulator()
{
    /***
    an app that goes through the life of a star and shows visuals of what’s happening within the star 
    at each stages, and has the user choose different parameters for the star / situations that cause 
    the star to take different paths.
    ***/

    // Prompt the user for the initial mass of the star
    Console.WriteLine("Enter the initial mass of the star (in solar masses):");
    double mass = double.Parse(Console.ReadLine());

    // Perform the different stages of the star's life
    Console.WriteLine("Beginning main sequence stage...");
    MainSequence(mass);

    Console.ReadKey();

    Console.WriteLine("Beginning red giant stage...");
    RedGiant(mass);

    Console.ReadKey();

    Console.WriteLine("Beginning white dwarf stage...");
    WhiteDwarf(mass);

    Console.ReadKey();

    Console.WriteLine("Star has completed its life cycle.");
    Console.ReadKey();
}

static void MainSequence(double mass) {
    // Perform calculations for main sequence stage
    // ...

    // Display visuals of what's happening within the star
    // ...

    // Prompt the user for a choice that will affect the star's evolution
    Console.WriteLine("Choose an action to take:");
    Console.WriteLine("1. Increase the mass of the star");
    Console.WriteLine("2. Change the composition of the star");
    int choice = int.Parse(Console.ReadLine());

    // Update the star's parameters based on the user's choice
    switch (choice) {
        case 1:
            mass += 0.1;
            break;
        case 2:
            // Change the composition of the star
            break;
    }
}

static void RedGiant(double mass) {
    // Perform calculations for red giant stage
    // ...

    // Display visuals of what's happening within the star
    // ...

    // Prompt the user for a choice that will affect the star's evolution
    Console.WriteLine("Choose an action to take:");
    Console.WriteLine("1. Increase the mass loss rate of the star");
    Console.WriteLine("2. Change the temperature of the star");
    int choice = int.Parse(Console.ReadLine());

    // Update the star's parameters based on the user's choice
    switch (choice) {
        case 1:
            // Increase the mass loss rate of the star
            break;
        case 2:
            // Change the temperature of the star
            break;
    }
}

static void WhiteDwarf(double mass) {
    // Perform calculations for white dwarf stage
    // ...

    // Display visuals of what's happening within the star
    // ...

    // Prompt the user for a choice that will affect the star's evolution
    Console.WriteLine("Choose an action to take:");
    Console.WriteLine("1. Increase the mass of the star's companion");
    Console.WriteLine("2. Change the composition of the star");
    int choice = int.Parse(Console.ReadLine());

    // Update the star's parameters based on the user's choice
    switch (choice) {
        case 1:
            // Increase the mass of the star's companion
            break;
        case 2:
            // Change the composition of the star
            break;
    }
}

static void RedShiftCalculator()
{
    // Light-year conversion factor
    double ly = 9.461e+12;

    // Distance and redshift of a celestial object
    Console.WriteLine("Enter the distance to the celestial object (in light-years):");
    double distance = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the redshift of the celestial object:");
    double redshift = double.Parse(Console.ReadLine());

    // Calculate the speed of the celestial object based on its redshift
    double speed = redshift * 299792.458;

    // Output the distance and speed of the celestial object
    Console.WriteLine("The celestial object is {0:N2} light-years away.", distance);
    Console.WriteLine("It is moving away from us at a speed of {0:N0} km/s.", speed);

}