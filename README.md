# JurassicPark

E X P L O R E R  M O D E

    Create a class to represent your dinosaurs. The class should have the following properties:

          `Name`

          `DietType` - This will be "carnivore" or "herbivore"

          `WhenAcquired` - This will default to the current time when the dinosaur 
          is created

          `Weight` - How heavy the dinosaur is in pounds

          `EnclosureNumber` - The number of the pen the dinosaur is in


    Add a method `Description` to your class to print out a description of the dinosaur to include all the properties.
        Console.WriteLine(dinosaur.Description()); a method

    Create an output format of your choosing. Feel free to be creative.
    Keep track of your dinosaurs in a `List<Dinosaur>`. 

    When the console application runs, it should let the user choose one of the following actions:
         
      2    `View`
            - This command will show all the dinosaurs in the list, ordered by `WhenAcquired`. 
              If there aren't any dinosaurs in the park then print out a message that there aren't any.
          
      1    `Add`
            - This command will let the user type in the information for a dinosaur and add it to the list.
              Prompt for the `Name`, `DietType`, `Weight`, and `EnclosureNumber`, but the `WhenAcquired` must be supplied by the code.
          
      5    `Remove`
            - This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name. 
         
      4    `Transfer`
            - This command will prompt the user for a dinosaur name and a new `EnclosureNumber` and update the dinosaur's information.
          
      3    `Summary`
            - This command will display the number of carnivores and the number of herbivores. 
          
      6    `Quit`
            - This will stop the program. 


A D V E N T U R E  M O D E

    Consider what to do in Add/Remove/Transfer if multiple dinosaurs have the same name. Should `Add` prevent that from happening? Should `Transfer` and `Remove` show the multiple dinosaurs and prompt the user which one to work with?

    Add an option to view the dinosaurs acquired after a given date (to be given by the user).
    
    Add an option to view all the dinosaurs in a given enclosure number.


E P I C  M O D E

    Learn how to read and write from a file. At the start of the program load all the dinosaurs from a file. When the program ends write out all the dinosaurs to the same file.