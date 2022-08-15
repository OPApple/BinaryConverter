while(true){
    Console.Write("Enter a binary number: ");
    string num =  Console.ReadLine();

    for (int i = 2; i < 10; i++){
        bool notBinary = num.Contains(i.ToString());
        if (notBinary){
            Console.WriteLine("Bruh");
            break;
        }else{

           
        }
        
    }
    converter(num);


}

static void converter(string num){
    long result = 0;
    for(int i = 0; i < num.Length; i++){
        if(num[num.Length - 1 - i] == '1'){
            result += Convert.ToInt64(Math.Pow(2, i));
        }

    }

    Console.WriteLine("In base 10 that is: " + result);
    
    
}