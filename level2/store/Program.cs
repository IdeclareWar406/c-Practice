string sku = "03-BL-S";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";



switch(product[0]){
    case "01":
    type = "Sweat Shirt";
    break;
    case "02":
    type = "T-Shirt";
    break;
    case "03":
    type= "Sweat Pants";
    break;
    default:
    type = "Does not match";
    break;
}

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } 
// else if (product[0] == "02")
// {
//     type = "T-Shirt";
// }
//  else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

switch(product[1]){
    case "BL":
    color = "Black";
    break;
    case "MN":
    color = "Maroon";
    break;
    default:
    color = "White";
    break;
}

switch(product[2]){
    case "S":
    size = "small";
    break;
    case "M":
    size = "Meduim";
    break;
    case "L":
    size = "large";
    break;
    default:
    size = "One size fits all";
    break;
}

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }
Console.WriteLine($"Product: {size} {color} {type}");