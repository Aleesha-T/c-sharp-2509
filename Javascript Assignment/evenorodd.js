function Check(){
    if(parseFloat(document.getElementById("num").value)%2==0){
        document.getElementById("Result").innerHTML="Number is even";
    }
    else{
        document.getElementById("Result").innerHTML="Number is odd";
    }
}