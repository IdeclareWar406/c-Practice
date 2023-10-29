Random subs = new Random();
    int daysUntilExpire = subs.Next(12);
    int discount = 0;

    if(daysUntilExpire >= 10){

    }
    else if((daysUntilExpire < 10) && (daysUntilExpire > 5)){
        Console.WriteLine("Your subscription will expire soon");
    }
    else if((daysUntilExpire <= 5) && (daysUntilExpire > 1)){
        discount = 10;
        Console.WriteLine($"Your subscription will expire in {daysUntilExpire} renew now and save {discount}%");
    }
    else if((daysUntilExpire <=1)&& (daysUntilExpire > 0)){
        discount = 20;
        Console.WriteLine($"Your sub will expire soon {daysUntilExpire} renew now and save {discount}% ");
    }
    else if(daysUntilExpire == 0){
        Console.WriteLine("Your subscription has expired");
    }