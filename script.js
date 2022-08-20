function convert(){
    var result = 0;
    var num = document.getElementById('num').value;
    
    for(var j = 0; j < num.length; j++){
    
        if(num[num.length - 1 - j] == '1'){
            result += 2**j;
        }    
        
    }
    
    document.getElementById('output').innerHTML = result;

        //document.getElementById('output').innerHTML = result;
    

}
