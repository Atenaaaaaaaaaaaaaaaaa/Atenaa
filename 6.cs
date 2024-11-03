Console.WriteLine("favorite food");
Console.WriteLine("Do you like fast food? ");
string isfastfood =  Console.ReadLine();
if (isfastfood== "yes"){
    Console.WriteLine("are you vegan?");
    string isvegan = Console.ReadLine();
    if (isvegan== "yes"){
        Console.WriteLine(" do you like salad? ");
        string likesalad = Console.ReadLine();
        if (likesalad== "yes"){
            Console.WriteLine("the food is seasonal salad");
        }
        else{
            Console.WriteLine("the food is vegetable pizza");
        }
    }
    else{
        Console.WriteLine("the food is hamburger ");
    }
}
else {
    Console.WriteLine(" do you like rice? ");
    string likerice = Console.ReadLine();
    if (likerice == "yes"){
        Console.WriteLine("the food is ghormesabzi");
    }
    else{
        Console.WriteLine("the food is sandwich");
    }
}