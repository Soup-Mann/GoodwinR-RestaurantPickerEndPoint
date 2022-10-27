using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_RestaurantPicker.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{

[HttpGet]
[Route("{lame}")]
public string deeznuts(string lame){

Random rndNum = new Random();


if(lame != "1" || lame != "2" || lame != "3" || lame != "4"){
string[] FastFood = {"Taco Bell", "Mcdonalds", "Jack in the Box", "Carls Jr", "Popeyes", "Kanes", "PAnda Express", "KFC", "Papa Johns", "Dominoes"};
string[] DineIn = {"Strings", "Mikasa Sushi", "Petes Restaurant", "Titos", "Las Casuelas", "Cafe Platano", "AppleBees", "Chilis's", "West Coast Sourdough", "Indian Cafe"};
string[] Adventure = {"Go find the nearest taco truck!!", "Call Your next of Kin and Ask them to name the first restaurant that comes to mind!", "Ask a random person off the street for their input", "drive a random direction until you find someplace to eat!", "Find the worst rated place on yelp", "Find the highest rated place on yelp", "Find a place close to you that youve never eaten at", "Go to a breakfast place for dinner", "Call ur friend and ask them what you should get", "park ur car downtown and walk until you see something good!"};
string[] raandom = {"Taco Bell", "Mcdonalds", "Jack in the Box", "Carls Jr", "Popeyes", "Kanes", "PAnda Express", "KFC", "Papa Johns", "Dominoes", "Strings", "Mikasa Sushi", "Petes Restaurant", "Titos", "Las Casuelas", "Cafe Platano", "AppleBees", "Chilis's", "West Coast Sourdough", "Indian Cafe", "Go find the nearest taco truck!!", "Call Your next of Kin and Ask them to name the first restaurant that comes to mind!", "Ask a random person off the street for their input", "drive a random direction until you find someplace to eat!", "Find the worst rated place on yelp", "Find the highest rated place on yelp", "Find a place close to you that youve never eaten at", "Go to a breakfast place for dinner", "Call ur friend and ask them what you should get", "park ur car downtown and walk until you see something good!"};
switch(lame){
    case "1":
    int den = rndNum.Next(0,9);
    return $"You have Chosen fast food!\n--{FastFood[den]}-- ";
    case "2":
    int dinen = rndNum.Next(0,9);
    return $"You have chosen Dine-In!\n--{DineIn[dinen]}--";
    case "3":
    int advent = rndNum.Next(0,9);
    return $"You have chosen Adventure!\n--{Adventure[advent]}";
    case "4":
    int thirty = rndNum.Next(0,29);
     return $"You have chosen Random! ";
     
}

}
return $"{lame} is not between 1-4 :)\nThanks for playing !";
}
}
